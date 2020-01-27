using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sports4All.Controller
{
    public class ImagesController
    {
        private readonly string ImagesPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images";

        public void InsertPathImagesToDB()
        {
            DirectoryInfo path = new DirectoryInfo(ImagesPath);

            using(var db = new ModelContext())
            {
                foreach (var file in path.GetFiles())
                {
                    Picture a = new Picture();
                    a.Path = file.Name;
                    db.Pictures.Add(a);
                }
                db.SaveChanges();
            }
        }

        public string GetImageFromID(int id)
        {
            using (var db = new ModelContext())
            {
                var Picture = db.Pictures.Where(c => c.PictureId == id).FirstOrDefault().Path;
                return Picture;
            }
        }

        public string GetImageFromPath(string name)
        {
            using (var db = new ModelContext())
            {
                var Picture = db.Pictures.Where(c => c.Path == name).FirstOrDefault().Path;
                return Picture;
            }
        }
    }
}