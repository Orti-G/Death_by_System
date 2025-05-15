namespace Death_by_System
{
    partial class GamePlay
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
            label1 = new Label();
            panel1 = new Panel();
            lblPoints = new Label();
            label7 = new Label();
            txtBoxIntuition = new TextBox();
            txtBoxEnergy = new TextBox();
            txtBoxResilience = new TextBox();
            txtBoxFocus = new TextBox();
            txtBoxAgility = new TextBox();
            btnCommit = new Button();
            txtBoxPower = new TextBox();
            label6 = new Label();
            btnMinusIntuition = new Button();
            btnAddIntuition = new Button();
            label8 = new Label();
            btnMinusEnergy = new Button();
            btnAddEnergy = new Button();
            label4 = new Label();
            btnMinusResilience = new Button();
            btnAddResilience = new Button();
            label5 = new Label();
            btnMinusFocus = new Button();
            btnAddFocus = new Button();
            label3 = new Label();
            btnMinusAgility = new Button();
            btnAddAgility = new Button();
            label2 = new Label();
            btnMinusPower = new Button();
            btnAddPower = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 50);
            label1.TabIndex = 0;
            label1.Text = "Scenario";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPoints);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtBoxIntuition);
            panel1.Controls.Add(txtBoxEnergy);
            panel1.Controls.Add(txtBoxResilience);
            panel1.Controls.Add(txtBoxFocus);
            panel1.Controls.Add(txtBoxAgility);
            panel1.Controls.Add(btnCommit);
            panel1.Controls.Add(txtBoxPower);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnMinusIntuition);
            panel1.Controls.Add(btnAddIntuition);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnMinusEnergy);
            panel1.Controls.Add(btnAddEnergy);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnMinusResilience);
            panel1.Controls.Add(btnAddResilience);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnMinusFocus);
            panel1.Controls.Add(btnAddFocus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnMinusAgility);
            panel1.Controls.Add(btnAddAgility);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnMinusPower);
            panel1.Controls.Add(btnAddPower);
            panel1.Location = new Point(136, 260);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 234);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(508, 16);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(25, 15);
            lblPoints.TabIndex = 33;
            lblPoints.Text = "100";
            lblPoints.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 16);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 32;
            label7.Text = "Points:";
            // 
            // txtBoxIntuition
            // 
            txtBoxIntuition.Location = new Point(389, 137);
            txtBoxIntuition.MaxLength = 2;
            txtBoxIntuition.Name = "txtBoxIntuition";
            txtBoxIntuition.Size = new Size(22, 23);
            txtBoxIntuition.TabIndex = 31;
            txtBoxIntuition.Text = "0";
            txtBoxIntuition.TextAlign = HorizontalAlignment.Center;
            txtBoxIntuition.Leave += txtBoxIntuition_Leave;
            // 
            // txtBoxEnergy
            // 
            txtBoxEnergy.Location = new Point(388, 97);
            txtBoxEnergy.MaxLength = 2;
            txtBoxEnergy.Name = "txtBoxEnergy";
            txtBoxEnergy.Size = new Size(22, 23);
            txtBoxEnergy.TabIndex = 30;
            txtBoxEnergy.Text = "0";
            txtBoxEnergy.TextAlign = HorizontalAlignment.Center;
            txtBoxEnergy.Leave += txtBoxEnergy_Leave;
            // 
            // txtBoxResilience
            // 
            txtBoxResilience.Location = new Point(388, 58);
            txtBoxResilience.MaxLength = 2;
            txtBoxResilience.Name = "txtBoxResilience";
            txtBoxResilience.Size = new Size(22, 23);
            txtBoxResilience.TabIndex = 29;
            txtBoxResilience.Text = "0";
            txtBoxResilience.TextAlign = HorizontalAlignment.Center;
            txtBoxResilience.Leave += txtBoxResilience_Leave;
            // 
            // txtBoxFocus
            // 
            txtBoxFocus.Location = new Point(129, 93);
            txtBoxFocus.MaxLength = 2;
            txtBoxFocus.Name = "txtBoxFocus";
            txtBoxFocus.Size = new Size(22, 23);
            txtBoxFocus.TabIndex = 28;
            txtBoxFocus.Text = "0";
            txtBoxFocus.TextAlign = HorizontalAlignment.Center;
            txtBoxFocus.Leave += txtBoxFocus_Leave;
            // 
            // txtBoxAgility
            // 
            txtBoxAgility.Location = new Point(130, 132);
            txtBoxAgility.MaxLength = 2;
            txtBoxAgility.Name = "txtBoxAgility";
            txtBoxAgility.Size = new Size(22, 23);
            txtBoxAgility.TabIndex = 27;
            txtBoxAgility.Text = "0";
            txtBoxAgility.TextAlign = HorizontalAlignment.Center;
            txtBoxAgility.Leave += txtBoxAgility_Leave;
            // 
            // btnCommit
            // 
            btnCommit.Location = new Point(464, 198);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(75, 23);
            btnCommit.TabIndex = 26;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // txtBoxPower
            // 
            txtBoxPower.Location = new Point(129, 54);
            txtBoxPower.MaxLength = 2;
            txtBoxPower.Name = "txtBoxPower";
            txtBoxPower.Size = new Size(22, 23);
            txtBoxPower.TabIndex = 25;
            txtBoxPower.Text = "0";
            txtBoxPower.TextAlign = HorizontalAlignment.Center;
            txtBoxPower.Leave += txtBoxPower_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 101);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 24;
            label6.Text = "Energy";
            // 
            // btnMinusIntuition
            // 
            btnMinusIntuition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinusIntuition.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinusIntuition.Location = new Point(362, 138);
            btnMinusIntuition.Margin = new Padding(0);
            btnMinusIntuition.Name = "btnMinusIntuition";
            btnMinusIntuition.RightToLeft = RightToLeft.No;
            btnMinusIntuition.Size = new Size(23, 22);
            btnMinusIntuition.TabIndex = 23;
            btnMinusIntuition.Text = "-";
            btnMinusIntuition.UseVisualStyleBackColor = true;
            btnMinusIntuition.Click += btnMinusIntuition_Click;
            // 
            // btnAddIntuition
            // 
            btnAddIntuition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddIntuition.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddIntuition.Location = new Point(415, 138);
            btnAddIntuition.Margin = new Padding(0);
            btnAddIntuition.Name = "btnAddIntuition";
            btnAddIntuition.RightToLeft = RightToLeft.No;
            btnAddIntuition.Size = new Size(23, 22);
            btnAddIntuition.TabIndex = 22;
            btnAddIntuition.Text = "+";
            btnAddIntuition.TextAlign = ContentAlignment.MiddleLeft;
            btnAddIntuition.UseVisualStyleBackColor = true;
            btnAddIntuition.Click += btnAddIntuition_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(299, 141);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 18;
            label8.Text = "Intuition";
            // 
            // btnMinusEnergy
            // 
            btnMinusEnergy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinusEnergy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinusEnergy.Location = new Point(362, 98);
            btnMinusEnergy.Margin = new Padding(0);
            btnMinusEnergy.Name = "btnMinusEnergy";
            btnMinusEnergy.RightToLeft = RightToLeft.No;
            btnMinusEnergy.Size = new Size(23, 22);
            btnMinusEnergy.TabIndex = 17;
            btnMinusEnergy.Text = "-";
            btnMinusEnergy.UseVisualStyleBackColor = true;
            btnMinusEnergy.Click += btnMinusEnergy_Click;
            // 
            // btnAddEnergy
            // 
            btnAddEnergy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddEnergy.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEnergy.Location = new Point(415, 98);
            btnAddEnergy.Margin = new Padding(0);
            btnAddEnergy.Name = "btnAddEnergy";
            btnAddEnergy.RightToLeft = RightToLeft.No;
            btnAddEnergy.Size = new Size(23, 22);
            btnAddEnergy.TabIndex = 16;
            btnAddEnergy.Text = "+";
            btnAddEnergy.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEnergy.UseVisualStyleBackColor = true;
            btnAddEnergy.Click += btnAddEnergy_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 62);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 12;
            label4.Text = "Resilience";
            // 
            // btnMinusResilience
            // 
            btnMinusResilience.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinusResilience.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinusResilience.Location = new Point(362, 59);
            btnMinusResilience.Margin = new Padding(0);
            btnMinusResilience.Name = "btnMinusResilience";
            btnMinusResilience.RightToLeft = RightToLeft.No;
            btnMinusResilience.Size = new Size(23, 22);
            btnMinusResilience.TabIndex = 11;
            btnMinusResilience.Text = "-";
            btnMinusResilience.UseVisualStyleBackColor = true;
            btnMinusResilience.Click += btnMinusResilience_Click;
            // 
            // btnAddResilience
            // 
            btnAddResilience.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddResilience.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddResilience.Location = new Point(414, 59);
            btnAddResilience.Margin = new Padding(0);
            btnAddResilience.Name = "btnAddResilience";
            btnAddResilience.RightToLeft = RightToLeft.No;
            btnAddResilience.Size = new Size(23, 22);
            btnAddResilience.TabIndex = 10;
            btnAddResilience.Text = "+";
            btnAddResilience.TextAlign = ContentAlignment.MiddleLeft;
            btnAddResilience.UseVisualStyleBackColor = true;
            btnAddResilience.Click += btnAddResilience_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 98);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Focus";
            // 
            // btnMinusFocus
            // 
            btnMinusFocus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinusFocus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinusFocus.Location = new Point(104, 94);
            btnMinusFocus.Margin = new Padding(0);
            btnMinusFocus.Name = "btnMinusFocus";
            btnMinusFocus.RightToLeft = RightToLeft.No;
            btnMinusFocus.Size = new Size(23, 22);
            btnMinusFocus.TabIndex = 8;
            btnMinusFocus.Text = "-";
            btnMinusFocus.UseVisualStyleBackColor = true;
            btnMinusFocus.Click += btnMinusFocus_Click;
            // 
            // btnAddFocus
            // 
            btnAddFocus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddFocus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddFocus.Location = new Point(155, 94);
            btnAddFocus.Margin = new Padding(0);
            btnAddFocus.Name = "btnAddFocus";
            btnAddFocus.RightToLeft = RightToLeft.No;
            btnAddFocus.Size = new Size(23, 22);
            btnAddFocus.TabIndex = 7;
            btnAddFocus.Text = "+";
            btnAddFocus.TextAlign = ContentAlignment.MiddleLeft;
            btnAddFocus.UseVisualStyleBackColor = true;
            btnAddFocus.Click += btnAddFocus_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 137);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "Agility";
            // 
            // btnMinusAgility
            // 
            btnMinusAgility.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinusAgility.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinusAgility.Location = new Point(104, 133);
            btnMinusAgility.Margin = new Padding(0);
            btnMinusAgility.Name = "btnMinusAgility";
            btnMinusAgility.RightToLeft = RightToLeft.No;
            btnMinusAgility.Size = new Size(23, 22);
            btnMinusAgility.TabIndex = 5;
            btnMinusAgility.Text = "-";
            btnMinusAgility.UseVisualStyleBackColor = true;
            btnMinusAgility.Click += btnMinusAgility_Click;
            // 
            // btnAddAgility
            // 
            btnAddAgility.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddAgility.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddAgility.Location = new Point(156, 133);
            btnAddAgility.Margin = new Padding(0);
            btnAddAgility.Name = "btnAddAgility";
            btnAddAgility.RightToLeft = RightToLeft.No;
            btnAddAgility.Size = new Size(23, 22);
            btnAddAgility.TabIndex = 4;
            btnAddAgility.Text = "+";
            btnAddAgility.TextAlign = ContentAlignment.MiddleLeft;
            btnAddAgility.UseVisualStyleBackColor = true;
            btnAddAgility.Click += btnAddAgility_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Power";
            // 
            // btnMinusPower
            // 
            btnMinusPower.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMinusPower.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinusPower.Location = new Point(104, 55);
            btnMinusPower.Margin = new Padding(0);
            btnMinusPower.Name = "btnMinusPower";
            btnMinusPower.RightToLeft = RightToLeft.No;
            btnMinusPower.Size = new Size(23, 22);
            btnMinusPower.TabIndex = 2;
            btnMinusPower.Text = "-";
            btnMinusPower.UseVisualStyleBackColor = true;
            btnMinusPower.Click += btnMinusPower_Click;
            // 
            // btnAddPower
            // 
            btnAddPower.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddPower.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddPower.Location = new Point(154, 55);
            btnAddPower.Margin = new Padding(0);
            btnAddPower.Name = "btnAddPower";
            btnAddPower.RightToLeft = RightToLeft.No;
            btnAddPower.Size = new Size(23, 22);
            btnAddPower.TabIndex = 1;
            btnAddPower.Text = "+";
            btnAddPower.TextAlign = ContentAlignment.MiddleLeft;
            btnAddPower.UseVisualStyleBackColor = true;
            btnAddPower.Click += btnAddPower_Click;
            // 
            // GamePlay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "GamePlay";
            Size = new Size(816, 494);
            Load += GamePlay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnMinusPower;
        private Button btnAddPower;
        private Label label3;
        private Button btnMinusAgility;
        private Button btnAddAgility;
        private Label label2;
        private Label label6;
        private Button btnMinusIntuition;
        private Button btnAddIntuition;
        private Label label8;
        private Button btnMinusEnergy;
        private Button btnAddEnergy;
        private Label label4;
        private Button btnMinusResilience;
        private Button btnAddResilience;
        private Label label5;
        private Button btnMinusFocus;
        private Button btnAddFocus;
        private TextBox txtBoxPower;
        private Button btnCommit;
        private TextBox txtBoxIntuition;
        private TextBox txtBoxEnergy;
        private TextBox txtBoxResilience;
        private TextBox txtBoxFocus;
        private TextBox txtBoxAgility;
        private Label lblPoints;
        private Label label7;
    }
}
