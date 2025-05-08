namespace Death_by_System
{
    partial class MainPanel
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
            panelCTN = new Panel();
            SuspendLayout();
            // 
            // panelCTN
            // 
            panelCTN.Dock = DockStyle.Fill;
            panelCTN.Location = new Point(0, 0);
            panelCTN.Name = "panelCTN";
            panelCTN.Size = new Size(816, 494);
            panelCTN.TabIndex = 0;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 494);
            Controls.Add(panelCTN);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Death by System";
            ResumeLayout(false);
        }

        #endregion

        public Panel panelCTN;
    }
}