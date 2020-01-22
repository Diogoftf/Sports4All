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
        private RankController _rankController;

        public UC_Rank()
        {
            InitializeComponent();
        }

        private void lblEventOwnerValue_Click(object sender, EventArgs e)
        {

        }

        private void load_Rank(bool top10)
        {
            lblName1.Text = "Utilizador";
            lblName2.Text = "Partidas";
            lblName3.Text = "Pontos";
            flpRank.Controls.Clear();
            ICollection<Classification> topUsers = _rankController.getTopUsers();
            var auxiliar = topUsers.Count;
            
            if (top10)
                auxiliar = 10;

            //if(topUsers.Count > 0)
            //{
            //    for (int i = 0; i < topUsers.Count; i++)
            //    {
            //        if (i < auxiliar && topUsers.ToList()[i].rankClassification > 0)
            //        {
            //            UC_RankItems rankItems = new UC_RankItems();
            //            rankItems.Classificacao = topUsers.ToList()[i].rankClassification.ToString();
            //            rankItems.Utilizador = topUsers.ToList()[i].userId.Username.ToString();
            //            rankItems.PartidasJogadas = topUsers.ToList()[i].userId.Events.Count.ToString();
            //            rankItems.Pontos = topUsers.ToList()[i].points.ToString();
            //            flpRank.Controls.Add(rankItems); //add to flowlayout
            //        }
            //    }
            //}
            //else
            //{
            //    UC_RankItems rankItems = new UC_RankItems();
            //    rankItems.Classificacao = rankItems.PartidasJogadas = rankItems.Pontos = "";
            //    rankItems.Utilizador = "Não existem jogadores com pontos";
            //    flpRank.Controls.Add(rankItems); //add to flowlayout
            //}


        }

        private void UC_Rank_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                _rankController = new RankController();
                load_Rank(true);
            }

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
            flpRank.Controls.Clear();
            lblName1.Text = "Nome";
            lblName2.Text = "Preço";
            lblName3.Text = "Qualidade";

            IOrderedEnumerable<UC_RankItems> RecintosClassification = _rankController.getTopRecintos();

            if (RecintosClassification.ToList().Count > 0)
            {
                for (int i = 0; i < RecintosClassification.ToList().Count; i++)
                {
                    flpRank.Controls.Add(RecintosClassification.ToList()[i]); //add to flowlayout
                }
            }
            else
            {
                UC_RankItems rankItems = new UC_RankItems();
                rankItems.Classificacao = rankItems.PartidasJogadas = rankItems.Pontos = "";
                rankItems.Utilizador = "Não existem recintos avaliados";
                flpRank.Controls.Add(rankItems); //add to flowlayout

            }
        }
    }
}
