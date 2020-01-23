using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    class RankController
    {
        public ICollection<UserClassification> getTopUsers()
        {

            using (var db = new ModelContext())
            {
                return db.Classifications.Include("User.Events").OfType<UserClassification>().Where(c => c.Points > 0).OrderByDescending(c => c.Points).ToList();
            }

        }

        public ICollection<ParkClassification> getTopRecintos()
        {
            using (var db = new ModelContext())
            {
                return db.Classifications.Include("Park.Grounds.Reserves").OfType<ParkClassification>().Where(e => e.Points > 0).OrderByDescending(e => e.Points).ToList();

            }

        }

        public void UserPointsCalculator()
        {
            using (ModelContext db = new ModelContext())
            {
                var myStats = db.Users.ToList(); // Classificação de todos os users
                var auxReservesPerformed = 0;
                var auxFairplayResult = 0;
                var auxSkillResult = 0;
                var auxEventsPerfomed = 0;
                var auxRacio = 0;
                var auxPoints = 0;

                for (int i = 0; i < myStats.Count; i++) // percorro todos os users que possuem pontos > 0
                {
                    auxEventsPerfomed = myStats[i].Events.Count; // total de partidas de cada user
                    auxReservesPerformed = myStats[i].Reserves.Count;
                    var auxUser = myStats[i].Username;
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

                    auxPoints = auxFairplayResult * Points._fairplay_Weight + auxSkillResult * Points._skill_Weight +
                    auxEventsPerfomed * Points._eventPerformed_Weight +
                    auxReservesPerformed * Points._reservePerformed_Weight + auxRacio * Points._racio_Weight;

                    if (auxPoints != myStats[i].UserClassification.Points) // se os pontos calculados estiverem diferentes dos pontos da BD
                    {
                        myStats[i].UserClassification.Points = auxPoints;
                        myStats[i].UserClassification.Ratio = auxRacio;
                        myStats[i].UserClassification.SkillAverage = auxSkillResult;
                        myStats[i].UserClassification.FairplayAverage = auxFairplayResult;
                        db.SaveChanges();
                    }
                }

            }
        }

        public void ParkPointsCalculator()
        {
            using (ModelContext db = new ModelContext())
            {
                var myStats = db.Parks.Include("Grounds").ToList(); // Classificação de todos os users
                var auxReservesPerformed = 0;
                var auxPriceResult = 0;
                var auxQualityResult = 0;
                var auxRacio = 0;
                var auxPoints = 0;

                for (int i = 0; i < myStats.Count; i++) // percorro todos os users que possuem pontos > 0
                {
                    foreach (Ground a in myStats[i].Grounds)
                    {
                        if(a.Reserves != null)
                            auxReservesPerformed = a.Reserves.Count;
                    }

                    var auxParkName = myStats[i].Name;
                    var parkEvaluations = db.Evaluations.Include("Park").OfType<ParkEvaluation>().Where(e => e.Park.Name == auxParkName).ToList(); // se esse user ja foi avaliado alguma vez...

                    if (parkEvaluations.Count > 0)
                    {
                        for (int j = 0; j < parkEvaluations.Count; j++)
                        {
                            auxPriceResult += parkEvaluations[j].Price; //total de fairplay de cada user
                            auxQualityResult += parkEvaluations[j].Quality;  //total de skill de cada user
                        }

                        auxPriceResult /= parkEvaluations.Count;
                        auxQualityResult /= parkEvaluations.Count;
                        auxRacio = auxPriceResult / auxQualityResult;

                    }
                    else
                    {
                        auxPriceResult = auxQualityResult = auxRacio = auxPoints = 0;
                    }

                    auxPoints = auxPriceResult * Points._ParkPrice_Weight + auxQualityResult * Points._ParkQuality_Weight +
                    auxReservesPerformed * Points._reservePerformed_Weight +
                    auxRacio * Points._racio_Weight;

                    if (auxPoints != myStats[i].ParkClassification.Points) // se os pontos calculados estiverem diferentes dos pontos da BD
                    {
                        myStats[i].ParkClassification.Points = auxPoints;
                        myStats[i].ParkClassification.Ratio = auxRacio;
                        myStats[i].ParkClassification.PriceAverage = auxPriceResult;
                        myStats[i].ParkClassification.QualityAverage = auxQualityResult; 
                        db.SaveChanges();
                    }
                }

            }
        }

    }
}
