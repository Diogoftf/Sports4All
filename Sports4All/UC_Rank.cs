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
            load_Rank(true);
        }

        private void lblEventOwnerValue_Click(object sender, EventArgs e)
        {

        }

        private void load_Rank(bool top10)
        {
            flpRank.Controls.Clear();
            ICollection<Classification> topUsers = rankController.getTopUsers();
            var auxiliar = topUsers.Count;
            
            if (top10)
                auxiliar = 10;

            for (int i = 0; i < topUsers.Count; i++)
            {
                if (i < auxiliar)
                {
                    UC_RankItems rankItems = new UC_RankItems();
                    rankItems.Classificacao = topUsers.ToList()[i].rankClassification.ToString();
                    rankItems.Utilizador = topUsers.ToList()[i].userId.Username.ToString();
                    rankItems.PartidasJogadas = topUsers.ToList()[i].userId.Events.Count.ToString();
                    rankItems.Pontos = topUsers.ToList()[i].points.ToString();
                    //_top10Users.Add(rankItems);
                    flpRank.Controls.Add(rankItems); //add to flowlayout
                }

            }

        }

        private void UC_Rank_Load(object sender, EventArgs e)
        {
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            load_Rank(true);
        }

        private void btnGlobalRank_Click(object sender, EventArgs e)
        {
            load_Rank(false);
        }

        private void btnTopRecintos_Click(object sender, EventArgs e)
        {
            load_Rank(true);
        }
    }
}
