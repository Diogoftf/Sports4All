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
                var newUser = new User();
                newUser.Email = email;
                newUser.Password = password;
                newUser.Username = username;
                newUser.Age = Convert.ToInt32(age);
                newUser.PhoneNumber = Convert.ToInt32(cellphone);
                newUser.PictureId = pictureId;

                var query = db.Counties.Where(f => f.Name == county).First();
                newUser.CountyId = query.CountyId;

                db.Users.Add(newUser);
                db.SaveChanges();
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