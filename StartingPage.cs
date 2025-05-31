using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Death_by_System
{
    public partial class StartingPage : UserControl
    {
        public StartingPage()
        {
            InitializeComponent();        
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label_Startbtn_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new GuidePage());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new AboutUs());
        }

        private void label_Leaderboard_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new LeaderBoard());
        }
    }
}
