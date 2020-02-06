using Sports4All.Controller;

namespace Sports4All
{
    public sealed class Session
    {
        private static Session _instance;
        private EvaluationController _evaluationController;

        public string LoggedUser { get; set; }

        public User GetLoggedUser { get => _evaluationController.GetUser(LoggedUser); }

        public bool IsExperientUser { get; set; }

        private Session() 
        {
            _evaluationController = new EvaluationController();
            IsExperientUser = false;
        }

        public static Session Instance
        {
            get
            {
                if (_instance == null) { _instance = new Session(); }

                return _instance;
            }
        }
    }
}
