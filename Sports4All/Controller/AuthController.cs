using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sports4All.Controller
{
    public class AuthController
    {
        private readonly ICollection<County> listCounties = new Collection<County>();

        public void RegisterUser(string email, string password, string username, string age, string cellphone,
            int pictureId, string county)
        {
            using (var db = new ModelContext())
            {
                var newUser = new User
                {
                    Email = email,
                    Password = password,
                    Username = username,
                    Age = Convert.ToInt32(age),
                    PhoneNumber = Convert.ToInt32(cellphone),
                    PictureId = pictureId
                };

                var query = db.Counties.Where(f => f.Name.Equals(county)).First();
                newUser.CountyId = query.CountyId;

                UserClassification userClassification = CreateUserClassification(newUser);

                db.Users.Add(newUser);
                db.Classifications.Add(userClassification);
                db.SaveChanges();
            }
        }

        public UserClassification CreateUserClassification(User user)
        {
            using (var db = new ModelContext())
            {
                var query = db.Classifications;
                int classificationId = 0;

                if (query.Any())
                {
                    var biggestClassificationId = query.OrderByDescending(u => u.ClassificationId).FirstOrDefault().ClassificationId;
                    classificationId = biggestClassificationId + 1;
                }

                UserClassification userClassification = new UserClassification
                {
                    ClassificationId = classificationId,
                    User = user,
                    Points = 0,
                    Ratio = 0,
                    SkillAverage = 0,
                    FairplayAverage = 0
                };

                return userClassification;
            }

        }
        public bool EmailExists(string email)
        {
            using (var db = new ModelContext())
            {
                var query = from u in db.Users
                    select u;

                foreach (var item in query)
                    if (item.Email.Equals(email))
                        return true;
            }

            return false;
        }

        public bool UsernameExists(string username)
        {
            using (var db = new ModelContext())
            {
                var query = from u in db.Users
                    select u;

                foreach (var item in query)
                    if (item.Username.Equals(username))
                        return true;
            }

            return false;
        }

        public bool RightLoginCredentials(string email, string password)
        {
            using (var db = new ModelContext())
            {
                var query = from u in db.Users
                    select u;

                foreach (var item in query)
                    if (item.Email.Equals(email))
                        if (item.Password.Equals(password))
                            return true;
            }

            return false;
        }

        public string GetUsername(string email)
        {
            using (var db = new ModelContext())
            {
                var username = db.Users.FirstOrDefault(x => x.Email.Equals(email)).Username;

                return username;
            }

        }

        public ICollection<County> RetrieveCounties()
        {
            using (var db = new ModelContext())
            {
                var counties = db.Counties.ToList();

                foreach (var ct in counties) listCounties.Add(ct);

                return listCounties;
            }
        }
    }
}