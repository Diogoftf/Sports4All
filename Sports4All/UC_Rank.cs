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
        public UC_Rank()
        {
            InitializeComponent();
        }

        private void lblEventOwnerValue_Click(object sender, EventArgs e)
        {

        }

        private void load_Top10Rank()
        {
            UC_RankItems[] listitems = new UC_RankItems[5];
            flpRank.Controls.Clear();


            /*
             * FAZER QUERIE À BD E COLOCAR AQUI PARA O TOP10 DE USERS
             * 
             * ´TIRAR O 50 --->
             */

            for (int i = 0; i < listitems.Length; i++)
            {

                listitems[i] = new UC_RankItems();
                listitems[i].Classificacao = "1";
                listitems[i].Utilizador = "Ramenaca";
                listitems[i].PartidasJogadas = "12 partidas";
                listitems[i].Pontos = "12 pontos";
                flpRank.Controls.Add(listitems[i]); //add to flowlayout

            }
        }

        private void load_GlobalRank()
        {
            UC_RankItems[] listitems = new UC_RankItems[5];
            flpRank.Controls.Clear();


            /*
             * FAZER QUERIE À BD E COLOCAR AQUI PARA O TOP10 DE USERS
             * 
             * ´TIRAR O 50 --->
             */

            for (int i = 0; i < listitems.Length; i++)
            {

                listitems[i] = new UC_RankItems();
                listitems[i].Classificacao = "1";
                listitems[i].Utilizador = "Ramenaca";
                listitems[i].PartidasJogadas = "12 partidas";
                listitems[i].Pontos = "12 pontos";
                flpRank.Controls.Add(listitems[i]); //add to flowlayout

            }
        }

        private void UC_Rank_Load(object sender, EventArgs e)
        {
            load_Top10Rank();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {

            load_Top10Rank();
        }

        private void btnGlobalRank_Click(object sender, EventArgs e)
        {
            load_GlobalRank();
        }
    }
}
