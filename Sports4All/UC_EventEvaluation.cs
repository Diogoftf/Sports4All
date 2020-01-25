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
            _evaluationController.SetParkEvaluation(uc.ParkId, uc.ParkQuality, uc.ParkPrice, EventId);

            foreach (var evaluationUser in evaluationItems)
            {
                _evaluationController.SetUserEvaluation(evaluationUser.Username,
                    evaluationUser.PlayerSkill,
                    evaluationUser.PlayerFairplay,
                    EventId);
            }
        }

        public void populateItems()
        {
            flpPlayersEvaluation.Controls.Clear();

            Park park = _evaluationController.GetEventPark(EventId);

            uc.ParkName = park.Name;
            //FALTA DEFINIR A IMAGEM


            foreach (User user in _evaluationController.GetEvaluableUsers(EventId) )
            {
                UC_PlayerEvaluationItem playerEvaluation = new UC_PlayerEvaluationItem();
                playerEvaluation.Username = user.Username;
                
                evaluationItems.Add(playerEvaluation);
                flpPlayersEvaluation.Controls.Add(playerEvaluation);
            }

        }
    }
}
