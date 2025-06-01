using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Death_by_System
{
    public partial class GuidePage : UserControl
    {
        private int currentGuideIndex = 0;
        private Image[] guideImages;

        public GuidePage()
        {
            InitializeComponent();
            pictureBox_Guide.Image = Properties.Resources.Guide1;
            guideImages = new Image[]
            {
                Properties.Resources.Guide1,
                Properties.Resources.Guide2,
                Properties.Resources.Guide3,
                Properties.Resources.Guide4,
                Properties.Resources.Guide5,
                Properties.Resources.Guide6
            };

            pictureBox_Guide.Image = guideImages[currentGuideIndex];
        }

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxName.Text = "";
        }


        private void label_Startbtn_Click(object sender, EventArgs e)
        {
            EndResult.PlayerName = textBoxName.Text;
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new LevelTransition());

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 3500;

            timer.Tick += (s, e2) =>
            {
                timer.Stop();
                MainPanel._mainpanel.panelCTN.Controls.Clear();
                GamePlay gameplay = new GamePlay();
                string stageName = "Whisperwood Forest";
                gameplay.label_Settings.Text = stageName.ToUpper();
                gameplay.label_Level.Text = "LEVEL 1";
                string gameSceneContent = GameContent.GetScenesText(stageName);
                MainPanel._mainpanel.panelCTN.Controls.Add(gameplay);

                gameplay.StartRevealSequence(gameSceneContent);

            };

            timer.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            currentGuideIndex++;

            if (currentGuideIndex >= guideImages.Length)
                currentGuideIndex = 0; // wrap back to first

            pictureBox_Guide.Image = guideImages[currentGuideIndex];
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            currentGuideIndex--;

            if (currentGuideIndex < 0)
                currentGuideIndex = guideImages.Length - 1; // wrap to last

            pictureBox_Guide.Image = guideImages[currentGuideIndex];
        }
    }
}
