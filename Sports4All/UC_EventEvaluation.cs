using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Sports4All.Controller;
using Sports4All.Patterns.Observer;

namespace Sports4All
{
    public partial class UC_EventEvaluation : UserControl, IUserControl
    {
        private EvaluationController _evaluationController;
        private ICollection<UC_PlayerEvaluationItem> _evaluationItems;
        private ParkEvaluation _parkEvaluation;
        private ParkEvaluationObservable _parkEvaluationObservable;
        private RankController _rankController;
        private UC_SportsgroundEvItem _uc;
        private UserEvaluation _userEvaluation;
        private UserEvaluationObservable _userEvaluationObservable;

        public UC_EventEvaluation()
        {
            InitializeComponent();
            _uc = UC_SportsgroundEvItem1;
            _evaluationItems = new List<UC_PlayerEvaluationItem>();
            _evaluationController = new EvaluationController();
            _rankController = new RankController();
            _parkEvaluation = new ParkEvaluation();
            _userEvaluation = new UserEvaluation();
            _parkEvaluationObservable = new ParkEvaluationObservable(_parkEvaluation);
            _userEvaluationObservable = new UserEvaluationObservable(_userEvaluation);
        }

        #region Properties
        public int EventId { get; set; }
        public string Id { get; set; }
        #endregion

        public void Populate()
        {
            flpPlayersEvaluation.Controls.Clear();
            gpEventEvaluation.Text = _evaluationController.GetEvent(EventId).Name;
            Park park = _evaluationController.GetEventPark(EventId);
            _uc.ParkId = park.ParkId;
            _uc.ParkName = park.Name;
            _uc.Image = ImagesController.Instance.GetImageFromID(park.Picture.PictureId);

            _parkEvaluationObservable.OnUpdate += (o, d) => _rankController.UpdateParkClassification(park.ParkId);


            foreach (var user in _evaluationController.GetEvaluableUsers(EventId))
            {
                UC_PlayerEvaluationItem _playerEvaluation = new UC_PlayerEvaluationItem
                {
                    Username = user.Username,
                    Image = ImagesController.Instance.GetImageFromID(user.PictureId)
                };

                _evaluationItems.Add(_playerEvaluation);
                flpPlayersEvaluation.Controls.Add(_playerEvaluation);
                _userEvaluationObservable.OnUpdate += (o, d) => _rankController.UpdateUserClassification(user.Username);
            }

        }

        public void SubmitEvaluations()
        {

            _evaluationController.SetParkEvaluation(_uc.ParkId, _uc.ParkQuality, _uc.ParkPrice, EventId);
            _parkEvaluationObservable.UpdateClassification();

            foreach (var evaluationUser in _evaluationItems)
            {
                _evaluationController.SetUserEvaluation(evaluationUser.Username,
                    evaluationUser.PlayerSkill,
                    evaluationUser.PlayerFairplay,
                    EventId);
            }
            _userEvaluationObservable.UpdateClassification();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja submeter as avaliações?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SubmitEvaluations();
                Form1.Instance.BringUcToFront<UC_MyEvents>("UC_MyEvents", Id);
            }
        }

        private void UCEventEvaluation_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            EventId = Convert.ToInt32(Id);
            Populate();
        }
    }
}
