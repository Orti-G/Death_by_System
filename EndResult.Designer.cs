namespace Death_by_System
{
    partial class EndResult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox_Home = new PictureBox();
            panel6 = new Panel();
            label11 = new Label();
            labelPlayerName = new Label();
            label8 = new Label();
            labelASC = new Label();
            btn_Leaderboard = new PictureBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label3 = new Label();
            labelLvl3SC = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel4 = new Panel();
            label32 = new Label();
            labelLvl2SC = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            panel3 = new Panel();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label2 = new Label();
            labelLvl1SC = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Home).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Leaderboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.GIF_MainBackGround;
            panel1.Controls.Add(pictureBox_Home);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btn_Leaderboard);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 676);
            panel1.TabIndex = 0;
            // 
            // pictureBox_Home
            // 
            pictureBox_Home.BackColor = Color.White;
            pictureBox_Home.Image = Properties.Resources.Icon_Home;
            pictureBox_Home.Location = new Point(64, 573);
            pictureBox_Home.Name = "pictureBox_Home";
            pictureBox_Home.Size = new Size(65, 41);
            pictureBox_Home.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Home.TabIndex = 19;
            pictureBox_Home.TabStop = false;
            pictureBox_Home.Click += pictureBox_Home_Click;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Controls.Add(label11);
            panel6.Controls.Add(labelPlayerName);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(labelASC);
            panel6.Location = new Point(213, 537);
            panel6.Name = "panel6";
            panel6.Size = new Size(787, 115);
            panel6.TabIndex = 12;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Pixellari", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Transparent;
            label11.Location = new Point(138, 16);
            label11.Name = "label11";
            label11.Size = new Size(213, 37);
            label11.TabIndex = 24;
            label11.Text = "PLAYER'S NAME";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPlayerName
            // 
            labelPlayerName.Anchor = AnchorStyles.None;
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.Font = new Font("Minecraftia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerName.ForeColor = Color.Honeydew;
            labelPlayerName.Location = new Point(16, 44);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(392, 51);
            labelPlayerName.TabIndex = 9;
            labelPlayerName.Text = "JAYJO BINAY";
            labelPlayerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Pixellari", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(463, 73);
            label8.Name = "label8";
            label8.Size = new Size(295, 27);
            label8.TabIndex = 21;
            label8.Text = "Average Survival Chace";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
            // 
            // labelASC
            // 
            labelASC.Anchor = AnchorStyles.None;
            labelASC.BackColor = Color.Transparent;
            labelASC.Font = new Font("Upheaval TT (BRK)", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelASC.ForeColor = Color.Honeydew;
            labelASC.Location = new Point(510, 5);
            labelASC.Margin = new Padding(0);
            labelASC.Name = "labelASC";
            labelASC.Size = new Size(223, 83);
            labelASC.TabIndex = 22;
            labelASC.Text = "60.5%";
            labelASC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Leaderboard
            // 
            btn_Leaderboard.BackColor = Color.White;
            btn_Leaderboard.Image = Properties.Resources.Icon_LeaderBoard;
            btn_Leaderboard.Location = new Point(1093, 573);
            btn_Leaderboard.Name = "btn_Leaderboard";
            btn_Leaderboard.Size = new Size(54, 41);
            btn_Leaderboard.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_Leaderboard.TabIndex = 16;
            btn_Leaderboard.TabStop = false;
            btn_Leaderboard.Click += btn_Leaderboard_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pictureButton;
            pictureBox1.Location = new Point(34, 537);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.ScenarioPanel_lvl3;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(labelLvl3SC);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(105, 381);
            panel5.Name = "panel5";
            panel5.Size = new Size(982, 137);
            panel5.TabIndex = 14;
            panel5.Paint += panel5_Paint;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Pixellari", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(685, 71);
            label3.Name = "label3";
            label3.Size = new Size(213, 27);
            label3.TabIndex = 29;
            label3.Text = "Survival Chance";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLvl3SC
            // 
            labelLvl3SC.Anchor = AnchorStyles.None;
            labelLvl3SC.BackColor = Color.Transparent;
            labelLvl3SC.Font = new Font("Upheaval TT (BRK)", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLvl3SC.ForeColor = Color.Honeydew;
            labelLvl3SC.Location = new Point(702, -2);
            labelLvl3SC.Margin = new Padding(0);
            labelLvl3SC.Name = "labelLvl3SC";
            labelLvl3SC.Size = new Size(193, 104);
            labelLvl3SC.TabIndex = 30;
            labelLvl3SC.Text = "60.5%";
            labelLvl3SC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(66, 83);
            label14.Name = "label14";
            label14.Size = new Size(311, 15);
            label14.TabIndex = 27;
            label14.Text = "Volcanic Wasteland";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Pixellari", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.MistyRose;
            label13.Location = new Point(41, 24);
            label13.Name = "label13";
            label13.Size = new Size(127, 21);
            label13.TabIndex = 26;
            label13.Text = "LEVEL 3";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Upheaval TT (BRK)", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(87, 48);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(570, 35);
            label12.TabIndex = 25;
            label12.Text = " Pyraxis – “Throne of Flame”";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.ScenarioPanel_lvl2;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label32);
            panel4.Controls.Add(labelLvl2SC);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Location = new Point(105, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 137);
            panel4.TabIndex = 14;
            // 
            // label32
            // 
            label32.BackColor = Color.Transparent;
            label32.Font = new Font("Pixellari", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.Transparent;
            label32.Location = new Point(685, 72);
            label32.Name = "label32";
            label32.Size = new Size(213, 27);
            label32.TabIndex = 21;
            label32.Text = "Survival Chance";
            label32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLvl2SC
            // 
            labelLvl2SC.Anchor = AnchorStyles.None;
            labelLvl2SC.BackColor = Color.Transparent;
            labelLvl2SC.Font = new Font("Upheaval TT (BRK)", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLvl2SC.ForeColor = Color.Honeydew;
            labelLvl2SC.Location = new Point(705, -5);
            labelLvl2SC.Margin = new Padding(0);
            labelLvl2SC.Name = "labelLvl2SC";
            labelLvl2SC.Size = new Size(193, 104);
            labelLvl2SC.TabIndex = 28;
            labelLvl2SC.Text = "60.5%";
            labelLvl2SC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(41, 73);
            label15.Name = "label15";
            label15.Size = new Size(311, 15);
            label15.TabIndex = 30;
            label15.Text = "Cursed Ashland";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Pixellari", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Azure;
            label16.Location = new Point(41, 13);
            label16.Name = "label16";
            label16.Size = new Size(127, 21);
            label16.TabIndex = 29;
            label16.Text = "LEVEL 2";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Upheaval TT (BRK)", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.White;
            label17.Location = new Point(41, 37);
            label17.Name = "label17";
            label17.RightToLeft = RightToLeft.No;
            label17.Size = new Size(670, 35);
            label17.TabIndex = 28;
            label17.Text = "AshLow – “Grave of D Forgotten”";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.ScenarioPanel_lvl1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(labelLvl1SC);
            panel3.Location = new Point(105, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 137);
            panel3.TabIndex = 13;
            // 
            // label18
            // 
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Transparent;
            label18.Location = new Point(66, 72);
            label18.Name = "label18";
            label18.Size = new Size(311, 15);
            label18.TabIndex = 30;
            label18.Text = "Whisperwood Forest";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.None;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Pixellari", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Honeydew;
            label19.Location = new Point(41, 17);
            label19.Name = "label19";
            label19.Size = new Size(127, 21);
            label19.TabIndex = 29;
            label19.Text = "LEVEL 1";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.None;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Upheaval TT (BRK)", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(57, 34);
            label20.Name = "label20";
            label20.RightToLeft = RightToLeft.No;
            label20.Size = new Size(636, 35);
            label20.TabIndex = 28;
            label20.Text = " Verdantia – “Whispering Grove";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Pixellari", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(685, 76);
            label2.Name = "label2";
            label2.Size = new Size(213, 25);
            label2.TabIndex = 19;
            label2.Text = "Survival Chance";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLvl1SC
            // 
            labelLvl1SC.Anchor = AnchorStyles.None;
            labelLvl1SC.BackColor = Color.Transparent;
            labelLvl1SC.Font = new Font("Upheaval TT (BRK)", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLvl1SC.ForeColor = Color.Honeydew;
            labelLvl1SC.Location = new Point(702, 0);
            labelLvl1SC.Margin = new Padding(0);
            labelLvl1SC.Name = "labelLvl1SC";
            labelLvl1SC.Size = new Size(193, 104);
            labelLvl1SC.TabIndex = 20;
            labelLvl1SC.Text = "60.5%";
            labelLvl1SC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(437, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 45);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Upheaval TT (BRK)", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(-49, 5);
            label1.Name = "label1";
            label1.Size = new Size(438, 35);
            label1.TabIndex = 8;
            label1.Text = "FINAL RESULT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.pictureButton;
            pictureBox2.Location = new Point(1056, 537);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // EndResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "EndResult";
            Size = new Size(1200, 676);
            Load += EndResult_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Home).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Leaderboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox btn_Leaderboard;
        private PictureBox pictureBox1;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Label label8;
        private Label labelASC;
        private Label label32;
        private Label label2;
        private Label labelLvl1SC;
        private Label labelPlayerName;
        private Label label11;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private PictureBox pictureBox_Home;
        private Label labelLvl2SC;
        private Label label3;
        private Label labelLvl3SC;
    }
}
