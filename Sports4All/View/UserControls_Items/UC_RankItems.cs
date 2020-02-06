using System.Windows.Forms;

namespace Sports4All
{
    public partial class UC_RankItems : UserControl
    {
        #region Properties
        private string _classification;
        private string _user;
        private string _playedGames;
        private string _points;

        public string Classification 
        {
            get { return _classification; }
            set { _classification = value; lbUserRank.Text = value; }

        }

        public string User 
        {
            get { return _user; }
            set { _user = value; lblUsername.Text = value; }

        }

        public string GamesPlayed
        {
            get { return _playedGames; }
            set { _playedGames = value; lblGamesPlayed.Text = value; }

        }

        public string Points
        {
            get { return _points; }
            set { _points = value; lblPoints.Text = value; }

        }
        #endregion

        public UC_RankItems()
        {
            InitializeComponent();
        }
    }
}
