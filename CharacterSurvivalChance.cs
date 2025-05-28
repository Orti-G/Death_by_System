using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            pictureBox_Character.Image = Properties.Resources.SampleCharacter; // Replace with your actual resource
            label_Class.Text = "FIGHTER";

            await Task.Delay(1000);
            pictureBox_Loading.Visible = true;
            panel_BG.Visible = true;
            pictureBox_Arrows.Visible = true;
            label_textAbove.Visible = true;

            await Task.Delay(4000);
            pictureBox_Loading.Visible = false;
            label_textAbove.Visible = false;
            label_SurvivalChance.Visible = true;
            label_Rate.Text = "65%";
            label_Rate.Visible = true;

            await Task.Delay(2000);
            label_Points.Text = "+5 points";
            label_Points.ForeColor = Color.Green;
            label_Points.Visible = true;

            await Task.Delay(1000);
            btnNext.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
