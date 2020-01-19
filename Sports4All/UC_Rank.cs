using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_Rank : UserControl
    {
       // private List<UC_RankItems> _top10Users = new List<UC_RankItems>();
       // private List<UC_RankItems> _globalUsers = new List<UC_RankItems>();
       // private List<UC_RankItems> _topRecintos = new List<UC_RankItems>();
        private readonly RankController rankController = new RankController();

        public UC_Rank()
        {
            InitializeComponent();
        }

        private void lblEventOwnerValue_Click(object sender, EventArgs e)
        {

        }

        private void load_Top10Rank()
        {
            flpRank.Controls.Clear();
            List<Classification> topUsers = rankController.getTopUsers();

            for (int i = 0; i < topUsers.Count; i++)
            {

                if (i < 10)
                {
                    UC_RankItems rankItems = new UC_RankItems();
                    rankItems.Classificacao = topUsers[i].rankClassification.ToString();
                    rankItems.Utilizador = topUsers[i].userId.Username.ToString();
                    rankItems.PartidasJogadas = (topUsers[i].userId.Events.Count + topUsers[i].userId.Reserves.Count).ToString();
                    rankItems.Pontos = topUsers[i].points.ToString();
                    //_top10Users.Add(rankItems);
                    flpRank.Controls.Add(rankItems); //add to flowlayout
                }

            }

        }

        private void load_GlobalRank()
        {
            flpRank.Controls.Clear();
            List<Classification> topUsers = rankController.getTopUsers();

            foreach (Classification e in topUsers)
            {
                UC_RankItems rankItems = new UC_RankItems();
                rankItems.Classificacao = e.rankClassification.ToString();
                rankItems.Utilizador = e.userId.Username.ToString();
                rankItems.PartidasJogadas = (e.userId.Events.Count + e.userId.Reserves.Count).ToString();
                rankItems.Pontos = e.points.ToString();
                //_top10Users.Add(rankItems);
                flpRank.Controls.Add(rankItems); //add to flowlayout
            }
        }

        private void UC_Rank_Load(object sender, EventArgs e)
        {
            //load_Top10Rank();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {

          //  load_Top10Rank();
        }

        private void btnGlobalRank_Click(object sender, EventArgs e)
        {
         //   load_GlobalRank();
        }

        private void btnTopRecintos_Click(object sender, EventArgs e)
        {

        }
    }
}
