using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class HomeController
    {
        public ICollection<Sport> getSports()
        {
            using (ModelContext db = new ModelContext())
            {
                return db.Sports.ToList();
            }

        }

        public ICollection<string> getMyStats(string username)
        {
            ICollection<string> userStats = new List<string>();
            
            using (ModelContext db = new ModelContext())
            {
                var myStats = db.Classifications.Where(e => e.userId.Username == AuthProperties.LoggedUser).First();

                userStats.Add(myStats.userId.Events.Count.ToString());
                userStats.Add(myStats.fairplayAverage.ToString());
                userStats.Add(myStats.skillAverage.ToString());
                userStats.Add(myStats.racio.ToString());
                userStats.Add(myStats.points.ToString());

                return userStats;
            }
        }

        /**
         * 
         * Método que calcula as pontuações de todos os utilizadores
         */
        public void pointsCalculator()
        {
            using (ModelContext db = new ModelContext())
            {
                var myStats = db.Classifications.Where(e => e.points > 0).ToList(); // Classificação de todos os users
                var auxReservesPerformed = 0;
                var auxFairplayResult = 0;
                var auxSkillResult = 0;
                var auxEventsPerfomed = 0;
                var auxRacio = 0;
                var auxPoints = 0;

                for (int i = 0; i < myStats.Count; i++) // percorro todos os users que possuem pontos > 0
                {
                    auxEventsPerfomed = myStats[i].userId.Events.Count; // total de partidas de cada user
                    auxReservesPerformed = myStats[i].userId.Reserves.Count;
                    var auxUser = myStats[i].userId.Username;
                    var userEvaluations = db.Evaluations.OfType<UserEvaluation>().Where(e => e.Evaluated.Username == auxUser).ToList(); // se esse user ja foi avaliado alguma vez...

                    // Se esse user ja foi avaliado alguma vez....
                    if (userEvaluations.Count > 0)
                    {
                        for (int j = 0; j < userEvaluations.Count; j++)
                        {
                            auxFairplayResult += userEvaluations[j].FairPlay; //total de fairplay de cada user
                            auxSkillResult += userEvaluations[j].Skill;  //total de skill de cada user
                        }

                        auxFairplayResult /= userEvaluations.Count;
                        auxSkillResult /= userEvaluations.Count;
                        auxRacio = auxFairplayResult / auxSkillResult;

                    }
                    else
                    {
                        auxFairplayResult = auxSkillResult = auxRacio = 0;
                    }

                    auxPoints = auxFairplayResult * Points._fairplay_Height + auxSkillResult * Points._skill_Height +
                    auxEventsPerfomed * Points._eventPerformed_Height +
                    auxReservesPerformed * Points._reservePerformed_Height + auxRacio * Points._racio_Height;

                    if (auxPoints != myStats[i].points) // se os pontos atuais estiverem diferentes dos pontos da BD entao algo mudou
                    {
                        myStats[i].points = auxPoints;
                        myStats[i].racio = auxRacio;
                        myStats[i].skillAverage = auxSkillResult;
                        myStats[i].fairplayAverage = auxFairplayResult;
                        db.SaveChanges();
                    }
                }

                myStats = db.Classifications.Where(e => e.points > 0).OrderByDescending(e => e.points).ToList(); // volto a pegar nos users todos e agora vou estabelecer a ordem das classificações

                for (int i = 0; i < myStats.Count; i++)
                {
                    myStats[i].rankClassification = i + 1;
                }
                db.SaveChanges();


            }

        }

        public ICollection<Reserve> getEventSuggestions(string username)
        {
            //events -> todos os eventos que o user participou
            // reservs -> todos os eventos que o user criou

            using (ModelContext db = new ModelContext())
            {

                // Query para dar Sugestões            
                return db.Reserves.Include("User").Include("Ground.Park").Include("Sport").Where(e => e.User.Username != username && e.Event.StartDate > DateTime.Now && (e.Event.Users.Count) < e.Event.MaxPlayers
                    && (e.Ground.Park.Adress.CountyId == e.User.CountyId || e.Ground.Park.Adress.County.DistrictId == e.User.County.DistrictId
                     && e.Event.Users.Contains(e.User) == false)).ToList();
            }

        }

        public ICollection<Event> getMyEvents(string username)
        {
            ICollection<Event> myEvents = new List<Event>();

            using (ModelContext db = new ModelContext())
            {
                var teste = db.Reserves.Include("Ground.Park").Include("Sport").Where(c => c.Event.StartDate > DateTime.Now).ToList();
                var whoIam = db.Users.Where(e => e.Username == username).First();

                foreach (Reserve a in teste) // todos os eventos que esse user participou (Tanto os que esta inscrito, como reservou)
                 {
                    if(a.Event.Users.Contains(whoIam)) 
                        myEvents.Add(a.Event); //guardo o evento dessa reserva
                 }
            }

            return myEvents;
            
        }
    }
}
