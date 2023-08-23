namespace Mission4_Atari_BreakOut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxGame = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.ExplorationButton = new System.Windows.Forms.Button();
            this.ExploitationButton = new System.Windows.Forms.Button();
            this.trainingNB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBestParam = new System.Windows.Forms.Button();
            this.bricksPerGame = new System.Windows.Forms.TextBox();
            this.bouncePerGame = new System.Windows.Forms.TextBox();
            this.labelBounces = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonReinitGame = new System.Windows.Forms.Button();
            this.cumulRewards = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.chartLastGames = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.arrayCoord2 = new System.Windows.Forms.TextBox();
            this.arrayCoord1 = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPanel1 = new System.Windows.Forms.TextBox();
            this.textBoxPanel0 = new System.Windows.Forms.TextBox();
            this.textBoxPanel2 = new System.Windows.Forms.TextBox();
            this.boxQVectorLeft = new System.Windows.Forms.GroupBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boxQVectorImm = new System.Windows.Forms.GroupBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.boxQVectorRight = new System.Windows.Forms.GroupBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.buttonNextState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLastGames)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.boxQVectorLeft.SuspendLayout();
            this.boxQVectorImm.SuspendLayout();
            this.boxQVectorRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLoop
            // 
            this.timerLoop.Enabled = true;
            this.timerLoop.Interval = 1;
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick);
            // 
            // pictureBoxGame
            // 
            this.pictureBoxGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxGame.Location = new System.Drawing.Point(63, 130);
            this.pictureBoxGame.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxGame.Name = "pictureBoxGame";
            this.pictureBoxGame.Size = new System.Drawing.Size(513, 446);
            this.pictureBoxGame.TabIndex = 0;
            this.pictureBoxGame.TabStop = false;
            this.pictureBoxGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGame_Paint);
            this.pictureBoxGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGame_MouseMove);
            // 
            // Play
            // 
            this.Play.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Play.Location = new System.Drawing.Point(34, 657);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(102, 72);
            this.Play.TabIndex = 3;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // ExplorationButton
            // 
            this.ExplorationButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExplorationButton.Location = new System.Drawing.Point(154, 657);
            this.ExplorationButton.Name = "ExplorationButton";
            this.ExplorationButton.Size = new System.Drawing.Size(124, 72);
            this.ExplorationButton.TabIndex = 4;
            this.ExplorationButton.Text = "Exploration";
            this.ExplorationButton.UseVisualStyleBackColor = true;
            this.ExplorationButton.Click += new System.EventHandler(this.ExplorationButton_Click);
            // 
            // ExploitationButton
            // 
            this.ExploitationButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExploitationButton.Location = new System.Drawing.Point(291, 657);
            this.ExploitationButton.Name = "ExploitationButton";
            this.ExploitationButton.Size = new System.Drawing.Size(133, 72);
            this.ExploitationButton.TabIndex = 5;
            this.ExploitationButton.Text = "Exploitation";
            this.ExploitationButton.UseVisualStyleBackColor = true;
            this.ExploitationButton.Click += new System.EventHandler(this.ExploitationButton_Click);
            // 
            // trainingNB
            // 
            this.trainingNB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trainingNB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trainingNB.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.trainingNB.Location = new System.Drawing.Point(15, 28);
            this.trainingNB.Name = "trainingNB";
            this.trainingNB.Size = new System.Drawing.Size(480, 20);
            this.trainingNB.TabIndex = 9;
            this.trainingNB.Text = "Training number";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.buttonBestParam);
            this.groupBox1.Controls.Add(this.bricksPerGame);
            this.groupBox1.Controls.Add(this.bouncePerGame);
            this.groupBox1.Controls.Add(this.trainingNB);
            this.groupBox1.Location = new System.Drawing.Point(656, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 136);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exploration";
            // 
            // buttonBestParam
            // 
            this.buttonBestParam.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBestParam.Location = new System.Drawing.Point(374, 58);
            this.buttonBestParam.Name = "buttonBestParam";
            this.buttonBestParam.Size = new System.Drawing.Size(121, 72);
            this.buttonBestParam.TabIndex = 52;
            this.buttonBestParam.Text = "Best Param";
            this.buttonBestParam.UseVisualStyleBackColor = true;
            this.buttonBestParam.Click += new System.EventHandler(this.buttonBestParam_Click);
            // 
            // bricksPerGame
            // 
            this.bricksPerGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bricksPerGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bricksPerGame.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bricksPerGame.Location = new System.Drawing.Point(15, 95);
            this.bricksPerGame.Name = "bricksPerGame";
            this.bricksPerGame.Size = new System.Drawing.Size(436, 17);
            this.bricksPerGame.TabIndex = 11;
            this.bricksPerGame.Text = "bricksPerGame";
            // 
            // bouncePerGame
            // 
            this.bouncePerGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bouncePerGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bouncePerGame.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bouncePerGame.Location = new System.Drawing.Point(15, 65);
            this.bouncePerGame.Name = "bouncePerGame";
            this.bouncePerGame.Size = new System.Drawing.Size(436, 17);
            this.bouncePerGame.TabIndex = 10;
            this.bouncePerGame.Text = "bouncePerGame";
            // 
            // labelBounces
            // 
            this.labelBounces.BackColor = System.Drawing.SystemColors.Info;
            this.labelBounces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBounces.Location = new System.Drawing.Point(15, 64);
            this.labelBounces.Name = "labelBounces";
            this.labelBounces.Size = new System.Drawing.Size(377, 15);
            this.labelBounces.TabIndex = 29;
            this.labelBounces.Text = "Number of bounces";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.buttonReinitGame);
            this.groupBox2.Controls.Add(this.cumulRewards);
            this.groupBox2.Controls.Add(this.textBox);
            this.groupBox2.Controls.Add(this.labelBounces);
            this.groupBox2.Controls.Add(this.chartLastGames);
            this.groupBox2.Location = new System.Drawing.Point(656, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 376);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exploitation";
            // 
            // buttonReinitGame
            // 
            this.buttonReinitGame.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonReinitGame.Location = new System.Drawing.Point(374, 7);
            this.buttonReinitGame.Name = "buttonReinitGame";
            this.buttonReinitGame.Size = new System.Drawing.Size(121, 72);
            this.buttonReinitGame.TabIndex = 53;
            this.buttonReinitGame.Text = "Reinit grid";
            this.buttonReinitGame.UseVisualStyleBackColor = true;
            this.buttonReinitGame.Click += new System.EventHandler(this.buttonReinitGame_Click);
            // 
            // cumulRewards
            // 
            this.cumulRewards.BackColor = System.Drawing.SystemColors.Info;
            this.cumulRewards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cumulRewards.Location = new System.Drawing.Point(15, 34);
            this.cumulRewards.Name = "cumulRewards";
            this.cumulRewards.Size = new System.Drawing.Size(356, 15);
            this.cumulRewards.TabIndex = 29;
            this.cumulRewards.Text = "Last reward";
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Info;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox.Location = new System.Drawing.Point(62, 98);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(330, 15);
            this.textBox.TabIndex = 32;
            this.textBox.Text = "Results of the 30 last games played by the AI :";
            // 
            // chartLastGames
            // 
            this.chartLastGames.BackColor = System.Drawing.Color.PeachPuff;
            this.chartLastGames.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.chartLastGames.ChartAreas.Add(chartArea1);
            this.chartLastGames.Location = new System.Drawing.Point(11, 142);
            this.chartLastGames.Name = "chartLastGames";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Bounces";
            this.chartLastGames.Series.Add(series1);
            this.chartLastGames.Size = new System.Drawing.Size(474, 213);
            this.chartLastGames.TabIndex = 11;
            this.chartLastGames.Text = "30 last games";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox3.Controls.Add(this.arrayCoord2);
            this.groupBox3.Controls.Add(this.arrayCoord1);
            this.groupBox3.Location = new System.Drawing.Point(656, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 82);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Positions";
            // 
            // arrayCoord2
            // 
            this.arrayCoord2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arrayCoord2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrayCoord2.Location = new System.Drawing.Point(15, 51);
            this.arrayCoord2.Multiline = true;
            this.arrayCoord2.Name = "arrayCoord2";
            this.arrayCoord2.Size = new System.Drawing.Size(480, 24);
            this.arrayCoord2.TabIndex = 29;
            this.arrayCoord2.Text = "Array";
            // 
            // arrayCoord1
            // 
            this.arrayCoord1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.arrayCoord1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrayCoord1.Location = new System.Drawing.Point(13, 25);
            this.arrayCoord1.Multiline = true;
            this.arrayCoord1.Name = "arrayCoord1";
            this.arrayCoord1.Size = new System.Drawing.Size(482, 24);
            this.arrayCoord1.TabIndex = 28;
            this.arrayCoord1.Text = "Array";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Forte", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTitle.Location = new System.Drawing.Point(43, 28);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(578, 48);
            this.textBoxTitle.TabIndex = 32;
            this.textBoxTitle.Text = "Atari Breakout and QLearning";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonStop.Location = new System.Drawing.Point(460, 657);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(57, 36);
            this.buttonStop.TabIndex = 35;
            this.buttonStop.Text = "| |";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGo.Location = new System.Drawing.Point(460, 693);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(57, 36);
            this.buttonGo.TabIndex = 39;
            this.buttonGo.Text = "|>";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(1176, 456);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Left";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Immobile";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Name = "Right";
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(457, 300);
            this.chart1.TabIndex = 40;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(77, 582);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 10);
            this.panel1.TabIndex = 45;
            // 
            // panel0
            // 
            this.panel0.Location = new System.Drawing.Point(237, 582);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(154, 10);
            this.panel0.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(395, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 10);
            this.panel2.TabIndex = 46;
            // 
            // textBoxPanel1
            // 
            this.textBoxPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPanel1.Location = new System.Drawing.Point(106, 598);
            this.textBoxPanel1.Multiline = true;
            this.textBoxPanel1.Name = "textBoxPanel1";
            this.textBoxPanel1.Size = new System.Drawing.Size(101, 21);
            this.textBoxPanel1.TabIndex = 30;
            this.textBoxPanel1.Text = "ValueLeft";
            this.textBoxPanel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPanel0
            // 
            this.textBoxPanel0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPanel0.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPanel0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPanel0.Location = new System.Drawing.Point(264, 598);
            this.textBoxPanel0.Multiline = true;
            this.textBoxPanel0.Name = "textBoxPanel0";
            this.textBoxPanel0.Size = new System.Drawing.Size(110, 21);
            this.textBoxPanel0.TabIndex = 47;
            this.textBoxPanel0.Text = "ValueCenter";
            this.textBoxPanel0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPanel2
            // 
            this.textBoxPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPanel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPanel2.Location = new System.Drawing.Point(423, 598);
            this.textBoxPanel2.Multiline = true;
            this.textBoxPanel2.Name = "textBoxPanel2";
            this.textBoxPanel2.Size = new System.Drawing.Size(110, 21);
            this.textBoxPanel2.TabIndex = 48;
            this.textBoxPanel2.Text = "ValueRight";
            this.textBoxPanel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxQVectorLeft
            // 
            this.boxQVectorLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.boxQVectorLeft.Controls.Add(this.textBox33);
            this.boxQVectorLeft.Controls.Add(this.textBox30);
            this.boxQVectorLeft.Controls.Add(this.textBox9);
            this.boxQVectorLeft.Controls.Add(this.textBox8);
            this.boxQVectorLeft.Controls.Add(this.textBox7);
            this.boxQVectorLeft.Controls.Add(this.textBox6);
            this.boxQVectorLeft.Controls.Add(this.textBox5);
            this.boxQVectorLeft.Controls.Add(this.textBox4);
            this.boxQVectorLeft.Controls.Add(this.textBox3);
            this.boxQVectorLeft.Controls.Add(this.textBox2);
            this.boxQVectorLeft.Location = new System.Drawing.Point(1187, 84);
            this.boxQVectorLeft.Name = "boxQVectorLeft";
            this.boxQVectorLeft.Size = new System.Drawing.Size(128, 366);
            this.boxQVectorLeft.TabIndex = 30;
            this.boxQVectorLeft.TabStop = false;
            this.boxQVectorLeft.Text = "Left";
            // 
            // textBox33
            // 
            this.textBox33.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox33.Location = new System.Drawing.Point(6, 321);
            this.textBox33.Multiline = true;
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(116, 24);
            this.textBox33.TabIndex = 58;
            this.textBox33.Text = "1";
            // 
            // textBox30
            // 
            this.textBox30.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox30.Location = new System.Drawing.Point(6, 296);
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(116, 24);
            this.textBox30.TabIndex = 57;
            this.textBox30.Text = "1";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Location = new System.Drawing.Point(6, 266);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(116, 24);
            this.textBox9.TabIndex = 56;
            this.textBox9.Text = "1";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(6, 236);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(116, 24);
            this.textBox8.TabIndex = 55;
            this.textBox8.Text = "1";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(6, 206);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(116, 24);
            this.textBox7.TabIndex = 54;
            this.textBox7.Text = "1";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(6, 176);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 24);
            this.textBox6.TabIndex = 53;
            this.textBox6.Text = "1";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(6, 148);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 24);
            this.textBox5.TabIndex = 52;
            this.textBox5.Text = "1";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(6, 118);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 24);
            this.textBox4.TabIndex = 51;
            this.textBox4.Text = "1";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(6, 88);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 24);
            this.textBox3.TabIndex = 50;
            this.textBox3.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(6, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 24);
            this.textBox2.TabIndex = 49;
            this.textBox2.Text = "1";
            // 
            // boxQVectorImm
            // 
            this.boxQVectorImm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.boxQVectorImm.Controls.Add(this.textBox34);
            this.boxQVectorImm.Controls.Add(this.textBox31);
            this.boxQVectorImm.Controls.Add(this.textBox12);
            this.boxQVectorImm.Controls.Add(this.textBox10);
            this.boxQVectorImm.Controls.Add(this.textBox19);
            this.boxQVectorImm.Controls.Add(this.textBox11);
            this.boxQVectorImm.Controls.Add(this.textBox18);
            this.boxQVectorImm.Controls.Add(this.textBox14);
            this.boxQVectorImm.Controls.Add(this.textBox17);
            this.boxQVectorImm.Controls.Add(this.textBox15);
            this.boxQVectorImm.Controls.Add(this.textBox16);
            this.boxQVectorImm.Location = new System.Drawing.Point(1356, 84);
            this.boxQVectorImm.Name = "boxQVectorImm";
            this.boxQVectorImm.Size = new System.Drawing.Size(128, 366);
            this.boxQVectorImm.TabIndex = 31;
            this.boxQVectorImm.TabStop = false;
            this.boxQVectorImm.Text = "Immobile";
            // 
            // textBox34
            // 
            this.textBox34.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox34.Location = new System.Drawing.Point(7, 321);
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(116, 24);
            this.textBox34.TabIndex = 76;
            this.textBox34.Text = "1";
            // 
            // textBox31
            // 
            this.textBox31.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox31.Location = new System.Drawing.Point(7, 296);
            this.textBox31.Multiline = true;
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(116, 24);
            this.textBox31.TabIndex = 75;
            this.textBox31.Text = "1";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(7, 28);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(116, 24);
            this.textBox12.TabIndex = 74;
            this.textBox12.Text = "1";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(7, 266);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(116, 24);
            this.textBox10.TabIndex = 64;
            this.textBox10.Text = "1";
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Location = new System.Drawing.Point(7, 58);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(116, 24);
            this.textBox19.TabIndex = 57;
            this.textBox19.Text = "1";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(7, 236);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(116, 24);
            this.textBox11.TabIndex = 63;
            this.textBox11.Text = "1";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Location = new System.Drawing.Point(7, 88);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(116, 24);
            this.textBox18.TabIndex = 58;
            this.textBox18.Text = "1";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(7, 206);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(116, 24);
            this.textBox14.TabIndex = 62;
            this.textBox14.Text = "1";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Location = new System.Drawing.Point(7, 118);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(116, 24);
            this.textBox17.TabIndex = 59;
            this.textBox17.Text = "1";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(7, 176);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(116, 24);
            this.textBox15.TabIndex = 61;
            this.textBox15.Text = "1";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(7, 148);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(116, 24);
            this.textBox16.TabIndex = 60;
            this.textBox16.Text = "1";
            // 
            // boxQVectorRight
            // 
            this.boxQVectorRight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.boxQVectorRight.Controls.Add(this.textBox35);
            this.boxQVectorRight.Controls.Add(this.textBox32);
            this.boxQVectorRight.Controls.Add(this.textBox28);
            this.boxQVectorRight.Controls.Add(this.textBox20);
            this.boxQVectorRight.Controls.Add(this.textBox27);
            this.boxQVectorRight.Controls.Add(this.textBox21);
            this.boxQVectorRight.Controls.Add(this.textBox26);
            this.boxQVectorRight.Controls.Add(this.textBox22);
            this.boxQVectorRight.Controls.Add(this.textBox25);
            this.boxQVectorRight.Controls.Add(this.textBox23);
            this.boxQVectorRight.Controls.Add(this.textBox24);
            this.boxQVectorRight.Location = new System.Drawing.Point(1516, 84);
            this.boxQVectorRight.Name = "boxQVectorRight";
            this.boxQVectorRight.Size = new System.Drawing.Size(128, 366);
            this.boxQVectorRight.TabIndex = 32;
            this.boxQVectorRight.TabStop = false;
            this.boxQVectorRight.Text = "Right";
            // 
            // textBox35
            // 
            this.textBox35.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox35.Location = new System.Drawing.Point(6, 321);
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(116, 24);
            this.textBox35.TabIndex = 75;
            this.textBox35.Text = "1";
            // 
            // textBox32
            // 
            this.textBox32.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox32.Location = new System.Drawing.Point(6, 296);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(116, 24);
            this.textBox32.TabIndex = 74;
            this.textBox32.Text = "1";
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox28.Location = new System.Drawing.Point(6, 28);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(116, 24);
            this.textBox28.TabIndex = 73;
            this.textBox28.Text = "1";
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Location = new System.Drawing.Point(6, 266);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(116, 24);
            this.textBox20.TabIndex = 72;
            this.textBox20.Text = "1";
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox27.Location = new System.Drawing.Point(6, 58);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(116, 24);
            this.textBox27.TabIndex = 65;
            this.textBox27.Text = "1";
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Location = new System.Drawing.Point(6, 236);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(116, 24);
            this.textBox21.TabIndex = 71;
            this.textBox21.Text = "1";
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox26.Location = new System.Drawing.Point(6, 88);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(116, 24);
            this.textBox26.TabIndex = 66;
            this.textBox26.Text = "1";
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Location = new System.Drawing.Point(6, 206);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(116, 24);
            this.textBox22.TabIndex = 70;
            this.textBox22.Text = "1";
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Location = new System.Drawing.Point(6, 118);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(116, 24);
            this.textBox25.TabIndex = 67;
            this.textBox25.Text = "1";
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Location = new System.Drawing.Point(6, 176);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(116, 24);
            this.textBox23.TabIndex = 69;
            this.textBox23.Text = "1";
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Location = new System.Drawing.Point(6, 148);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(116, 24);
            this.textBox24.TabIndex = 68;
            this.textBox24.Text = "1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1193, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 24);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "1";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(750, 40);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(298, 48);
            this.textBox13.TabIndex = 49;
            this.textBox13.Text = "Variables and results";
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.SystemColors.Control;
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox29.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.Location = new System.Drawing.Point(1363, 38);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(116, 38);
            this.textBox29.TabIndex = 50;
            this.textBox29.Text = "qVector";
            // 
            // buttonNextState
            // 
            this.buttonNextState.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonNextState.Location = new System.Drawing.Point(537, 657);
            this.buttonNextState.Name = "buttonNextState";
            this.buttonNextState.Size = new System.Drawing.Size(87, 72);
            this.buttonNextState.TabIndex = 51;
            this.buttonNextState.Text = "Next state";
            this.buttonNextState.UseVisualStyleBackColor = true;
            this.buttonNextState.Click += new System.EventHandler(this.buttonNextState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1678, 794);
            this.Controls.Add(this.buttonNextState);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.boxQVectorRight);
            this.Controls.Add(this.boxQVectorImm);
            this.Controls.Add(this.boxQVectorLeft);
            this.Controls.Add(this.textBoxPanel2);
            this.Controls.Add(this.textBoxPanel0);
            this.Controls.Add(this.textBoxPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExploitationButton);
            this.Controls.Add(this.ExplorationButton);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBoxGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGame)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLastGames)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.boxQVectorLeft.ResumeLayout(false);
            this.boxQVectorLeft.PerformLayout();
            this.boxQVectorImm.ResumeLayout(false);
            this.boxQVectorImm.PerformLayout();
            this.boxQVectorRight.ResumeLayout(false);
            this.boxQVectorRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.PictureBox pictureBoxGame;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button ExplorationButton;
        private System.Windows.Forms.Button ExploitationButton;
        private System.Windows.Forms.TextBox trainingNB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLastGames;
        private System.Windows.Forms.TextBox labelBounces;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox arrayCoord1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox cumulRewards;
        private System.Windows.Forms.TextBox arrayCoord2;
        private System.Windows.Forms.TextBox bouncePerGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxPanel1;
        private System.Windows.Forms.TextBox textBoxPanel0;
        private System.Windows.Forms.TextBox textBoxPanel2;
        private System.Windows.Forms.GroupBox boxQVectorLeft;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox boxQVectorImm;
        private System.Windows.Forms.GroupBox boxQVectorRight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.Button buttonNextState;
        private System.Windows.Forms.Button buttonBestParam;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox bricksPerGame;
        private System.Windows.Forms.Button buttonReinitGame;
    }
}

