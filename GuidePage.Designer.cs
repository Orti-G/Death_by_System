namespace Death_by_System
{
    partial class GuidePage
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
            textBoxName = new TextBox();
            panel1 = new Panel();
            label_Startbtn = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox_Guide = new PictureBox();
            btnLeft = new PictureBox();
            btnRight = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Guide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Upheaval TT (BRK)", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(34, 14);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(648, 32);
            textBoxName.TabIndex = 1;
            textBoxName.Text = "PLAYER NAME";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            textBoxName.MouseClick += textBoxName_MouseClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.GIF_MainBackGround;
            panel1.Controls.Add(label_Startbtn);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox_Guide);
            panel1.Controls.Add(btnLeft);
            panel1.Controls.Add(btnRight);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 676);
            panel1.TabIndex = 3;
            // 
            // label_Startbtn
            // 
            label_Startbtn.AutoSize = true;
            label_Startbtn.BackColor = Color.White;
            label_Startbtn.Font = new Font("Press Start 2P", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Startbtn.ForeColor = SystemColors.MenuHighlight;
            label_Startbtn.Location = new Point(1019, 598);
            label_Startbtn.Name = "label_Startbtn";
            label_Startbtn.Size = new Size(135, 20);
            label_Startbtn.TabIndex = 7;
            label_Startbtn.Text = "SUBMIT";
            label_Startbtn.Click += label_Startbtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.pictureButton;
            pictureBox3.Location = new Point(981, 553);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(203, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(473, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 46);
            panel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Upheaval TT (BRK)", 22.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Honeydew;
            label1.Location = new Point(-77, 6);
            label1.Name = "label1";
            label1.Size = new Size(438, 35);
            label1.TabIndex = 8;
            label1.Text = "GUIDE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(textBoxName);
            panel3.Location = new Point(255, 524);
            panel3.Name = "panel3";
            panel3.Size = new Size(720, 67);
            panel3.TabIndex = 11;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Squada One", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DimGray;
            label11.Location = new Point(363, 493);
            label11.Name = "label11";
            label11.Size = new Size(487, 41);
            label11.TabIndex = 25;
            label11.Text = "IF YOU ARE READY, SUBMIT YOUR PLAYER NAME\r\n";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.GIF_RobotGuide;
            pictureBox2.Location = new Point(35, 469);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 192);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox_Guide
            // 
            pictureBox_Guide.BackgroundImage = Properties.Resources.GIF_MainBackGround1;
            pictureBox_Guide.Image = Properties.Resources.Guide1;
            pictureBox_Guide.Location = new Point(161, 75);
            pictureBox_Guide.Name = "pictureBox_Guide";
            pictureBox_Guide.Size = new Size(905, 456);
            pictureBox_Guide.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Guide.TabIndex = 9;
            pictureBox_Guide.TabStop = false;
            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.Transparent;
            btnLeft.BackgroundImage = Properties.Resources.LeftArrow;
            btnLeft.BackgroundImageLayout = ImageLayout.Stretch;
            btnLeft.Location = new Point(83, 253);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(100, 88);
            btnLeft.TabIndex = 13;
            btnLeft.TabStop = false;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.BackColor = Color.Transparent;
            btnRight.BackgroundImage = Properties.Resources.RightButton_new_;
            btnRight.BackgroundImageLayout = ImageLayout.Stretch;
            btnRight.Location = new Point(1038, 253);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(100, 88);
            btnRight.TabIndex = 14;
            btnRight.TabStop = false;
            btnRight.Click += btnRight_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.GIF_MainBackGround1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 676);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // GuidePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GuidePage";
            Size = new Size(1200, 676);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Guide).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBoxName;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label_Startbtn;
        private Label label1;
        private PictureBox pictureBox_Guide;
        private Panel panel2;
        private PictureBox btnLeft;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox btnRight;
        private Label label11;
        private PictureBox pictureBox1;
    }
}
