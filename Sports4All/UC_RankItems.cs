using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_RankItems : UserControl
    {
        #region Properties
        private string _classificacao;
        private string _utilizador;
        private string _partidasJogadas;
        private string _pontos;

        public string Classificacao 
        {
            get { return _classificacao; }
            set { _classificacao = value; lbUserRank.Text = value; }

        }

        public string Utilizador 
        {
            get { return _utilizador; }
            set { _utilizador = value; lblUsername.Text = value; }

        }

        public string PartidasJogadas
        {
            get { return _partidasJogadas; }
            set { _partidasJogadas = value; lblGamesPlayed.Text = value; }

        }

        public string Pontos
        {
            get { return _pontos; }
            set { _pontos = value; lblPoints.Text = value; }

        }


        #endregion

        public UC_RankItems()
        {
            InitializeComponent();
        }
    }
}
