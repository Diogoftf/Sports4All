using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
                double auxFairplayResult = 0;
                double auxSkillResult = 0;
                double auxEventsPerfomed = 0;
                double auxRacio = 0;
                double auxPoints = 0;

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

                    //if (auxPoints != myStats[i].UserClassification.Points) // se os pontos calculados estiverem diferentes dos pontos da BD
                    {
                        myStats[i].UserClassification.Points = Math.Round(auxPoints,2);
                        myStats[i].UserClassification.Ratio = Math.Round(auxRacio,2);
                        myStats[i].UserClassification.SkillAverage = Math.Round(auxSkillResult,2);
                        myStats[i].UserClassification.FairplayAverage = Math.Round(auxFairplayResult,2);
                        db.SaveChanges();
                    }
                }

            }
        }

        //public void ParkPointsCalculator()
        //{
        //    using (ModelContext db = new ModelContext())
        //    {
        //        var myStats = db.Parks.Include("Grounds").ToList(); // Classificação de todos os users
        //        var auxReservesPerformed = 0;
        //        double auxPriceResult = 0;
        //        double auxQualityResult = 0;
        //        double auxRacio = 0;
        //        double auxPoints = 0;

        //        for (int i = 0; i < myStats.Count; i++) // percorro todos os users que possuem pontos > 0
        //        {
        //            foreach (Ground a in myStats[i].Grounds)
        //            {
        //                if(a.Reserves != null)
        //                    auxReservesPerformed = a.Reserves.Count;
        //            }

        //            var auxParkName = myStats[i].Name;
        //            var parkEvaluations = db.Evaluations.Include("Park").OfType<ParkEvaluation>().Where(e => e.Park.Name == auxParkName).ToList(); // se esse user ja foi avaliado alguma vez...

        //            if (parkEvaluations.Count > 0)
        //            {
        //                for (int j = 0; j < parkEvaluations.Count; j++)
        //                {
        //                    auxPriceResult += parkEvaluations[j].Price; //total de fairplay de cada user
        //                    auxQualityResult += parkEvaluations[j].Quality;  //total de skill de cada user
        //                }

        //                auxPriceResult /= parkEvaluations.Count;
        //                auxQualityResult /= parkEvaluations.Count;
        //                auxRacio = auxPriceResult / auxQualityResult;

        //            }
        //            else
        //            {
        //                auxPriceResult = auxQualityResult = auxRacio = auxPoints = 0;
        //            }

        //            auxPoints = auxPriceResult * Points._ParkPrice_Weight + auxQualityResult * Points._ParkQuality_Weight +
        //            auxReservesPerformed * Points._reservePerformed_Weight +
        //            auxRacio * Points._racio_Weight;

        //            if (auxPoints != myStats[i].ParkClassification.Points) // se os pontos calculados estiverem diferentes dos pontos da BD
        //            {
        //                myStats[i].ParkClassification.Points = Math.Round(auxPoints,2);
        //                myStats[i].ParkClassification.Ratio = Math.Round(auxRacio,2);
        //                myStats[i].ParkClassification.PriceAverage = Math.Round(auxPriceResult,2);
        //                myStats[i].ParkClassification.QualityAverage = Math.Round(auxQualityResult,2); 
        //                db.SaveChanges();
        //            }
        //        }

        //    }
        //}

        public void UpdateParkClassification(int parkId)
        {
            using (var db = new ModelContext())
            {
                ICollection<ParkEvaluation> parkEvaluations = GetParkEvaluations(parkId);

                double avgPrice = GetParkPriceAvg(parkEvaluations);
                double avgQuality = GetParkQualityAvg(parkEvaluations);


                var parkClassification = db.Classifications.Include("Park").OfType<ParkClassification>()
                    .FirstOrDefault(x => x.Park.ParkId == parkId);

                parkClassification.PriceAverage = Math.Round(avgPrice, 2);
                parkClassification.QualityAverage = Math.Round(avgQuality, 2);

                db.SaveChanges();
            }
        }

        public ICollection<ParkEvaluation> GetParkEvaluations(int parkId)
        {
            using (var db = new ModelContext())
            {
                List<ParkEvaluation> parkEvaluations = new List<ParkEvaluation>();

                var evaluations = db.Evaluations.OfType<ParkEvaluation>().ToList();

                foreach (var evaluation in evaluations)
                {
                    if (evaluation.ParkId == parkId)
                    {
                        parkEvaluations.Add(evaluation);
                    }
                }

                return parkEvaluations;

            }
        }

        public double GetParkQualityAvg(ICollection<ParkEvaluation> parkEvaluations)
        {
            int qualitySum = 0;

            foreach (var evaluation in parkEvaluations)
            {
                qualitySum += evaluation.Quality;
            }

            double avgQuality = qualitySum / parkEvaluations.Count();

            avgQuality = Math.Round(avgQuality, 2);

            return avgQuality;
        }

        public double GetParkPriceAvg(ICollection<ParkEvaluation> parkEvaluations)
        {
            int priceSum = 0;

            foreach (var evaluation in parkEvaluations)
            {
                priceSum += evaluation.Price;
            }

            double avgPrice = priceSum / parkEvaluations.Count();

            avgPrice = Math.Round(avgPrice, 2);

            return avgPrice;
        }

    }
}
