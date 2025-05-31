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
            label_Class = new Label();
            panel_BG = new Panel();
            label_SurvivalChance = new Label();
            label_Rate = new Label();
            pictureBox_Character = new PictureBox();
            pictureBox_Loading = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrows).BeginInit();
            panel_BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Loading).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = Properties.Resources.Panel_StatAdjusment_new2_;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(label_Points);
            panel1.Controls.Add(pictureBox_Arrows);
            panel1.Controls.Add(label_textAbove);
            panel1.Controls.Add(pictureBox_Character);
            panel1.Controls.Add(label_Class);
            panel1.Controls.Add(panel_BG);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 297);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.Font = new Font("Upheaval TT (BRK)", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(975, 225);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
            btnNext.TabIndex = 27;
            btnNext.Text = "nexT";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // label_Points
            // 
            label_Points.BackColor = Color.Transparent;
            label_Points.Font = new Font("VP Pixel Simplified DEMO", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Points.ForeColor = Color.LimeGreen;
            label_Points.Location = new Point(906, 92);
            label_Points.Name = "label_Points";
            label_Points.Size = new Size(109, 31);
            label_Points.TabIndex = 15;
            label_Points.Text = "+ 5 Points";
            label_Points.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Arrows
            // 
            pictureBox_Arrows.BackColor = Color.Transparent;
            pictureBox_Arrows.Image = Properties.Resources.GIF_arrowAnimation;
            pictureBox_Arrows.Location = new Point(479, 91);
            pictureBox_Arrows.Name = "pictureBox_Arrows";
            pictureBox_Arrows.Size = new Size(140, 120);
            pictureBox_Arrows.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Arrows.TabIndex = 9;
            pictureBox_Arrows.TabStop = false;
            // 
            // label_textAbove
            // 
            label_textAbove.BackColor = Color.Transparent;
            label_textAbove.Font = new Font("VP Pixel Simplified DEMO", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_textAbove.ForeColor = Color.Gray;
            label_textAbove.Location = new Point(418, 40);
            label_textAbove.Name = "label_textAbove";
            label_textAbove.Size = new Size(273, 31);
            label_textAbove.TabIndex = 7;
            label_textAbove.Text = "Calculating Survival Chance";
            label_textAbove.TextAlign = ContentAlignment.MiddleCenter;
            label_textAbove.Click += label11_Click;
            // 
            // label_Class
            // 
            label_Class.BackColor = Color.Transparent;
            label_Class.Font = new Font("Ac437 Acer VGA 8x8", 10.2F);
            label_Class.ForeColor = Color.Gray;
            label_Class.Location = new Point(123, 242);
            label_Class.Name = "label_Class";
            label_Class.Size = new Size(345, 31);
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
            panel_BG.Location = new Point(697, 86);
            panel_BG.Name = "panel_BG";
            panel_BG.Size = new Size(211, 125);
            panel_BG.TabIndex = 14;
            // 
            // label_SurvivalChance
            // 
            label_SurvivalChance.BackColor = Color.Transparent;
            label_SurvivalChance.Font = new Font("VP Pixel Simplified DEMO", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SurvivalChance.ForeColor = Color.Gray;
            label_SurvivalChance.Location = new Point(-3, 73);
            label_SurvivalChance.Name = "label_SurvivalChance";
            label_SurvivalChance.Size = new Size(211, 31);
            label_SurvivalChance.TabIndex = 11;
            label_SurvivalChance.Text = "Survival Chace";
            label_SurvivalChance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Rate
            // 
            label_Rate.Anchor = AnchorStyles.None;
            label_Rate.BackColor = Color.Transparent;
            label_Rate.Font = new Font("Upheaval TT (BRK)", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Rate.ForeColor = Color.Honeydew;
            label_Rate.Location = new Point(17, 7);
            label_Rate.Name = "label_Rate";
            label_Rate.Size = new Size(186, 77);
            label_Rate.TabIndex = 13;
            label_Rate.Text = "60%";
            label_Rate.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox_Character
            // 
            pictureBox_Character.Image = Properties.Resources.GIF_CalculatingClass;
            pictureBox_Character.Location = new Point(184, 40);
            pictureBox_Character.Name = "pictureBox_Character";
            pictureBox_Character.Size = new Size(206, 196);
            pictureBox_Character.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Character.TabIndex = 0;
            pictureBox_Character.TabStop = false;
            // 
            // pictureBox_Loading
            // 
            pictureBox_Loading.Image = Properties.Resources.GIF_Loading;
            pictureBox_Loading.Location = new Point(33, 37);
            pictureBox_Loading.Name = "pictureBox_Loading";
            pictureBox_Loading.Size = new Size(141, 47);
            pictureBox_Loading.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Loading.TabIndex = 14;
            pictureBox_Loading.TabStop = false;
            // 
            // CharacterSurvivalChance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CharacterSurvivalChance";
            Size = new Size(1103, 297);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Arrows).EndInit();
            panel_BG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Character).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Loading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_textAbove;
        private Label label_Class;
        private PictureBox pictureBox_Arrows;
        private Label label_SurvivalChance;
        private Label label_Rate;
        private Panel panel_BG;
        private Label label_Points;
        private Button btnNext;
        private PictureBox pictureBox_Character;
        private PictureBox pictureBox_Loading;
    }
}
