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
    public partial class LeaderBoard : UserControl
    {
        public LeaderBoard()
        {
            InitializeComponent();
        }


        private void label_Home_Click(object sender, EventArgs e)
        {
            MainPanel._mainpanel.panelCTN.Controls.Clear();
            MainPanel._mainpanel.panelCTN.Controls.Add(new StartingPage());
        }

        private void LeaderBoard_Load(object sender, EventArgs e)
        {
            var sortedGameHistory = MergeSortDescending(DataStorage.gameHistory);

            lblRank1Name.Text = sortedGameHistory[0].GetPlayerName();
            lblRank1ASC.Text = Convert.ToString(sortedGameHistory[0].GetAverageSC()) + "%";

            lblRank2Name.Text = sortedGameHistory[1].GetPlayerName();
            lblRank2ASC.Text = Convert.ToString(sortedGameHistory[1].GetAverageSC()) + "%";

            lblRank3Name.Text = sortedGameHistory[2].GetPlayerName();
            lblRank3ASC.Text = Convert.ToString(sortedGameHistory[2].GetAverageSC()) + "%";

            lblRank4Name.Text = sortedGameHistory[3].GetPlayerName();
            lblRank4ASC.Text = Convert.ToString(sortedGameHistory[3].GetAverageSC()) + "%";

            lblRank5Name.Text = sortedGameHistory[4].GetPlayerName();
            lblRank5ASC.Text = Convert.ToString(sortedGameHistory[4].GetAverageSC()) + "%";

            lblRank6Name.Text = sortedGameHistory[5].GetPlayerName();
            lblRank6ASC.Text = Convert.ToString(sortedGameHistory[5].GetAverageSC()) + "%";

        }

        public static List<GameContentCompilation> MergeSortDescending(List<GameContentCompilation> input)
        {
            if (input.Count <= 1)
                return input;

            int mid = input.Count / 2;
            var left = MergeSortDescending(input.GetRange(0, mid));
            var right = MergeSortDescending(input.GetRange(mid, input.Count - mid));

            return MergeDescending(left, right);
        }

        private static List<GameContentCompilation> MergeDescending(List<GameContentCompilation> left, List<GameContentCompilation> right)
        {
            List<GameContentCompilation> result = new List<GameContentCompilation>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].GetAverageSC() >= right[j].GetAverageSC())
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }
    }
}
