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
    public partial class EndResult : UserControl
    {
        public static string PlayerName;
        public EndResult()
        {
            InitializeComponent();
        }
        private void EndResult_Load(object sender, EventArgs e)
        {

            var lvl1Summary = DataStorage.stageResult.Dequeue();
            var lvl2Summary = DataStorage.stageResult.Dequeue();
            var lvl3Summary = DataStorage.stageResult.Dequeue();

            float averageSc = ((lvl1Summary.GetSurvivalChance() + lvl2Summary.GetSurvivalChance() + lvl3Summary.GetSurvivalChance()) / 3);


            labelLvl1SC.Text = Convert.ToString(lvl1Summary.GetSurvivalChance()) + "%";
            labelLvl2SC.Text = Convert.ToString(lvl2Summary.GetSurvivalChance()) + "%";
            labelLvl3SC.Text = Convert.ToString(lvl3Summary.GetSurvivalChance()) + "%";

            labelPlayerName.Text = PlayerName;
            labelASC.Text = Convert.ToString(Math.Round(averageSc, 1));

            DataStorage.gameHistory.Add(new GameContentCompilation(PlayerName, averageSc));
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Leaderboard_Click(object sender, EventArgs e)  
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new LeaderBoard());
        }

        private void pictureBox_Home_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new StartingPage());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
