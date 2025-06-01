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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay));
            StatsPanel = new Panel();
            label11 = new Label();
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
            panel_Scenario = new Panel();
            label_Scenario = new Label();
            label_textScenario = new Label();
            label9 = new Label();
            panel3 = new Panel();
            panel_Title = new Panel();
            label_Level = new Label();
            label_Settings = new Label();
            StatsPanel.SuspendLayout();
            panel_Scenario.SuspendLayout();
            panel3.SuspendLayout();
            panel_Title.SuspendLayout();
            SuspendLayout();
            // 
            // StatsPanel
            // 
            StatsPanel.BackColor = Color.Black;
            StatsPanel.BackgroundImage = Properties.Resources.Panel_StatAdjusment_new2_;
            StatsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            StatsPanel.Controls.Add(label11);
            StatsPanel.Controls.Add(lblPoints);
            StatsPanel.Controls.Add(label7);
            StatsPanel.Controls.Add(txtBoxIntuition);
            StatsPanel.Controls.Add(txtBoxEnergy);
            StatsPanel.Controls.Add(txtBoxResilience);
            StatsPanel.Controls.Add(txtBoxFocus);
            StatsPanel.Controls.Add(txtBoxAgility);
            StatsPanel.Controls.Add(btnCommit);
            StatsPanel.Controls.Add(txtBoxPower);
            StatsPanel.Controls.Add(label6);
            StatsPanel.Controls.Add(btnMinusIntuition);
            StatsPanel.Controls.Add(btnAddIntuition);
            StatsPanel.Controls.Add(label8);
            StatsPanel.Controls.Add(btnMinusEnergy);
            StatsPanel.Controls.Add(btnAddEnergy);
            StatsPanel.Controls.Add(label4);
            StatsPanel.Controls.Add(btnMinusResilience);
            StatsPanel.Controls.Add(btnAddResilience);
            StatsPanel.Controls.Add(label5);
            StatsPanel.Controls.Add(btnMinusFocus);
            StatsPanel.Controls.Add(btnAddFocus);
            StatsPanel.Controls.Add(label3);
            StatsPanel.Controls.Add(btnMinusAgility);
            StatsPanel.Controls.Add(btnAddAgility);
            StatsPanel.Controls.Add(label2);
            StatsPanel.Controls.Add(btnMinusPower);
            StatsPanel.Controls.Add(btnAddPower);
            StatsPanel.Location = new Point(51, 353);
            StatsPanel.Margin = new Padding(3, 4, 3, 4);
            StatsPanel.Name = "StatsPanel";
            StatsPanel.Size = new Size(1103, 297);
            StatsPanel.TabIndex = 1;
            StatsPanel.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(213, 33);
            label11.Name = "label11";
            label11.Size = new Size(670, 25);
            label11.TabIndex = 6;
            label11.Text = "Adjust your stats to overcome the challenge.";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // lblPoints
            // 
            lblPoints.Anchor = AnchorStyles.None;
            lblPoints.AutoSize = true;
            lblPoints.BackColor = Color.Transparent;
            lblPoints.Font = new Font("Squada One", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoints.ForeColor = SystemColors.ButtonHighlight;
            lblPoints.Location = new Point(987, 37);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(38, 25);
            lblPoints.TabIndex = 33;
            lblPoints.Text = "100";
            lblPoints.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Pixellari", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(909, 41);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 32;
            label7.Text = "Points:";
            // 
            // txtBoxIntuition
            // 
            txtBoxIntuition.Anchor = AnchorStyles.None;
            txtBoxIntuition.Font = new Font("Squada One", 16.2F);
            txtBoxIntuition.Location = new Point(802, 192);
            txtBoxIntuition.Margin = new Padding(3, 4, 3, 4);
            txtBoxIntuition.MaxLength = 2;
            txtBoxIntuition.Name = "txtBoxIntuition";
            txtBoxIntuition.Size = new Size(47, 36);
            txtBoxIntuition.TabIndex = 31;
            txtBoxIntuition.Text = "0";
            txtBoxIntuition.TextAlign = HorizontalAlignment.Center;
            txtBoxIntuition.Leave += txtBoxIntuition_Leave;
            // 
            // txtBoxEnergy
            // 
            txtBoxEnergy.Anchor = AnchorStyles.None;
            txtBoxEnergy.Font = new Font("Squada One", 16.2F);
            txtBoxEnergy.Location = new Point(802, 140);
            txtBoxEnergy.Margin = new Padding(3, 4, 3, 4);
            txtBoxEnergy.MaxLength = 2;
            txtBoxEnergy.Name = "txtBoxEnergy";
            txtBoxEnergy.Size = new Size(47, 36);
            txtBoxEnergy.TabIndex = 30;
            txtBoxEnergy.Text = "0";
            txtBoxEnergy.TextAlign = HorizontalAlignment.Center;
            txtBoxEnergy.Leave += txtBoxEnergy_Leave;
            // 
            // txtBoxResilience
            // 
            txtBoxResilience.Anchor = AnchorStyles.None;
            txtBoxResilience.Font = new Font("Squada One", 16.2F);
            txtBoxResilience.Location = new Point(802, 88);
            txtBoxResilience.Margin = new Padding(3, 4, 3, 4);
            txtBoxResilience.MaxLength = 2;
            txtBoxResilience.Name = "txtBoxResilience";
            txtBoxResilience.Size = new Size(47, 36);
            txtBoxResilience.TabIndex = 29;
            txtBoxResilience.Text = "0";
            txtBoxResilience.TextAlign = HorizontalAlignment.Center;
            txtBoxResilience.Leave += txtBoxResilience_Leave;
            // 
            // txtBoxFocus
            // 
            txtBoxFocus.Anchor = AnchorStyles.None;
            txtBoxFocus.Font = new Font("Squada One", 16.2F);
            txtBoxFocus.Location = new Point(386, 140);
            txtBoxFocus.Margin = new Padding(3, 4, 3, 4);
            txtBoxFocus.MaxLength = 2;
            txtBoxFocus.Name = "txtBoxFocus";
            txtBoxFocus.Size = new Size(57, 36);
            txtBoxFocus.TabIndex = 28;
            txtBoxFocus.Text = "0";
            txtBoxFocus.TextAlign = HorizontalAlignment.Center;
            txtBoxFocus.Leave += txtBoxFocus_Leave;
            // 
            // txtBoxAgility
            // 
            txtBoxAgility.Anchor = AnchorStyles.None;
            txtBoxAgility.Font = new Font("Squada One", 16.2F);
            txtBoxAgility.Location = new Point(386, 189);
            txtBoxAgility.Margin = new Padding(3, 4, 3, 4);
            txtBoxAgility.MaxLength = 2;
            txtBoxAgility.Name = "txtBoxAgility";
            txtBoxAgility.Size = new Size(57, 36);
            txtBoxAgility.TabIndex = 27;
            txtBoxAgility.Text = "0";
            txtBoxAgility.TextAlign = HorizontalAlignment.Center;
            txtBoxAgility.Leave += txtBoxAgility_Leave;
            // 
            // btnCommit
            // 
            btnCommit.Anchor = AnchorStyles.None;
            btnCommit.Font = new Font("Pixellari", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCommit.Location = new Point(950, 235);
            btnCommit.Margin = new Padding(3, 4, 3, 4);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(86, 31);
            btnCommit.TabIndex = 26;
            btnCommit.Text = "Commit";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += btnCommit_Click;
            // 
            // txtBoxPower
            // 
            txtBoxPower.Anchor = AnchorStyles.None;
            txtBoxPower.Font = new Font("Squada One", 16.2F);
            txtBoxPower.Location = new Point(386, 91);
            txtBoxPower.Margin = new Padding(3, 4, 3, 4);
            txtBoxPower.MaxLength = 2;
            txtBoxPower.Name = "txtBoxPower";
            txtBoxPower.Size = new Size(57, 36);
            txtBoxPower.TabIndex = 25;
            txtBoxPower.Text = "0";
            txtBoxPower.TextAlign = HorizontalAlignment.Center;
            txtBoxPower.Leave += txtBoxPower_Leave;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Pixellari", 16.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(629, 138);
            label6.Name = "label6";
            label6.Size = new Size(106, 28);
            label6.TabIndex = 24;
            label6.Text = "Energy";
            // 
            // btnMinusIntuition
            // 
            btnMinusIntuition.Anchor = AnchorStyles.None;
            btnMinusIntuition.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnMinusIntuition.Location = new Point(773, 195);
            btnMinusIntuition.Margin = new Padding(0);
            btnMinusIntuition.Name = "btnMinusIntuition";
            btnMinusIntuition.RightToLeft = RightToLeft.No;
            btnMinusIntuition.Size = new Size(24, 27);
            btnMinusIntuition.TabIndex = 23;
            btnMinusIntuition.Text = "-";
            btnMinusIntuition.UseVisualStyleBackColor = true;
            btnMinusIntuition.Click += btnMinusIntuition_Click;
            // 
            // btnAddIntuition
            // 
            btnAddIntuition.Anchor = AnchorStyles.None;
            btnAddIntuition.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnAddIntuition.Location = new Point(856, 195);
            btnAddIntuition.Margin = new Padding(0);
            btnAddIntuition.Name = "btnAddIntuition";
            btnAddIntuition.RightToLeft = RightToLeft.No;
            btnAddIntuition.Size = new Size(24, 27);
            btnAddIntuition.TabIndex = 22;
            btnAddIntuition.Text = "+";
            btnAddIntuition.TextAlign = ContentAlignment.MiddleLeft;
            btnAddIntuition.UseVisualStyleBackColor = true;
            btnAddIntuition.Click += btnAddIntuition_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Pixellari", 16.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(615, 191);
            label8.Name = "label8";
            label8.Size = new Size(120, 28);
            label8.TabIndex = 18;
            label8.Text = "Intuition";
            // 
            // btnMinusEnergy
            // 
            btnMinusEnergy.Anchor = AnchorStyles.None;
            btnMinusEnergy.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnMinusEnergy.Location = new Point(773, 141);
            btnMinusEnergy.Margin = new Padding(0);
            btnMinusEnergy.Name = "btnMinusEnergy";
            btnMinusEnergy.RightToLeft = RightToLeft.No;
            btnMinusEnergy.Size = new Size(24, 27);
            btnMinusEnergy.TabIndex = 17;
            btnMinusEnergy.Text = "-";
            btnMinusEnergy.UseVisualStyleBackColor = true;
            btnMinusEnergy.Click += btnMinusEnergy_Click;
            // 
            // btnAddEnergy
            // 
            btnAddEnergy.Anchor = AnchorStyles.None;
            btnAddEnergy.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnAddEnergy.Location = new Point(856, 141);
            btnAddEnergy.Margin = new Padding(0);
            btnAddEnergy.Name = "btnAddEnergy";
            btnAddEnergy.RightToLeft = RightToLeft.No;
            btnAddEnergy.Size = new Size(24, 27);
            btnAddEnergy.TabIndex = 16;
            btnAddEnergy.Text = "+";
            btnAddEnergy.TextAlign = ContentAlignment.MiddleLeft;
            btnAddEnergy.UseVisualStyleBackColor = true;
            btnAddEnergy.Click += btnAddEnergy_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Pixellari", 16.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(606, 92);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 12;
            label4.Text = "Resilience";
            // 
            // btnMinusResilience
            // 
            btnMinusResilience.Anchor = AnchorStyles.None;
            btnMinusResilience.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnMinusResilience.Location = new Point(773, 91);
            btnMinusResilience.Margin = new Padding(0);
            btnMinusResilience.Name = "btnMinusResilience";
            btnMinusResilience.RightToLeft = RightToLeft.No;
            btnMinusResilience.Size = new Size(24, 27);
            btnMinusResilience.TabIndex = 11;
            btnMinusResilience.Text = "-";
            btnMinusResilience.UseVisualStyleBackColor = true;
            btnMinusResilience.Click += btnMinusResilience_Click;
            // 
            // btnAddResilience
            // 
            btnAddResilience.Anchor = AnchorStyles.None;
            btnAddResilience.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnAddResilience.Location = new Point(856, 91);
            btnAddResilience.Margin = new Padding(0);
            btnAddResilience.Name = "btnAddResilience";
            btnAddResilience.RightToLeft = RightToLeft.No;
            btnAddResilience.Size = new Size(24, 27);
            btnAddResilience.TabIndex = 10;
            btnAddResilience.Text = "+";
            btnAddResilience.TextAlign = ContentAlignment.MiddleLeft;
            btnAddResilience.UseVisualStyleBackColor = true;
            btnAddResilience.Click += btnAddResilience_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Pixellari", 16.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(230, 138);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 9;
            label5.Text = "Focus";
            // 
            // btnMinusFocus
            // 
            btnMinusFocus.Anchor = AnchorStyles.None;
            btnMinusFocus.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnMinusFocus.Location = new Point(352, 141);
            btnMinusFocus.Margin = new Padding(0);
            btnMinusFocus.Name = "btnMinusFocus";
            btnMinusFocus.RightToLeft = RightToLeft.No;
            btnMinusFocus.Size = new Size(24, 27);
            btnMinusFocus.TabIndex = 8;
            btnMinusFocus.Text = "-";
            btnMinusFocus.UseVisualStyleBackColor = true;
            btnMinusFocus.Click += btnMinusFocus_Click;
            // 
            // btnAddFocus
            // 
            btnAddFocus.Anchor = AnchorStyles.None;
            btnAddFocus.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnAddFocus.Location = new Point(450, 147);
            btnAddFocus.Margin = new Padding(0);
            btnAddFocus.Name = "btnAddFocus";
            btnAddFocus.RightToLeft = RightToLeft.No;
            btnAddFocus.Size = new Size(24, 27);
            btnAddFocus.TabIndex = 7;
            btnAddFocus.Text = "+";
            btnAddFocus.TextAlign = ContentAlignment.MiddleLeft;
            btnAddFocus.UseVisualStyleBackColor = true;
            btnAddFocus.Click += btnAddFocus_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Pixellari", 16.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(230, 186);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 6;
            label3.Text = "Agility";
            // 
            // btnMinusAgility
            // 
            btnMinusAgility.Anchor = AnchorStyles.None;
            btnMinusAgility.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnMinusAgility.Location = new Point(352, 192);
            btnMinusAgility.Margin = new Padding(0);
            btnMinusAgility.Name = "btnMinusAgility";
            btnMinusAgility.RightToLeft = RightToLeft.No;
            btnMinusAgility.Size = new Size(24, 27);
            btnMinusAgility.TabIndex = 5;
            btnMinusAgility.Text = "-";
            btnMinusAgility.UseVisualStyleBackColor = true;
            btnMinusAgility.Click += btnMinusAgility_Click;
            // 
            // btnAddAgility
            // 
            btnAddAgility.Anchor = AnchorStyles.None;
            btnAddAgility.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnAddAgility.Location = new Point(450, 195);
            btnAddAgility.Margin = new Padding(0);
            btnAddAgility.Name = "btnAddAgility";
            btnAddAgility.RightToLeft = RightToLeft.No;
            btnAddAgility.Size = new Size(24, 27);
            btnAddAgility.TabIndex = 4;
            btnAddAgility.Text = "+";
            btnAddAgility.TextAlign = ContentAlignment.MiddleLeft;
            btnAddAgility.UseVisualStyleBackColor = true;
            btnAddAgility.Click += btnAddAgility_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Pixellari", 16.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(230, 92);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 3;
            label2.Text = "Power";
            // 
            // btnMinusPower
            // 
            btnMinusPower.Anchor = AnchorStyles.None;
            btnMinusPower.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnMinusPower.Location = new Point(352, 95);
            btnMinusPower.Margin = new Padding(0);
            btnMinusPower.Name = "btnMinusPower";
            btnMinusPower.RightToLeft = RightToLeft.No;
            btnMinusPower.Size = new Size(24, 27);
            btnMinusPower.TabIndex = 2;
            btnMinusPower.Text = "-";
            btnMinusPower.UseVisualStyleBackColor = true;
            btnMinusPower.Click += btnMinusPower_Click;
            // 
            // btnAddPower
            // 
            btnAddPower.Anchor = AnchorStyles.None;
            btnAddPower.Font = new Font("The Bold Font", 10.1999989F, FontStyle.Bold);
            btnAddPower.Location = new Point(450, 93);
            btnAddPower.Margin = new Padding(0);
            btnAddPower.Name = "btnAddPower";
            btnAddPower.RightToLeft = RightToLeft.No;
            btnAddPower.Size = new Size(24, 27);
            btnAddPower.TabIndex = 1;
            btnAddPower.Text = "+";
            btnAddPower.TextAlign = ContentAlignment.MiddleLeft;
            btnAddPower.UseVisualStyleBackColor = true;
            btnAddPower.Click += btnAddPower_Click;
            // 
            // panel_Scenario
            // 
            panel_Scenario.BackColor = Color.Transparent;
            panel_Scenario.BackgroundImage = Properties.Resources.ScenarioPanel_lvl1;
            panel_Scenario.BackgroundImageLayout = ImageLayout.Stretch;
            panel_Scenario.Controls.Add(label_Scenario);
            panel_Scenario.Controls.Add(label_textScenario);
            panel_Scenario.Controls.Add(label9);
            panel_Scenario.Location = new Point(63, 84);
            panel_Scenario.Name = "panel_Scenario";
            panel_Scenario.Size = new Size(1117, 261);
            panel_Scenario.TabIndex = 4;
            // 
            // label_Scenario
            // 
            label_Scenario.Anchor = AnchorStyles.None;
            label_Scenario.BackColor = Color.Transparent;
            label_Scenario.Font = new Font("VP Pixel Simplified DEMO", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Scenario.ForeColor = Color.Honeydew;
            label_Scenario.Location = new Point(227, 36);
            label_Scenario.Name = "label_Scenario";
            label_Scenario.Size = new Size(671, 143);
            label_Scenario.TabIndex = 34;
            label_Scenario.Text = "SCENARIO";
            label_Scenario.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_textScenario
            // 
            label_textScenario.BackColor = Color.Transparent;
            label_textScenario.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_textScenario.ForeColor = Color.Honeydew;
            label_textScenario.Location = new Point(79, 36);
            label_textScenario.Name = "label_textScenario";
            label_textScenario.Size = new Size(965, 149);
            label_textScenario.TabIndex = 5;
            label_textScenario.Text = resources.GetString("label_textScenario.Text");
            label_textScenario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, -41);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 0;
            label9.Text = "label9";
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.BG_level1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(StatsPanel);
            panel3.Controls.Add(panel_Scenario);
            panel3.Controls.Add(panel_Title);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1200, 676);
            panel3.TabIndex = 5;
            // 
            // panel_Title
            // 
            panel_Title.Anchor = AnchorStyles.None;
            panel_Title.BackColor = SystemColors.ActiveCaptionText;
            panel_Title.Controls.Add(label_Level);
            panel_Title.Controls.Add(label_Settings);
            panel_Title.Location = new Point(699, 11);
            panel_Title.Name = "panel_Title";
            panel_Title.Size = new Size(555, 67);
            panel_Title.TabIndex = 5;
            // 
            // label_Level
            // 
            label_Level.Anchor = AnchorStyles.None;
            label_Level.AutoSize = true;
            label_Level.BackColor = Color.Transparent;
            label_Level.Font = new Font("ArcadeClassic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Level.ForeColor = Color.LawnGreen;
            label_Level.Location = new Point(329, 37);
            label_Level.Name = "label_Level";
            label_Level.Size = new Size(113, 30);
            label_Level.TabIndex = 33;
            label_Level.Text = "LEVEL 1";
            // 
            // label_Settings
            // 
            label_Settings.Anchor = AnchorStyles.None;
            label_Settings.BackColor = Color.Transparent;
            label_Settings.Font = new Font("Upheaval TT (BRK)", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Settings.ForeColor = Color.Honeydew;
            label_Settings.Location = new Point(3, 0);
            label_Settings.Name = "label_Settings";
            label_Settings.Size = new Size(491, 48);
            label_Settings.TabIndex = 0;
            label_Settings.Text = "WHISPERWOOD FOREST";
            label_Settings.TextAlign = ContentAlignment.TopCenter;
            label_Settings.Click += label1_Click;
            // 
            // GamePlay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GamePlay";
            Size = new Size(1200, 676);
            Load += GamePlay_Load;
            StatsPanel.ResumeLayout(false);
            StatsPanel.PerformLayout();
            panel_Scenario.ResumeLayout(false);
            panel_Scenario.PerformLayout();
            panel3.ResumeLayout(false);
            panel_Title.ResumeLayout(false);
            panel_Title.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel StatsPanel;
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
        private Label label9;
        private Panel panel_Title;
        private Label label11;
        private Label label_Scenario;
        public Panel panel_Scenario;
        public Panel panel3;
        public Label label_Settings;
        public Label label_Level;
        public Label label_textScenario;
    }
}
