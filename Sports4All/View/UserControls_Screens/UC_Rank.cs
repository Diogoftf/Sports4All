using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_Rank : UserControl, IUserControl
    {
        private RankController _rankController;

        public UC_Rank()
        {
            InitializeComponent();
        }

        #region Properties
        public string Id { get; set; }
        #endregion

        private void UC_Rank_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Populate();

        }

        public void Populate()
        {
            _rankController = new RankController();
            Load_Rank(true);
        }

        private void Load_Rank(bool top10)
        {
            lblName1.Text = "Utilizador";
            lblName2.Text = "Partidas";
            lblName3.Text = "Pontos";
            flpRank.Controls.Clear();
            ICollection<UserClassification> topUsers = _rankController.GetTopUsers();
            var aux = topUsers.Count;
            
            if (top10)
            {
                aux = 10;
            }

            if (topUsers.Any())
            {
                for (int i = 0; i < topUsers.Count; i++)
                {
                    if (i < aux)
                    {
                        UC_RankItems rankItems = new UC_RankItems
                        {
                            Classification = (i + 1).ToString(),
                            User = topUsers.ToList()[i].User.Username.ToString(),
                            GamesPlayed = topUsers.ToList()[i].User.Events.Count.ToString(),
                            Points = topUsers.ToList()[i].Points.ToString()
                        };
                        flpRank.Controls.Add(rankItems);
                    }
                }
            }
            else
            {
                UC_RankItems rankItems = new UC_RankItems();
                rankItems.Classification = rankItems.GamesPlayed = rankItems.Points = "";
                rankItems.User = "Não existem jogadores com pontos";
                flpRank.Controls.Add(rankItems);
            }
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            Load_Rank(true);
        }

        private void btnGlobalRank_Click(object sender, EventArgs e)
        {
            Load_Rank(false);
        }

        private void btnTopGrounds_Click(object sender, EventArgs e)
        {
            flpRank.Controls.Clear();
            lblName1.Text = "Nome";
            lblName2.Text = "Qualidade / Preço";
            lblName3.Text = "Pontos";
            var gamesPlayedAux = 0;
            ICollection<ParkClassification> GroundsClassification = _rankController.GetTopGrounds();

            if (GroundsClassification.Any())
            {
                for (int i = 0; i < GroundsClassification.Count; i++)
                {
                    UC_RankItems rankItems = new UC_RankItems
                    {
                        Classification = (i + 1).ToString(),
                        User = GroundsClassification.ToList()[i].Park.Name.ToString()
                    };

                    foreach (Ground a in GroundsClassification.ToList()[i].Park.Grounds)
                        {
                            gamesPlayedAux += a.Reserves.Count;
                        }

                    rankItems.GamesPlayed = GroundsClassification.ToList()[i].QualityAverage.ToString()
                        + " / "
                        + GroundsClassification.ToList()[i].PriceAverage.ToString();

                    rankItems.Points = GroundsClassification.ToList()[i].Points.ToString();
                    flpRank.Controls.Add(rankItems);
                }
            }
            else
            {
                UC_RankItems rankItems = new UC_RankItems();
                rankItems.Classification = rankItems.GamesPlayed = rankItems.Points = "";
                rankItems.User = "Não existem recintos avaliados";
                flpRank.Controls.Add(rankItems); 

            }
        }
    }
}
