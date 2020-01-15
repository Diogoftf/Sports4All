using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports4All.Properties;

namespace Sports4All
{
    public partial class UC_EventEvaluation : UserControl
    {
        //private bool _radioChecked;

        UC_PlayerEvaluationItem[] avaliacaoJogadores = new UC_PlayerEvaluationItem[5];

        public UC_EventEvaluation()
        {
            InitializeComponent();
        }

        private void UCEventEvaluation_Load(object sender, EventArgs e)
        {
            populateItems();
        }



        //private bool isRadioChecked(GroupBox group)
        //{
        //    foreach (var radio in group.Controls.OfType<RadioButton>())
        //    {
        //        if (radio.Checked)
        //        {
        //            _radioChecked = true;
        //            break;
        //        }
        //    }

        //    return _radioChecked;
        //}

        private void validateRadio()
        {
            foreach (var item in avaliacaoJogadores)
            {
                if (item.PlayerFairplay == 0 || item.PlayerSkill == 0) // será que isto não causa coupling entre esta classe e a avaliacaoJogadores? Não seria melhor tentar validar sem relacionar com playerskill?
                {
                    MessageBox.Show("Todos os campos do formulário devem estar preenchidos!");
                    break;
                }
            }
        }

        //private string getCheckedRadio(Control container)
        //{
        //    var checkedRadio = container.Controls.OfType<RadioButton>()
        //        .FirstOrDefault(r => r.Checked);
        //    return checkedRadio.Text;
        //}

        private void circularButton1_Click(object sender, EventArgs e)
        {
            //if (!isRadioChecked(groupEvEvent))
            //{
            //    validateRadio();
            //}
            //else
            //{
            //MessageBox.Show(getCheckedRadio(panel1));
            //}
            validateRadio();
        }

        private void populateItems()
        {
            flpPlayersEvaluation.Controls.Clear();
            for (int i = 0; i < avaliacaoJogadores.Length; i++)
            {
                avaliacaoJogadores[i] = new UC_PlayerEvaluationItem();
                avaliacaoJogadores[i].PlayerSkill = 0;  //ver se é necessário isto ou já começa a zero
                avaliacaoJogadores[i].PlayerFairplay = 0; //ver se é necessário isto ou já começa a zero
                avaliacaoJogadores[i].Username = "Get Data Somewhere";
                //avaliacaoJogadores[i].Icon = Resources.StarIconGold;

                flpPlayersEvaluation.Controls.Add(avaliacaoJogadores[i]);
            }
        }
    }
}
