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
    public partial class StartingPage : UserControl
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new GuidePage());
        }
    }
}
