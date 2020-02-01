using Sports4All.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    public sealed class Session
    {
        private static Session _instance;
        private EvaluationController _evaluationController;

        public string LoggedUsername { get; set; }

        public User GetLoggedUser { get => _evaluationController.GetUser(LoggedUsername); }

        private Session() 
        {
            _evaluationController = new EvaluationController();
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
