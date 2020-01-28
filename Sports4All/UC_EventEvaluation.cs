using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sports4All.Controller;

namespace Sports4All
{
    public partial class UC_EventEvaluation : UserControl, IUserControl
    {
        private UC_SportsgroundEvItem _uc;
        private ICollection<UC_PlayerEvaluationItem> _evaluationItems;
        private EvaluationController _evaluationController;
        private Event _ev;

        public UC_EventEvaluation()
        {
            InitializeComponent();
            _uc = UC_SportsgroundEvItem1;
            _evaluationItems = new List<UC_PlayerEvaluationItem>();
            _evaluationController = new EvaluationController();
            _ev = new Event();
        }

        #region Properties
        public int EventId { get; set; }
        public string Id { get; set; }
        #endregion

        private void UCEventEvaluation_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            Id = EventId.ToString();
            Populate();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja submeter as avaliações?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                SubmitEvaluations();
                Form1.Instance.BringUcToFront<UC_MyEvents>("UC_MyEvents", Id);
            }
        }

        public void SubmitEvaluations() 
        {
            _evaluationController.SetParkEvaluation(_uc.ParkId, _uc.ParkQuality, _uc.ParkPrice, EventId);

            foreach (var evaluationUser in _evaluationItems)
            {
                _evaluationController.SetUserEvaluation(evaluationUser.Username,
                    evaluationUser.PlayerSkill,
                    evaluationUser.PlayerFairplay,
                    EventId);
            }
            _ev.Notify();
        }

        public void Populate()
        {
            flpPlayersEvaluation.Controls.Clear();

            //Event ev = _evaluationController.GetEvent(EventId);

            Park park = _evaluationController.GetEventPark(EventId);

            _uc.ParkId = park.ParkId;

            _ev.Attach(park);

            _uc.ParkName = park.Name;
            //FALTA DEFINIR A IMAGEM

            foreach (User user in _evaluationController.GetEvaluableUsers(EventId) )
            {
                UC_PlayerEvaluationItem playerEvaluation = new UC_PlayerEvaluationItem();
                playerEvaluation.Username = user.Username;
                _evaluationItems.Add(playerEvaluation);
                flpPlayersEvaluation.Controls.Add(playerEvaluation);

                _ev.Attach(user);
            }

        }
    }
}
