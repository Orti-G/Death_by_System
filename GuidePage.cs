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
    public partial class GuidePage : UserControl
    {
        public GuidePage()
        {
            InitializeComponent();
        }

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxName.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new GamePlay());
        }
    }
}
