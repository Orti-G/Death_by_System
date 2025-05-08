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
    public partial class MainPanel : Form
    {
        public static MainPanel _mainpanel;
        public MainPanel()
        {
            InitializeComponent();
            panelCTN.Controls.Add(new StartingPage());
        }


    }
}
