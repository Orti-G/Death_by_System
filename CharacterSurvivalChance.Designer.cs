namespace Death_by_System
{
    partial class CharacterSurvivalChance
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
            btnNext = new Button();
            label_Points = new Label();
            pictureBox_Arrows = new PictureBox();
            label_textAbove = new Label();
            pictureBox_Character = new PictureBox();
            label_Class = new Label();
            panel_BG = new Panel();
            pictureBox_Loading = new PictureBox();
            label_SurvivalChance = new Label();
            label_Rate = new Label();
            pictureBox_PercentileView = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Character).BeginInit();
            panel_BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Loading).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_PercentileView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = Properties.Resources.Panel_StatAdjusment_new2_;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox_PercentileView);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(label_Points);
            panel1.Controls.Add(pictureBox_Arrows);
            panel1.Controls.Add(label_textAbove);
            panel1.Controls.Add(pictureBox_Character);
            panel1.Controls.Add(label_Class);
            panel1.Controls.Add(panel_BG);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 223);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(853, 169);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 27;
            btnNext.Text = "nexT";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // label_Points
            // 
            label_Points.BackColor = Color.Transparent;
            label_Points.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Points.ForeColor = Color.LimeGreen;
            label_Points.Location = new Point(801, 70);
            label_Points.Name = "label_Points";
            label_Points.Size = new Size(109, 73);
            label_Points.TabIndex = 15;
            label_Points.Text = "Currently at Top 00% among all stats combination";
            label_Points.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Arrows
            // 
            pictureBox_Arrows.BackColor = Color.Transparent;
            pictureBox_Arrows.Image = Properties.Resources.GIF_arrowAnimation;
            pictureBox_Arrows.Location = new Point(419, 68);
            pictureBox_Arrows.Margin = new Padding(3, 2, 3, 2);
            pictureBox_Arrows.Name = "pictureBox_Arrows";
            pictureBox_Arrows.Size = new Size(122, 90);
            pictureBox_Arrows.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Arrows.TabIndex = 9;
            pictureBox_Arrows.TabStop = false;
            // 
            // label_textAbove
            // 
            label_textAbove.BackColor = Color.Transparent;
            label_textAbove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_textAbove.ForeColor = Color.Gray;
            label_textAbove.Location = new Point(366, 30);
            label_textAbove.Name = "label_textAbove";
            label_textAbove.Size = new Size(239, 23);
            label_textAbove.TabIndex = 7;
            label_textAbove.Text = "Calculating Survival Chance";
            label_textAbove.TextAlign = ContentAlignment.MiddleCenter;
            label_textAbove.Click += label11_Click;
            // 
            // pictureBox_Character
            // 
            pictureBox_Character.Image = Properties.Resources.GIF_CalculatingClass;
            pictureBox_Character.Location = new Point(161, 30);
            pictureBox_Character.Margin = new Padding(3, 2, 3, 2);
            pictureBox_Character.Name = "pictureBox_Character";
            pictureBox_Character.Size = new Size(180, 147);
            pictureBox_Character.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Character.TabIndex = 0;
            pictureBox_Character.TabStop = false;
            // 
            // label_Class
            // 
            label_Class.BackColor = Color.Transparent;
            label_Class.Font = new Font("Microsoft Sans Serif", 10.2F);
            label_Class.ForeColor = Color.Gray;
            label_Class.Location = new Point(108, 182);
            label_Class.Name = "label_Class";
            label_Class.Size = new Size(302, 23);
            label_Class.TabIndex = 8;
            label_Class.Text = "ASSIGNING CLASS....";
            label_Class.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_BG
            // 
            panel_BG.BackgroundImageLayout = ImageLayout.Stretch;
            panel_BG.Controls.Add(pictureBox_Loading);
            panel_BG.Controls.Add(label_SurvivalChance);
            panel_BG.Controls.Add(label_Rate);
            panel_BG.Location = new Point(610, 64);
            panel_BG.Margin = new Padding(3, 2, 3, 2);
            panel_BG.Name = "panel_BG";
            panel_BG.Size = new Size(185, 94);
            panel_BG.TabIndex = 14;
            // 
            // pictureBox_Loading
            // 
            pictureBox_Loading.Image = Properties.Resources.GIF_Loading;
            pictureBox_Loading.Location = new Point(29, 28);
            pictureBox_Loading.Margin = new Padding(3, 2, 3, 2);
            pictureBox_Loading.Name = "pictureBox_Loading";
            pictureBox_Loading.Size = new Size(123, 35);
            pictureBox_Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Loading.TabIndex = 14;
            pictureBox_Loading.TabStop = false;
            // 
            // label_SurvivalChance
            // 
            label_SurvivalChance.BackColor = Color.Transparent;
            label_SurvivalChance.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SurvivalChance.ForeColor = Color.Gray;
            label_SurvivalChance.Location = new Point(-3, 55);
            label_SurvivalChance.Name = "label_SurvivalChance";
            label_SurvivalChance.Size = new Size(185, 23);
            label_SurvivalChance.TabIndex = 11;
            label_SurvivalChance.Text = "Survival Chance";
            label_SurvivalChance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Rate
            // 
            label_Rate.Anchor = AnchorStyles.None;
            label_Rate.BackColor = Color.Transparent;
            label_Rate.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Rate.ForeColor = Color.Honeydew;
            label_Rate.Location = new Point(15, 5);
            label_Rate.Name = "label_Rate";
            label_Rate.Size = new Size(163, 58);
            label_Rate.TabIndex = 13;
            label_Rate.Text = "60.45%";
            label_Rate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_PercentileView
            // 
            pictureBox_PercentileView.BackColor = Color.Red;
            pictureBox_PercentileView.Location = new Point(916, 99);
            pictureBox_PercentileView.Name = "pictureBox_PercentileView";
            pictureBox_PercentileView.Size = new Size(22, 18);
            pictureBox_PercentileView.TabIndex = 28;
            pictureBox_PercentileView.TabStop = false;
            pictureBox_PercentileView.Click += pictureBox_PercentileView_Click;
            // 
            // CharacterSurvivalChance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CharacterSurvivalChance";
            Size = new Size(965, 223);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Character).EndInit();
            panel_BG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Loading).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_PercentileView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox_Character;
        private Label label_textAbove;
        private Label label_Class;
        private PictureBox pictureBox_Arrows;
        private Label label_SurvivalChance;
        private Label label_Rate;
        private Panel panel_BG;
        private Label label_Points;
        private Button btnNext;
        private PictureBox pictureBox_Loading;
        private PictureBox pictureBox_PercentileView;
    }
}
