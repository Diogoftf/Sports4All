using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sports4All.Controller
{
    public class ImagesController
    {
        private const int ImagesCount = 4;
        private IList<string> imgs = new List<string>();
        private readonly int PictureId = 23;//ID estático, futuramente para mudar.
        private readonly string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //método usado no Seed para inserir as imagens na BD
        public IList<string> InsertImagetoDB()
        {
            for (var i = 1; i <= ImagesCount; i++)
            {
                // User Preto
                var localImage = @"C:\Users\Tiago.Gouveia\Documents\Imagens\user" + i + ".png";
                var localData = File.ReadAllBytes(localImage);
                localData.ToString();
                var streamFinal = new MemoryStream(localData);
                streamFinal.Position = 0;
                var result = Convert.ToBase64String(localData);
                imgs.Add(result);

                //using (var db = new ModelContext())
                //{
                //    var newPicture = new Picture();
                //    newPicture.PictureId = i + 9;
                //    newPicture.PictureBody = result;
                //    db.Pictures.Add(newPicture);
                //    db.SaveChanges();
                //}
            }
            return imgs;
        }


        public string GetImagefromDB(string PictureName)
        {
            using (var db = new ModelContext())
            {
                var Picture = db.Pictures.Where(c => c.Path == PictureName).FirstOrDefault().Path;
                return Picture;
            }
        }
    }
}