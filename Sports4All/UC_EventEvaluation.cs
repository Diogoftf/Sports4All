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
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventEvaluation : UserControl
    {
        public int EventId { get; set; }

        private UC_SportsgroundEvItem uc;

        private ICollection<UC_PlayerEvaluationItem> evaluationItems;
        EvaluationController _evaluationController = new EvaluationController();
        RankController _rankController = new RankController();
        Event _ev = new Event();

        public UC_EventEvaluation()
        {
            InitializeComponent();
            evaluationItems = new List<UC_PlayerEvaluationItem>();
            uc = UC_SportsgroundEvItem1;
        }

        private void UCEventEvaluation_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja submeter as avaliações?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SubmitEvaluations();




                if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UC_MyEvents"))
                {
                    UC_MyEvents uc = new UC_MyEvents { Dock = DockStyle.Fill };
                    Form1.Instance.PnlContainer.Controls.Add(uc);
                }

                Form1.Instance.PnlContainer.Controls["UC_MyEvents"].BringToFront();

                if (Form1.Instance.PnlContainer.Controls.ContainsKey("UC_MyEvents"))
                {
                    foreach (UserControl x in Form1.Instance.PnlContainer.Controls)
                    {
                        if (Form1.Instance.PnlContainer.Controls.GetChildIndex(x) == 0)
                        {
                            Form1.Instance.FrontControl = x;
                        }
                    }
                }

            }
        }
        public void SubmitEvaluations() 
        {
            _evaluationController.SetParkEvaluation(uc.ParkId, uc.ParkQuality, uc.ParkPrice, EventId);

            foreach (var evaluationUser in evaluationItems)
            {
                _evaluationController.SetUserEvaluation(evaluationUser.Username,
                    evaluationUser.PlayerSkill,
                    evaluationUser.PlayerFairplay,
                    EventId);
            }
            _ev.Observers.ToList();
            _ev.Notify();
        }

        public void populateItems()
        {
            flpPlayersEvaluation.Controls.Clear();

            //Event ev = _evaluationController.GetEvent(EventId);

            Park park = _evaluationController.GetEventPark(EventId);

            uc.ParkId = park.ParkId;

            _ev.Attach(park);

            uc.ParkName = park.Name;
            //FALTA DEFINIR A IMAGEM


            foreach (User user in _evaluationController.GetEvaluableUsers(EventId) )
            {
                UC_PlayerEvaluationItem playerEvaluation = new UC_PlayerEvaluationItem();
                playerEvaluation.Username = user.Username;
                
                evaluationItems.Add(playerEvaluation);
                flpPlayersEvaluation.Controls.Add(playerEvaluation);

                _ev.Attach(user);
                _ev.Observers.ToList();  //APAGAR ISTO DEPOIS DE FUNCIONAR
            }

        }

    }
}
