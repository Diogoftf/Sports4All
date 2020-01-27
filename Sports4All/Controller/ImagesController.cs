using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Sports4All.Controller
{
    public static class ImagesController
    {
        private static readonly string ImagesPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images";

        //public static void InsertPathImagesToDB()
        //{
        //    DirectoryInfo path = new DirectoryInfo(ImagesPath);

        //    using (var db = new ModelContext())
        //    {
        //        foreach (var file in path.GetFiles())
        //        {
        //            Picture a = new Picture();
        //            a.Path = file.Name;
        //            db.Pictures.Add(a);
        //        }
        //        db.SaveChanges();
        //    }
        //}

        public static Image GetImageFromID(int id)
        {
            using (var db = new ModelContext())
            {
                var Picture = db.Pictures.Where(c => c.PictureId == id).FirstOrDefault().Path;
                return Image.FromFile(ImagesPath + "\\" + Picture + ".png");
            }
        }

        public static Image GetImageFromName(string name)
        {
            using (var db = new ModelContext())
            {
                var pictures = db.Pictures.Where( e => e.Path == name).SingleOrDefault().Path;
                return Image.FromFile(ImagesPath + "\\" + pictures + ".png");
            }
        }

    }
}