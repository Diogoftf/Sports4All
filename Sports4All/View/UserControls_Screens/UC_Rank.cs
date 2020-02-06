﻿using System;
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
            //_rankController.UserPointsCalculator(); // PROVISORIO //
            //_rankController.ParkPointsCalculator(); // PROVISORIO //
            Load_Rank(true);
        }

        private void Load_Rank(bool top10)
        {
            lblName1.Text = "Utilizador";
            lblName2.Text = "Partidas";
            lblName3.Text = "Pontos";
            flpRank.Controls.Clear();
            ICollection<UserClassification> topUsers = _rankController.getTopUsers();
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
                            Classificacao = (i + 1).ToString(),
                            Utilizador = topUsers.ToList()[i].User.Username.ToString(),
                            PartidasJogadas = topUsers.ToList()[i].User.Events.Count.ToString(),
                            Pontos = topUsers.ToList()[i].Points.ToString()
                        };
                        flpRank.Controls.Add(rankItems);
                    }
                }
            }
            else
            {
                UC_RankItems rankItems = new UC_RankItems();
                rankItems.Classificacao = rankItems.PartidasJogadas = rankItems.Pontos = "";
                rankItems.Utilizador = "Não existem jogadores com pontos";
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

        private void btnTopRecintos_Click(object sender, EventArgs e)
        {
            flpRank.Controls.Clear();
            lblName1.Text = "Nome";
            lblName2.Text = "Qualidade / Preço";
            lblName3.Text = "Pontos";
            var auxiliarPartidasJogadas = 0;
            ICollection<ParkClassification> RecintosClassification = _rankController.getTopRecintos();

            if (RecintosClassification.Any())
            {
                for (int i = 0; i < RecintosClassification.Count; i++)
                {
                    UC_RankItems rankItems = new UC_RankItems
                    {
                        Classificacao = (i + 1).ToString(),
                        Utilizador = RecintosClassification.ToList()[i].Park.Name.ToString()
                    };

                    foreach (Ground a in RecintosClassification.ToList()[i].Park.Grounds)
                        {
                            auxiliarPartidasJogadas += a.Reserves.Count;
                        }

                    rankItems.PartidasJogadas = RecintosClassification.ToList()[i].QualityAverage.ToString()
                        + " / "
                        + RecintosClassification.ToList()[i].PriceAverage.ToString();

                    rankItems.Pontos = RecintosClassification.ToList()[i].Points.ToString();
                    flpRank.Controls.Add(rankItems);
                }
            }
            else
            {
                UC_RankItems rankItems = new UC_RankItems();
                rankItems.Classificacao = rankItems.PartidasJogadas = rankItems.Pontos = "";
                rankItems.Utilizador = "Não existem recintos avaliados";
                flpRank.Controls.Add(rankItems); 

            }
        }
    }
}
