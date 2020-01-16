using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports4All
{
    class RankController
    {
        public void getUsersTop10(string email, string password, string username, string age, string cellphone)
        {
            using (var db = new ModelContext())
            {

                var query = db.Users.ToList();

                var newUser = new User();
                newUser.Email = email;
                newUser.Password = password;
                newUser.Username = username;
                newUser.Age = Convert.ToInt32(age);
                newUser.PhoneNumber = Convert.ToInt32(cellphone);
                //newUser.Picture = _selectedPicture;

                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }
    }
}
