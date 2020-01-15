using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            moveSidePanel(btn_Home);
            
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_Home);
            UC_Home1.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(button2);
            eventosControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveSidePanel(button3);
            recintosControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moveSidePanel(button4);
            subscricoesControl1.BringToFront();
        }

        private void moveSidePanel(Button button)
        {
            SidePanel.Height = button.Height;
            SidePanel.Top = button.Top;
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnRanking);
            UC_Rank1.BringToFront();
        }

        private void uC_HeaderUser1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            //button6.BackColor = Color.DarkGray;
            uC_MyEvents1.Visible = true;
            uC_MyEvents1.BringToFront();
   
        }

        private void btnAddfriend_Click(object sender, EventArgs e)
        {
            uC_AddFriend1.BringToFront();
        }

        private void eventosControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          // var context = new QxP1IZ6nAWEntities();
        // !! TEMPORARIO!! PEGA O PRIMEIRO USER DA TABELA
       // lbWelcomeUser.Text = "Bem-vindo, " + context.User.ToList()[0].username;
        }

        private void lbWelcomeUser_Click(object sender, EventArgs e)
        {

        }
    }
}
