using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Sports4All.Controller
{
    public sealed class ImagesController
    {
        private static ImagesController _instance;

        private static readonly string ImagesPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images";

        private ImagesController() { }

        public static ImagesController Instance
        {
            get
            {
                if (_instance == null) { _instance = new ImagesController(); }

                return _instance;
            }
        }

        public Image GetImageFromID(int id)
        {
            using (var db = new ModelContext())
            {
                var Picture = db.Pictures.Where(c => c.PictureId == id).FirstOrDefault().Path;
                return Image.FromFile(ImagesPath + "\\" + Picture + ".png");
            }
        }

        public Image GetImageFromName(string name)
        {
            using (var db = new ModelContext())
            {
                var pictures = db.Pictures.Where( e => e.Path == name).SingleOrDefault().Path;
                return Image.FromFile(ImagesPath + "\\" + pictures + ".png");
            }
        }

    }
}