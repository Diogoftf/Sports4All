using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sports4All.Controller
{
    class RankController
    {
        public readonly double _eventPerformed_Weight = 3;
        public readonly double _reservePerformed_Weight = 2;
        public readonly double _fairplay_Weight = 4;
        public readonly double _skill_Weight = 3;
        public readonly double _ratio_Weight = 2;
        public readonly double _levelChange = 100;
        public readonly double _ParkPrice_Weight = 3;
        public readonly double _ParkQuality_Weight = 4;

        public ICollection<UserClassification> GetTopUsers()
        {

            using (var db = new ModelContext())
            {
                return db.Classifications.Include("User.Events").OfType<UserClassification>().Where(c => c.Points > 0).OrderByDescending(c => c.Points).ToList();
            }

        }
        public ICollection<ParkClassification> GetTopGrounds()
        {
            using (var db = new ModelContext())
            {
                return db.Classifications.Include("Park.Grounds.Reserves").OfType<ParkClassification>().Where(e => e.Points > 0).OrderByDescending(e => e.Points).ToList();

            }

        }

        internal void UpdateUserClassification(string username)
        {
            using (var db = new ModelContext())
            {
                ICollection<UserEvaluation> userEvaluations = GetUserEvaluations(username);

                double avgFairPlay = GetUserFairPlayAvg(userEvaluations);
                double avgSkill = GetUserSkillAvg(userEvaluations);
                double avgRatio = GetUserRatio(username);
                double Points = GetUserPoints(username);

                var userClassification = db.Classifications.Include("User").OfType<UserClassification>()
                    .FirstOrDefault(x => x.User.Username.Equals(username));

                userClassification.FairplayAverage = avgFairPlay;
                userClassification.SkillAverage = avgSkill;
                userClassification.Ratio = avgRatio;
                userClassification.Points = Points;

                db.SaveChanges();
            }
        }

        public double GetUserPoints(string username)
        {
            ICollection<UserEvaluation> userEvaluations = GetUserEvaluations(username);

            double avgFairPlay = GetUserFairPlayAvg(userEvaluations);
            double avgSkill = GetUserSkillAvg(userEvaluations);
            double avgRatio = GetUserRatio(username);
            double eventsPerformed = 0;
            double reservsPerformed = 0;

            using (var db = new ModelContext())
            {
                var query = db.Users.Where(e => e.Username == username).FirstOrDefault();

                eventsPerformed = query.Events.Count;
                reservsPerformed = query.Reserves.Count;
            }

            double avgPoints = avgFairPlay * _fairplay_Weight
                + avgSkill * _skill_Weight
                + avgRatio * _ratio_Weight
                + eventsPerformed * _eventPerformed_Weight
                + reservsPerformed * _reservePerformed_Weight;

            return avgPoints;
        }

        public double GetUserRatio(string username)
        {
            double avgRatio = 0;
            ICollection <UserEvaluation> userEvaluations = GetUserEvaluations(username);

            double avgFairPlay = GetUserFairPlayAvg(userEvaluations);
            double avgSkill = GetUserSkillAvg(userEvaluations);

            if (userEvaluations.Any())
            {
                avgRatio = avgFairPlay / avgSkill;
            }
            
            return avgRatio;
        }

        public double GetUserSkillAvg(ICollection<UserEvaluation> userEvaluations)
        {
            double avgSkill = 0;
            double skillSum = 0;

            foreach (var evaluation in userEvaluations)
            {
                skillSum += evaluation.Skill;
            }

            if (userEvaluations.Any())
            {
                avgSkill = skillSum / userEvaluations.Count();
            }

            return avgSkill;
        }

        public double GetUserFairPlayAvg(ICollection<UserEvaluation> userEvaluations)
        {
            double avgFairPlay = 0;
            double fairPlaySum = 0;

            foreach (var evaluation in userEvaluations)
            {
                fairPlaySum += evaluation.FairPlay;
            }
            
            if(userEvaluations.Any())
            {
                avgFairPlay = fairPlaySum / userEvaluations.Count();
            }

            return avgFairPlay;
        }

        public ICollection<UserEvaluation> GetUserEvaluations(string username)
        {
            using (var db = new ModelContext())
            {
                List<UserEvaluation> userEvaluations = new List<UserEvaluation>();

                var evaluations = db.Evaluations.OfType<UserEvaluation>().ToList();

                foreach (var evaluation in evaluations)
                {
                    if (evaluation.UserId.Equals(username))
                    {
                        userEvaluations.Add(evaluation);
                    }
                }
                return userEvaluations;
            }
        }

        public void UpdateParkClassification(int parkId)
        {
            using (var db = new ModelContext())
            {
                ICollection<ParkEvaluation> parkEvaluations = GetParkEvaluations(parkId);

                double avgPrice = GetParkPriceAvg(parkEvaluations);
                double avgQuality = GetParkQualityAvg(parkEvaluations);
                double avgRatio = GetParkRatio(parkId);
                double Points = GetParkPoints(parkId);

                var parkClassification = db.Classifications.Include("Park").OfType<ParkClassification>()
                    .FirstOrDefault(x => x.Park.ParkId == parkId);

                parkClassification.PriceAverage = avgPrice;
                parkClassification.QualityAverage = avgQuality;
                parkClassification.Points = Points;
                parkClassification.Ratio = avgRatio;

                db.SaveChanges();
            }
        }

        public double GetParkRatio(int parkId)
        {
            ICollection<ParkEvaluation> parkEvaluations = GetParkEvaluations(parkId);

            double avgPrice = GetParkPriceAvg(parkEvaluations);
            double avgQuality = GetParkQualityAvg(parkEvaluations);
            double avgRatio = avgQuality / avgPrice;

            return avgRatio;
        }

        public double GetParkPoints(int parkId)
        {
            ICollection<ParkEvaluation> parkEvaluations = GetParkEvaluations(parkId);

            double avgPrice = GetParkPriceAvg(parkEvaluations);
            double avgQuality = GetParkQualityAvg(parkEvaluations);
            double avgRatio = GetParkRatio(parkId);
            double reservesPerformed = 0;
            using (var db = new ModelContext())
            {
                var query = db.Parks.Where(e => e.ParkId == parkId).Include("Grounds.Reserves").FirstOrDefault();

                foreach (Ground a in query.Grounds)
                {
                    if (a.Reserves != null) { reservesPerformed += a.Reserves.Count(); };
                }
            }

            double points = (avgPrice * _ParkPrice_Weight)
                + (avgQuality * _ParkQuality_Weight)
                + (reservesPerformed * _reservePerformed_Weight)
                + (avgRatio * _ratio_Weight);

            return points;
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
            double qualitySum = 0;

            foreach (var evaluation in parkEvaluations)
            {
                qualitySum += evaluation.Quality;
            }

            double avgQuality = qualitySum / parkEvaluations.Count();

            return avgQuality;
        }

        public double GetParkPriceAvg(ICollection<ParkEvaluation> parkEvaluations)
        {
            double priceSum = 0;

            foreach (var evaluation in parkEvaluations)
            {
                priceSum += evaluation.Price;
            }

            double avgPrice = priceSum / parkEvaluations.Count();

            return avgPrice;
        }

    }
}
