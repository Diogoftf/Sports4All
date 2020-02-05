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
        public string LoggedUser { get; set; }
        public bool IsExperientUser { get; set; }

        private Session() 
        {
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
