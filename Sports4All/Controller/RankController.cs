using System;
using System.Collections.Generic;
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

        internal void UpdateUserClassification(string username)
        {
            using (var db = new ModelContext())
            {
                ICollection<UserEvaluation> userEvaluations = GetUserEvaluations(username);

                double avgFairPlay = GetUseFairPlayAvg(userEvaluations);
                double avgSkill = GetUserSkillAvg(userEvaluations);
                double avgRatio = GetUserRatio(username);
                double Points = GetUserPoints(username);

                var userClassification = db.Classifications.Include("User").OfType<UserClassification>()
                    .FirstOrDefault(x => x.User.Username.Equals(username));

                userClassification.FairplayAverage = Math.Round(avgFairPlay, 2);
                userClassification.SkillAverage = Math.Round(avgSkill, 2);
                userClassification.Ratio = Math.Round(avgRatio, 2);
                userClassification.Points = Math.Round(Points, 2);

                db.SaveChanges();
            }
        }

        public double GetUserPoints(string username)
        {
            ICollection<UserEvaluation> userEvaluations = GetUserEvaluations(username);

            double avgFairPlay = GetUseFairPlayAvg(userEvaluations);
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

            double avgPoints = avgFairPlay * this._fairplay_Weight + avgSkill * this._skill_Weight +
                avgRatio * this._ratio_Weight + eventsPerformed * this._eventPerformed_Weight +
                reservsPerformed * this._reservePerformed_Weight;

            avgPoints = Math.Round(avgPoints, 2);

            return avgPoints;
        }

        public double GetUserRatio(string username)
        {
            ICollection<UserEvaluation> userEvaluations = GetUserEvaluations(username);

            double avgFairPlay = GetUseFairPlayAvg(userEvaluations);
            double avgSkill = GetUserSkillAvg(userEvaluations);

            double avgRatio = avgFairPlay / avgSkill;

            avgRatio = Math.Round(avgRatio, 2);

            return avgRatio;
        }

        private double GetUserSkillAvg(ICollection<UserEvaluation> userEvaluations)
        {
            int skillSum = 0;

            foreach (var evaluation in userEvaluations)
            {
                skillSum += evaluation.Skill;
            }

            double avgSkill = skillSum / userEvaluations.Count();

            avgSkill = this._skill_Weight;

            avgSkill = Math.Round(avgSkill, 2);

            return avgSkill;
        }

        private double GetUseFairPlayAvg(ICollection<UserEvaluation> userEvaluations)
        {
            int fairPlaySum = 0;

            foreach (var evaluation in userEvaluations)
            {
                fairPlaySum += evaluation.FairPlay;
            }

            double avgFairPlay = fairPlaySum / userEvaluations.Count();

            avgFairPlay *= this._fairplay_Weight;

            avgFairPlay = Math.Round(avgFairPlay, 2);

            return avgFairPlay;
        }

        private ICollection<UserEvaluation> GetUserEvaluations(string username)
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

                parkClassification.PriceAverage = Math.Round(avgPrice, 2);
                parkClassification.QualityAverage = Math.Round(avgQuality, 2);
                parkClassification.Points = Math.Round(Points, 2);
                parkClassification.Ratio = Math.Round(avgRatio, 2);

                db.SaveChanges();
            }
        }

        public double GetParkRatio(int parkId)
        {
            ICollection<ParkEvaluation> parkEvaluations = GetParkEvaluations(parkId);

            double avgPrice = GetParkPriceAvg(parkEvaluations);
            double avgQuality = GetParkQualityAvg(parkEvaluations);
            double avgRatio = avgQuality / avgPrice;

            avgRatio = Math.Round(avgRatio, 2);

            return avgRatio;
        }

        public double GetParkPoints(int parkId)
        {
            ICollection<ParkEvaluation> parkEvaluations = GetParkEvaluations(parkId);

            double avgPrice = GetParkPriceAvg(parkEvaluations);
            double avgQuality = GetParkQualityAvg(parkEvaluations);
            double avgRatio = GetParkRatio(parkId);
            double reservesPerformed = 0;
            using(var db = new ModelContext())
            {
                var query = db.Parks.Include("Grounds.Reserves").Where(e => e.ParkId == parkId).FirstOrDefault();
                
                foreach(Ground a in query.Grounds)
                {
                    reservesPerformed += a.Reserves.Count();
                }
            }

            double points = avgPrice * this._ParkPrice_Weight + avgQuality * this._ParkQuality_Weight +
                        reservesPerformed * this._reservePerformed_Weight +
                        avgRatio * this._ratio_Weight;

            points = Math.Round(points, 2);

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
            int qualitySum = 0;

            foreach (var evaluation in parkEvaluations)
            {
                qualitySum += evaluation.Quality;
            }

            double avgQuality = qualitySum / parkEvaluations.Count();

            avgQuality *= this._ParkQuality_Weight;

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

            avgPrice *= this._ParkPrice_Weight;

            avgPrice = Math.Round(avgPrice, 2);

            return avgPrice;
        }

    }
}
