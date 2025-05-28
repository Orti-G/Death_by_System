using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Death_by_System.GamePlay;

namespace Death_by_System
{
    public partial class CharacterSurvivalChance : UserControl
    {
        public CharacterSurvivalChance()
        {
            InitializeComponent();
        
        }

        public async void StartRevealSequence()
        {
            pictureBox_Arrows.Visible = false;
            pictureBox_Loading.Visible = false;
            label_Rate.Visible = false;
            label_SurvivalChance.Visible = false;
            label_Points.Visible = false;
            panel_BG.Visible = false;
            btnNext.Visible = false;
            label_textAbove.Visible = false;

            pictureBox_Character.Visible = true;
            label_Class.Visible = true;

            await Task.Delay(4000);
            ClassAnalyzer();
            

            await Task.Delay(1000);
            pictureBox_Loading.Visible = true;
            panel_BG.Visible = true;
            pictureBox_Arrows.Visible = true;
            label_textAbove.Visible = true;

            await Task.Delay(4000);
            pictureBox_Loading.Visible = false;
            label_textAbove.Visible = false;
            label_SurvivalChance.Visible = true;
            SurvivalChanceAnalyzer();

            await Task.Delay(2000);
            label_Points.Text = "+5 points";
            label_Points.ForeColor = Color.Green;
            label_Points.Visible = true;

            await Task.Delay(1000);
            btnNext.Visible = true;
        }
        private void ClassAnalyzer() 
        {
            List<StageResult> list = new List<StageResult>();

            MessageBox.Show(Convert.ToString(DataStorage.stageResult.Count));
            if (GamePlay.predictedClass == "Fighter")
            {
                pictureBox_Character.Image = Properties.Resources.SampleCharacter; // Replace with your actual resource
                label_Class.Text = "FIGHTER";
            }
            else if (GamePlay.predictedClass == "Mage")
            {
                pictureBox_Character.Image = Properties.Resources.SampleCharacter; // Replace with your actual resource
                label_Class.Text = "MAGE";
            }
            else if (GamePlay.predictedClass == "Assassin")
            {
                pictureBox_Character.Image = Properties.Resources.SampleCharacter; // Replace with your actual resource
                label_Class.Text = "ASSASSIN";
            }
            else
            {
                label_Class.Text = "ERROR";
            }
        }

        private void SurvivalChanceAnalyzer()
        {
            label_Rate.Text = Convert.ToString(GamePlay.predictedSurvivalChance) + "%";
            label_Rate.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
