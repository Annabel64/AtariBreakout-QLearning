using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Mission4_Atari_BreakOut
{
    public partial class Form1 : Form
    {
        // implementation of a QLearning algorithm that plays the Atari breackout game
        // There are two functions: an Exploration function allowing you to play 100 PlayGames where the platform moves randomly to fill a qVector with information,
        // and an Exploitation function which uses the qVector to play a final PlayGame and ensure that the platform can catch the ball without dropping it
        // the playing area is 350 by 400
        // the qVector will have to depend on x_ball, y_ball, vx_ball, vy_ball, x_platform, and will give, for a combination of (x_ball, y_ball, vx_ball, vy_ball), a gradient of x_platform


        #region ======================================================= Class Brick =====================================================

        public class Brick
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public bool IsAlive { get; set; }
            public Brush Color { get; set; }
            public Pen Contour { get; set; }

            public Brick(int x = 0, int y = 0, int width = 1)
            {
                X = x;
                Y = y;
                Width = width;
                IsAlive = true;
                Color = Brushes.Pink;
                Contour = Pens.Black;
            }

            public bool CollidesWith(int x_ball, int y_ball)
            {
                //vérifie si la balle et la brique sont supperposees
                if (Width == 1)
                {
                    if (x_ball == X && y_ball == Y)
                    {
                        return true;
                    }
                }
                else
                {
                    if ((x_ball == X - 1 || x_ball == X || x_ball == X + 1) && y_ball == Y)
                    {
                        return true;
                    }

                }

                return false;
            }

        }
        #endregion


        #region ======================================================= Parametres du jeu ===============================================

        readonly bool brick = true; //jouer avec des briques ou non
        public bool pauseBool = false;

        int dim = 10;//dimentions de l'interface
        int vx, vy; // vitesses de la balle
        List<Brick> bricks;
        Brick Plateforme;
        Brick Ball;
        float[][][][][][][][][] qVector;
        List<int> games;

        //rewards and penalties
        readonly int breakBrick = 60;
        readonly int bounce = 20;
        readonly int loose = -10;
        readonly double moves = -0.05; //penalty if moves left / right, so it doesnt moves too much
        readonly double time = -0.05; //penalty for taking too much time, so it goes for the shorter path


        public Form1()
        {
            InitializeComponent();
            InitializeGame();

            this.qVector = InitializeVector(false);
            UpdateGradient();

            string jsonFileGames = File.ReadAllText("games.json");
            games = JsonSerializer.Deserialize<List<int>>(jsonFileGames);
            UpdateGraphBounces();
        }

        private void InitializeGame()
        {
            // =================================== Initialization de la balle
            Random rnd = new Random();
            Plateforme = new Brick(rnd.Next(dim + 1), dim - 1, 3); //x, y, width
            Ball = new Brick(rnd.Next(dim + 1), dim - 2, 1); // balle part d'en bas
            vx = 0;
            vy = -1; // monte verticalement



            // =================================== Initialization de la liste des bricks
            this.bricks = new List<Brick>();
            if (brick)
            {
                Brush[] couleurs = new Brush[] { Brushes.OrangeRed, Brushes.LightSalmon, Brushes.LightYellow, Brushes.LightGreen, Brushes.LightBlue, Brushes.Lavender };

                //for (int i = 0; i < couleurs.Length; i++) //nb de lignes
                //{
                //    if (i % 2 == 0) // si i pair alors les lignes pas decalees (pour faire en quinconce)
                //    {
                //        for (int j = 0; j < 9; j++) //nb de briques par ligne
                //        {
                //            Brick b = new Brick(j * 35, i * 20 + 80, 35, 20); //x, y, largeur, hauteur
                //            b.color = couleurs[i];
                //            bricks.Add(b);
                //        }
                //    }
                //    else
                //    {
                //        for (int j = 0; j < 10; j++) //nb de briques par ligne
                //        {
                //            Brick b = new Brick(j * 35 - 25, i * 20 + 80, 35, 20);
                //            b.color = couleurs[i];
                //            bricks.Add(b);
                //        }
                //    }
                //}


                // 3 petites briques
                Brick b1 = new Brick(0, 1); b1.Color = couleurs[4];
                Brick b2 = new Brick(7, 1); b2.Color = couleurs[4];
                Brick b3 = new Brick(9, 1); b3.Color = couleurs[4];
                bricks.Add(b1);
                bricks.Add(b2);
                //bricks.Add(b3);
            }
        }


        public float[][][][][][][][][] InitializeVector(bool emptyV = true)
        {
            this.qVector = new float[dim + 1][][][][][][][][];
            if (emptyV)
            {
                // initialize qVector : 350 * 400 * 6 * 6 * 350 * 3 (x * y * vx * vy * x_plateforme * {right, immobile, vy})

                qVector = new float[dim + 1][][][][][][][][]; //x_ball
                for (int i = 0; i < qVector.Length; i++)
                {
                    qVector[i] = new float[dim][][][][][][][]; //y_ball
                    for (int j = 0; j < qVector[i].Length; j++)
                    {
                        qVector[i][j] = new float[3][][][][][][]; //vx_ball
                        for (int k = 0; k < qVector[i][j].Length; k++)
                        {
                            qVector[i][j][k] = new float[2][][][][][]; //vy_ball
                            for (int l = 0; l < qVector[i][j][k].Length; l++)
                            {
                                qVector[i][j][k][l] = new float[2][][][][]; // brique 1, 0 ou 1 si est vvt ou pas
                                for (int m = 0; m < qVector[i][j][k][l].Length; m++)
                                {
                                    qVector[i][j][k][l][m] = new float[2][][][]; //brique 2
                                    for (int n = 0; n < qVector[i][j][k][l][m].Length; n++)
                                    {
                                        qVector[i][j][k][l][m][n] = new float[2][][]; //brique 3
                                        for (int o = 0; o < qVector[i][j][k][l][m][n].Length; o++)
                                        {
                                            qVector[i][j][k][l][m][n][o] = new float[dim + 1][]; // x_plateforme
                                                for (int v = 0; v < qVector[i][j][k][l][m][n][o].Length; v++)
                                                {
                                                    qVector[i][j][k][l][m][n][o][v] = new float[3] { 0, 0, 0 }; //value for no move, left, right
                                                }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                string jsonFileQ = File.ReadAllText("qVector.json");
                qVector = JsonSerializer.Deserialize<float[][][][][][][][][]>(jsonFileQ);
            }
            return qVector;
        }

        public int PlayGame(bool train = false)
        {
            bool hasCollidedWithBrick = false; //pour parer le cas ou la balle touche 2 briques en mm temps
            Ball.X += vx;
            Ball.Y += vy;
            int resul = 0; // resul = 0 (rien de passe), -10 (balle tombee), 10 (balle detruit brique), 1 plateforme rattrape balle

            if (Plateforme.X > dim)
            {
                Plateforme.X = dim;
            }
            else if (Plateforme.X < 0)
            {
                Plateforme.X = 0;
            }

            //collisions murs + on verifie que la balle sort pas du cadre
            if (Ball.X >= dim) //si touche les bords, on change sa vitesse de signe
            {
                Ball.X = dim;
                vx = -vx;
            }
            else if (Ball.X <= 0)
            {
                Ball.X = 0;
                vx = -vx;
            }

            if (Ball.Y <= 0) //touche le plafond
            {
                Ball.Y = 0;
                vy = -vy;
                //vx = rnd.Next(3) - 1; //random direction entre -1, 0 et 1
            }
            else if (Ball.Y >= dim - 1) //balle tout en bas
            {
                Ball.Y = dim - 1;

                if (Plateforme.CollidesWith(Ball.X, Ball.Y))//collision plateforme
                {
                    //Random rnd = new Random();
                    //if (!train)
                    //{
                    //    pictureBoxGame.Refresh();
                    //}
                    //Plateforme.X = rnd.Next(dim); //n'importe ou sur l'axe horizontal
                    //Ball.X = rnd.Next(dim); //n'importe ou sur l'axe horizontal
                    //Ball.Y = 0; //en haut

                    if (Ball.X == Plateforme.X - 2 || Ball.X == Plateforme.X - 1)
                    {
                        vx = -1;
                    }
                    else if (Ball.X == Plateforme.X)
                    {
                        vx = 0;
                    }
                    else if (Ball.X == Plateforme.X + 1 || Ball.X == Plateforme.X + 2)
                    {
                        vx = 1;
                    }
                    vy = -vy;


                    resul = bounce;
                }
                else // si la balle n'est pas au dessus de la plateforme
                {
                    resul = loose;
                }
            }

            // collisions avec les bricks
            if (brick == true)
            {
                foreach (Brick b in bricks)
                {
                    // si la brique est vivante et touchee : elle devient morte, disparait et la balle rebondit
                    if (b.IsAlive && b.CollidesWith(Ball.X, Ball.Y) && hasCollidedWithBrick == false)
                    {
                        hasCollidedWithBrick = true;
                        vy = -vy;
                        b.IsAlive = false;
                        b.Color = Brushes.Transparent;
                        b.Contour = Pens.Transparent;
                        resul = breakBrick;
                    }
                }
            }

            //affichage si c'est pas pour du training
            if (!train)
            {
                Thread.Sleep(100);
                pictureBoxGame.Refresh();
                Updatepanel(); UpdateGradient();

                arrayCoord1.Text = "X = " + Ball.X.ToString() + "    Y = " + Ball.Y.ToString() + "    VX = " + vx.ToString() + "    VY = " + vy.ToString() + "    X_Plateforme = " + Plateforme.X.ToString();
                string msg = "";
                for (int i = 0; i < bricks.Count; i++)
                {
                    int alive = 0;
                    if (bricks[i].IsAlive)
                    {
                        alive = 1;
                    }
                    msg += "b" + i.ToString() + " = " + alive.ToString() + "; ";
                }
                arrayCoord2.Text = msg;
                arrayCoord1.Refresh(); arrayCoord2.Refresh();


                if (resul != 0)
                {
                    cumulRewards.Text = "Last reward = " + resul;
                    cumulRewards.Refresh();
                }

                if (resul == loose)
                {
                    using (Graphics g = pictureBoxGame.CreateGraphics())
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        g.DrawString("GAME OVER", new Font("Consolas", 35), Brushes.Red, pictureBoxGame.ClientRectangle, stringFormat);
                    }
                    timerLoop.Enabled = false;
                }
                else if (Victory())
                {
                    // "VICTORY" au milieu de la pictureBox
                    using (Graphics g = pictureBoxGame.CreateGraphics())
                    {
                        StringFormat stringFormat = new StringFormat();
                        stringFormat.Alignment = StringAlignment.Center;
                        stringFormat.LineAlignment = StringAlignment.Center;

                        g.DrawString("VICTORY", new Font("Consolas", 35), Brushes.GreenYellow, pictureBoxGame.ClientRectangle, stringFormat);
                    }
                    timerLoop.Enabled = false;
                }
            }
            return resul;
        }


        public bool Victory()
        {
            // en cas de victoire
            bool allBricksDead = true;
            if (brick)
            {
                foreach (Brick brick in bricks)
                {
                    if (brick.IsAlive)
                    {
                        allBricksDead = false;
                        break;
                    }
                }
            }
            else
            {
                allBricksDead = false;
            }
            return allBricksDead;
        }

        private List<int> StateBricks()
        {
            List<int> stateBricks = new List<int>();
            if (brick)
            {
                int compt = 0;
                foreach (Brick brick in bricks)
                {
                    stateBricks.Add(Convert.ToInt32(brick.IsAlive));
                    compt++;
                }
                for (int i = compt; i < 3; i++)
                {
                    stateBricks.Add(0);
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    stateBricks.Add(0);
                }
            }
            return stateBricks;
        }

        private Tuple<int, int> ChoseMove(bool exploration)
        {
            Tuple<int, int> moveAction = new Tuple<int, int>(0, 0);

            int b1 = StateBricks()[0];
            int b2 = StateBricks()[1];
            int b3 = StateBricks()[2];
            int current_vx = vx + 1;
            int current_vy = vy;
            if (vy == -1)
            {
                current_vy = 0;
            }

            float[] actions = qVector[Ball.X][Ball.Y][current_vx][current_vy][b1][b2][b3][Plateforme.X]; // actions based on qVector

            //choix de l'action
            Random rnd = new Random();
            int action; //action=0 dont move, 1 left, 2 right
            double p1 = rnd.NextDouble();
            double p2 = rnd.NextDouble();
            if ((!exploration && p2 < 0.99) || (exploration && p1 < 0.7))//&& !actions.Contains(10)
            {
                // si exploitation 
                // ou exploration dans 70% des cas
                action = Array.IndexOf(actions, actions.Max()); // action max
            }
            else //80% de random
            {
                action = rnd.Next(3);
            }

            // move en fonction de l'action choisie
            if (action == 1 && Plateforme.X > 0) //left
            {
                moveAction = new Tuple<int, int>(-1, action);
            }
            else if (action == 2 && Plateforme.X < dim) //right
            {
                moveAction = new Tuple<int, int>(1, action);
            }
            return moveAction;
        }

        #endregion


        #region ======================================================= Exploration =====================================================


        public void Exploration(double num_games_max = 1000000, double gamma = 0.90, double lR = 1)
        {
            using (Graphics g = pictureBoxGame.CreateGraphics())
            {
                g.Clear(Color.Black);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                g.DrawString($"TRAINING ...", new Font("Consolas", 30), Brushes.White, pictureBoxGame.ClientRectangle, stringFormat);
            }

            float boucePerGame = 0;
            float brickPerGame = 0;
            float num_games = 0;
            while (num_games < num_games_max)
            {
                num_games++;
                InitializeGame();

                while (true)
                {
                    if (num_games % 10000 == 0)
                    {
                        trainingNB.Text = "Training number :   " + num_games.ToString() + " / " + num_games_max.ToString();
                        trainingNB.Refresh();
                        bouncePerGame.Text = "Moyenne de bounce par game : " + (boucePerGame / num_games).ToString("0.000");
                        bouncePerGame.Refresh();
                        bricksPerGame.Text = "Moyenne de brick par game : " + (brickPerGame / num_games).ToString("0.000");
                        bricksPerGame.Refresh();
                    }


                    //les donnees actuelles
                    int current_x = Ball.X;
                    int current_y = Ball.Y;
                    int current_vx = vx + 1;
                    int current_vy = vy;
                    if (vy == -1)
                    {
                        current_vy = 0;
                    }
                    int b1 = StateBricks()[0];
                    int b2 = StateBricks()[1];
                    int b3 = StateBricks()[2];
                    int current_x_plateforme = Plateforme.X;

                    //choix de l'action, dans 35% des cas, on prendra les valeurs deja apprises, reste du temps random
                    Tuple<int, int> moveAction = ChoseMove(true);
                    Plateforme.X += moveAction.Item1;

                    double reward = PlayGame(true);
                    // on penalise lorsque le chemin prend du temps pour privilegier le plus court chemin et si ce n'est pas "rester immobile" (pour que la plateforme evite de faire gauche/droite)
                    double reward_adjusted = reward + time;
                    if (moveAction.Item2 != 0)
                    {
                        reward_adjusted += moves;
                    }

                    //compute value nextState
                    int new_vx = vx + 1;
                    int new_vy = vy;
                    if (vy == -1)
                    {
                        new_vy = 0;
                    }
                    float[] next_state = qVector[Ball.X][Ball.Y][new_vx][new_vy][StateBricks()[0]][StateBricks()[1]][StateBricks()[2]][Plateforme.X];
                    float maxQ = Math.Max(next_state[0], Math.Max(next_state[1], next_state[2])); // get max Q value of next next_state

                    //compute new value of the current state
                    this.qVector[current_x][current_y][current_vx][current_vy][b1][b2][b3][current_x_plateforme][moveAction.Item2] *= (float)(1 - lR);
                    this.qVector[current_x][current_y][current_vx][current_vy][b1][b2][b3][current_x_plateforme][moveAction.Item2] += (float)(lR * (reward_adjusted + gamma * maxQ)); // update Q value
                    // envoi parametre, reseau de neurones renvoit le reward


                    if (reward == bounce) { boucePerGame += 1; }
                    else if (reward == breakBrick) { brickPerGame += 1; }
                    if (reward == loose || Victory()) { break; }
                }

                if (num_games % 100000 == 0)
                {
                    //on ecrit tout dans le json pour pas perdre l'entrainement
                    string json = JsonSerializer.Serialize(this.qVector);
                    File.WriteAllText("qVector.json", json);
                }
            }



            using (Graphics g = pictureBoxGame.CreateGraphics())
            {
                g.Clear(Color.Black);
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;

                g.DrawString("Training complete", new Font("Consolas", 30), Brushes.White, pictureBoxGame.ClientRectangle, stringFormat);
            }

            timerLoop.Enabled = false;
        }


        private void ExplorationButton_Click(object sender, EventArgs e)
        {
            Exploration();
        }


        #endregion


        #region ======================================================= Exploitation ====================================================

        public void Exploitation(bool training = false)
        {
            InitializeGame();
            int compt = 0;
            int limitBounces = 20;

            while (!Victory() && compt < limitBounces)
            {
                int move = ChoseMove(false).Item1; // false car on prend toujours les valeurs du tableau

                Plateforme.X += move;
                double reward = PlayGame(training);
                if (reward == loose) // si game over
                {
                    //compt = 0;
                    break;
                }
                else if (reward == bounce) //balle rattrapee
                {
                    compt += 1;
                }
                if (!training)
                {
                    if (reward != 0)
                    {
                        cumulRewards.Text = "Last reward = " + reward;
                        cumulRewards.Refresh();
                    }

                    labelBounces.Text = "Number of bounces : " + compt.ToString() + " / " + limitBounces.ToString();
                    labelBounces.Refresh();

                    buttonStop.Refresh();
                    buttonGo.Refresh();
                    Application.DoEvents();

                    while (pauseBool)
                    {
                        Application.DoEvents();
                        buttonStop.Refresh();
                        buttonGo.Refresh();
                    }
                }
            }

            if (!training)
            {
                games.Add(compt);
                string jsonG = JsonSerializer.Serialize(this.games);
                File.WriteAllText("games.json", jsonG);
                UpdateGraphBounces();
                timerLoop.Enabled = false;
            }
        }

        private void ExploitationButton_Click(object sender, EventArgs e)
        {
            Exploitation();
        }

        #endregion


        #region ======================================================= Test parameters =================================================


        private void FindBestParams()
        {
            // ========================== test pour trouver les meilleurs parametres =================================
            List<double> listGamma = new List<double>() { 0.5, 0.6, 0.8, 0.9, 0.95 };
            List<int> listQVector = new List<int>() { 0, 1, 10 };

            //on initialise la liste games
            games = new List<int>();
            foreach (float gamma in listGamma)
            {
                List<int> moy = new List<int>();
                for (int i = 0; i < 3; i++) // faire avec 3 entrainements differents
                {
                    InitializeVector();
                    Exploration(500000, gamma);
                    for (int j = 0; j < 20; j++) // 20 predictions
                    {
                        Exploitation(true);
                    }
                }
                games.Add(Convert.ToInt32(moy.Average()));
                UpdateGraphBounces();
            }

            string jsonG = JsonSerializer.Serialize(this.games);
            File.WriteAllText("games.json", jsonG);
        }


        private void buttonBestParam_Click(object sender, EventArgs e)
        {
            FindBestParams();
        }

        #endregion


        #region ======================================================= Parametres FORM =================================================

        //======================================================= timers
        private void timerLoop_Tick(object sender, EventArgs e)
        {
            PlayGame(false);
        }


        //======================================================= buttons
        private void Play_Click(object sender, EventArgs e)
        {
            InitializeGame();
            timerLoop.Enabled = true;

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            pauseBool = true;
        }


        private void buttonGo_Click(object sender, EventArgs e)
        {
            pauseBool = false;
        }

        private void buttonNextState_Click(object sender, EventArgs e)
        {
            PlayGame(false);
        }

        private void buttonReinitGame_Click(object sender, EventArgs e)
        {
            games = new List<int>();
            string jsonG = JsonSerializer.Serialize(this.games);
            File.WriteAllText("games.json", jsonG);
            UpdateGraphBounces();
            chartLastGames.Refresh();
        }

        //======================================================= Déplacer la plateforme avec la souris

        private void pictureBoxGame_MouseMove(object sender, MouseEventArgs e)
        {
            Plateforme.X = (e.X / 35);
            cumulRewards.Refresh();
        }

        //======================================================= affichage
        private void pictureBoxGame_Paint(object sender, PaintEventArgs e)
        {
            // Dessiner cadrillage
            Pen whitePen = new Pen(Color.White, 1);
            for (int i = 00; i < 386; i += 35)
            {
                e.Graphics.DrawLine(whitePen, i, 0, i, pictureBoxGame.Height);
                e.Graphics.DrawLine(whitePen, 0, i, pictureBoxGame.Width, i);
            }

            // Dessin bricks
            foreach (Brick brick in bricks)
            {
                e.Graphics.FillRectangle(brick.Color, 35 * (float)brick.X, 35 * (float)brick.Y, 35 * brick.Width, 35);
                e.Graphics.DrawRectangle(brick.Contour, 35 * (float)brick.X, 35 * (float)brick.Y, 35 * brick.Width, 35);
            }

            // Dessin balle
            e.Graphics.FillEllipse(Ball.Color, 35 * (float)Ball.X, 35 * (float)Ball.Y, 35, 35);

            // dessin plateforme
            e.Graphics.FillRectangle(Plateforme.Color, 35 * (float)(Plateforme.X - 1), 35 * (float)Plateforme.Y + 30, 35 * Plateforme.Width, 10);

        }


        //======================================================= updates

        private void UpdateGradient()
        {
            int b1 = StateBricks()[0];
            int b2 = StateBricks()[1];
            int b3 = StateBricks()[2];
            int current_vx = vx + 1;
            int current_vy = vy;
            if (vy == -1)
            {
                current_vy = 0;
            }

            List<float> gradientImmobile = new List<float>();
            List<float> gradientLeft = new List<float>();
            List<float> gradientRight = new List<float>();
            List<int> absc = new List<int>() { };
            for (int i = 0; i < dim + 1; i++)
            {
                absc.Add(i);
            }

            foreach (float[] current_x_plateforme in qVector[Ball.X][Ball.Y][current_vx][current_vy][b1][b2][b3])
            {
                gradientImmobile.Add((float)(current_x_plateforme[0]));
                gradientLeft.Add((float)(current_x_plateforme[1]));
                gradientRight.Add((float)(current_x_plateforme[2]));
            }

            // Remplissage DataGridView (gradient immobile, left et right)
            int col;
            float maxValueI = gradientImmobile.Max();
            float minValueI = gradientImmobile.Min();
            float maxValueL = gradientLeft.Max();
            float minValueL = gradientLeft.Min();
            float maxValueR = gradientRight.Max();
            float minValueR = gradientRight.Min();

            textBox1.Text = gradientLeft[0].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[0] - minValueL) / (maxValueL - minValueL))), 255);
            textBox1.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox1.Refresh();

            textBox2.Text = gradientLeft[1].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[1] - minValueL) / (maxValueL - minValueL))), 255);
            textBox2.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox2.Refresh();

            textBox3.Text = gradientLeft[2].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[2] - minValueL) / (maxValueL - minValueL))), 255);
            textBox3.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox3.Refresh();

            textBox4.Text = gradientLeft[3].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[3] - minValueL) / (maxValueL - minValueL))), 255);
            textBox4.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox4.Refresh();

            textBox5.Text = gradientLeft[4].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[4] - minValueL) / (maxValueL - minValueL))), 255);
            textBox5.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox5.Refresh();

            textBox6.Text = gradientLeft[5].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[5] - minValueL) / (maxValueL - minValueL))), 255);
            textBox6.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox6.Refresh();

            textBox7.Text = gradientLeft[6].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[6] - minValueL) / (maxValueL - minValueL))), 255);
            textBox7.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox7.Refresh();

            textBox8.Text = gradientLeft[7].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[7] - minValueL) / (maxValueL - minValueL))), 255);
            textBox8.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox8.Refresh();

            textBox9.Text = gradientLeft[8].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[8] - minValueL) / (maxValueL - minValueL))), 255);
            textBox9.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox9.Refresh();

            textBox30.Text = gradientLeft[9].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[9] - minValueL) / (maxValueL - minValueL))), 255);
            textBox30.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox30.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox30.Refresh();

            textBox33.Text = gradientLeft[10].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientLeft[10] - minValueL) / (maxValueL - minValueL))), 255);
            textBox33.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox33.BackColor = Color.FromArgb(255 - col, 255, 255 - col);
            textBox33.Refresh();


            textBox12.Text = gradientImmobile[0].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[0] - minValueI) / (maxValueI - minValueI))), 255);
            textBox12.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox12.Refresh();

            textBox19.Text = gradientImmobile[1].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[1] - minValueI) / (maxValueI - minValueI))), 255);
            textBox19.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox19.Refresh();

            textBox18.Text = gradientImmobile[2].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[2] - minValueI) / (maxValueI - minValueI))), 255);
            textBox18.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox18.Refresh();

            textBox17.Text = gradientImmobile[3].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[3] - minValueI) / (maxValueI - minValueI))), 255);
            textBox17.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox17.Refresh();

            textBox16.Text = gradientImmobile[4].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[4] - minValueI) / (maxValueI - minValueI))), 255);
            textBox16.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox16.Refresh();

            textBox15.Text = gradientImmobile[5].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[5] - minValueI) / (maxValueI - minValueI))), 255);
            textBox15.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox15.Refresh();

            textBox14.Text = gradientImmobile[6].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[6] - minValueI) / (maxValueI - minValueI))), 255);
            textBox14.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox14.Refresh();

            textBox11.Text = gradientImmobile[7].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[7] - minValueI) / (maxValueI - minValueI))), 255);
            textBox11.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox11.Refresh();

            textBox10.Text = gradientImmobile[8].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[8] - minValueI) / (maxValueI - minValueI))), 255);
            textBox10.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox10.Refresh();

            textBox31.Text = gradientImmobile[9].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[9] - minValueI) / (maxValueI - minValueI))), 255);
            textBox31.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox31.Refresh();

            textBox34.Text = gradientImmobile[10].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientImmobile[10] - minValueI) / (maxValueI - minValueI))), 255);
            textBox34.BackColor = Color.FromArgb(255 - col, 255 - col, 255);
            textBox34.Refresh();


            textBox28.Text = gradientRight[0].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[0] - minValueR) / (maxValueR - minValueR))), 255);
            textBox28.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox28.Refresh();

            textBox27.Text = gradientRight[1].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[1] - minValueR) / (maxValueR - minValueR))), 255);
            textBox27.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox27.Refresh();

            textBox26.Text = gradientRight[2].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[2] - minValueR) / (maxValueR - minValueR))), 255);
            textBox26.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox26.Refresh();

            textBox25.Text = gradientRight[3].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[3] - minValueR) / (maxValueR - minValueR))), 255);
            textBox25.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox25.Refresh();

            textBox24.Text = gradientRight[4].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[4] - minValueR) / (maxValueR - minValueR))), 255);
            textBox24.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox24.Refresh();

            textBox23.Text = gradientRight[5].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[5] - minValueR) / (maxValueR - minValueR))), 255);
            textBox23.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox23.Refresh();

            textBox22.Text = gradientRight[6].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[6] - minValueR) / (maxValueR - minValueR))), 255);
            textBox22.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox22.Refresh();

            textBox21.Text = gradientRight[7].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[7] - minValueR) / (maxValueR - minValueR))), 255);
            textBox21.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox21.Refresh();

            textBox20.Text = gradientRight[8].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[8] - minValueR) / (maxValueR - minValueR))), 255);
            textBox20.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox20.Refresh();

            textBox32.Text = gradientRight[9].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[9] - minValueR) / (maxValueR - minValueR))), 255);
            textBox32.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox32.Refresh();

            textBox35.Text = gradientRight[10].ToString();
            col = Math.Min(Math.Max(0, (int)(255 * (gradientRight[10] - minValueR) / (maxValueR - minValueR))), 255);
            textBox35.BackColor = Color.FromArgb(255, 255 - col, 255 - col);
            textBox35.Refresh();


            chart1.Series.Clear();
            // Ajouter les trois séries de données au graphique
            chart1.Series.Add("Immobile");
            chart1.Series["Immobile"].ChartType = SeriesChartType.Spline;
            chart1.Series["Immobile"].Color = Color.Blue;

            chart1.Series.Add("Left");
            chart1.Series["Left"].ChartType = SeriesChartType.Spline;
            chart1.Series["Left"].Color = Color.Green;

            chart1.Series.Add("Right");
            chart1.Series["Right"].ChartType = SeriesChartType.Spline;
            chart1.Series["Right"].Color = Color.Red;

            for (int i = 0; i < absc.Count; i++)
            {
                chart1.Series["Immobile"].Points.AddXY(absc[i], gradientImmobile[i]);
                chart1.Series["Left"].Points.AddXY(absc[i], gradientLeft[i]);
                chart1.Series["Right"].Points.AddXY(absc[i], gradientRight[i]);
            }
        }

        private void UpdateGraphBounces()
        {
            if (games.Count() > 35)
            {
                List<int> valeurs = games.Skip(Math.Max(0, games.Count() - 35)).Take(35).ToList();
                chartLastGames.Series["Bounces"].Points.DataBindY(valeurs);
            }
            else if (games.Count() > 0)
            {
                chartLastGames.Series["Bounces"].Points.DataBindY(games);
            }
            chartLastGames.Refresh();
        }

        private void Updatepanel()
        {
            int b1 = StateBricks()[0];
            int b2 = StateBricks()[1];
            int b3 = StateBricks()[2];
            int current_vx = vx + 1;
            int current_vy = vy;
            if (vy == -1)
            {
                current_vy = 0;
            }

            float[] actions = qVector[Ball.X][Ball.Y][current_vx][current_vy][b1][b2][b3][Plateforme.X];



            // Personnaliser l'apparence des panel
            int colorValue0;
            int colorValue1;
            int colorValue2;
            if (actions[0] == actions.Max())
            {
                colorValue0 = 255;
            }
            else if (actions[0] == actions.Min())
            {
                colorValue0 = 0;
            }
            else
            {
                colorValue0 = 120;
            }

            if (actions[1] == actions.Max())
            {
                colorValue1 = 255;
            }
            else if (actions[1] == actions.Min())
            {
                colorValue1 = 0;
            }
            else
            {
                colorValue1 = 120;
            }

            if (actions[2] == actions.Max())
            {
                colorValue2 = 255;
            }
            else if (actions[2] == actions.Min())
            {
                colorValue2 = 0;
            }
            else
            {
                colorValue2 = 120;
            }



            // Affecter les valeurs du vecteur "actions" aux panel
            panel1.BackColor = Color.FromArgb(255 - colorValue1, 255 - colorValue1, 255);
            panel0.BackColor = Color.FromArgb(255 - colorValue0, 255 - colorValue0, 255);
            panel2.BackColor = Color.FromArgb(255 - colorValue2, 255 - colorValue2, 255);

            panel1.Refresh();
            panel0.Refresh();
            panel2.Refresh();

            textBoxPanel0.Text = Math.Round(actions[0], 3).ToString();
            textBoxPanel0.Refresh();
            textBoxPanel1.Text = Math.Round(actions[1], 3).ToString();
            textBoxPanel1.Refresh();
            textBoxPanel2.Text = Math.Round(actions[2], 3).ToString();
            textBoxPanel2.Refresh();
        }


        #endregion

    }
}


