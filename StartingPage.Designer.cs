namespace Death_by_System
{
    partial class StartingPage
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
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label_Startbtn = new Label();
            label_Aboutus = new PictureBox();
            label_Leaderboard = new PictureBox();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label_Aboutus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)label_Leaderboard).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Main_Logo;
            pictureBox1.Location = new Point(69, 87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1085, 316);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.pictureButton;
            pictureBox3.Location = new Point(780, 439);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(160, 139);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.pictureButton;
            pictureBox4.Location = new Point(274, 439);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(166, 139);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label_Startbtn
            // 
            label_Startbtn.AutoSize = true;
            label_Startbtn.BackColor = Color.White;
            label_Startbtn.Font = new Font("Press Start 2P", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Startbtn.ForeColor = SystemColors.MenuHighlight;
            label_Startbtn.Location = new Point(49, 55);
            label_Startbtn.Name = "label_Startbtn";
            label_Startbtn.Size = new Size(207, 37);
            label_Startbtn.TabIndex = 6;
            label_Startbtn.Text = "START";
            label_Startbtn.Click += label_Startbtn_Click;
            // 
            // label_Aboutus
            // 
            label_Aboutus.BackColor = Color.White;
            label_Aboutus.Image = Properties.Resources.Icon_AbotUs;
            label_Aboutus.Location = new Point(312, 476);
            label_Aboutus.Name = "label_Aboutus";
            label_Aboutus.Size = new Size(90, 65);
            label_Aboutus.SizeMode = PictureBoxSizeMode.StretchImage;
            label_Aboutus.TabIndex = 7;
            label_Aboutus.TabStop = false;
            label_Aboutus.Click += pictureBox5_Click;
            // 
            // label_Leaderboard
            // 
            label_Leaderboard.BackColor = Color.White;
            label_Leaderboard.Image = Properties.Resources.Icon_LeaderBoard;
            label_Leaderboard.Location = new Point(815, 476);
            label_Leaderboard.Name = "label_Leaderboard";
            label_Leaderboard.Size = new Size(90, 65);
            label_Leaderboard.SizeMode = PictureBoxSizeMode.StretchImage;
            label_Leaderboard.TabIndex = 8;
            label_Leaderboard.TabStop = false;
            label_Leaderboard.Click += label_Leaderboard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.BackgroundImage = Properties.Resources.GIF_MainBackGround;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label_Aboutus);
            panel1.Controls.Add(label_Leaderboard);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 676);
            panel1.TabIndex = 10;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Image = Properties.Resources.GIF_Satellite;
            pictureBox7.Location = new Point(59, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(175, 178);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.pictureButton;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label_Startbtn);
            panel2.Location = new Point(462, 435);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 143);
            panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.GIF_robotWave;
            pictureBox2.Location = new Point(907, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(283, 251);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // StartingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StartingPage";
            Size = new Size(1200, 676);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)label_Aboutus).EndInit();
            ((System.ComponentModel.ISupportInitialize)label_Leaderboard).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label_Startbtn;
        private PictureBox label_Aboutus;
        private PictureBox label_Leaderboard;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
    }
}
