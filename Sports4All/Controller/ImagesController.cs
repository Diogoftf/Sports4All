using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Org.BouncyCastle.Asn1;

namespace Sports4All.Controller
{
    public class ImagesController
    {
        private const int ImagesCount = 4;
        public ICollection<Picture> imgs1 { get; set; } = new Collection<Picture>();
    
        private readonly int PictureId = 23; //ID estático, futuramente para mudar.

        private readonly string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

        //método usado no Seed para inserir as imagens na BD
        public ICollection<Picture> InsertImagetoDB(string PictureType, int number,ICollection<Picture> imgs)
        {
            int PictureId = 1;
            if (PictureType == "Park") PictureId = 5;
            if (PictureType == "Sport") PictureId = 8;
            for (var i = 1; i <= number; i++)
            {
                string path = @"C:\Users\Tiago.Gouveia\Documents\Imagens\" + PictureType + "\\" + PictureType + i + ".png";
               
                string fileName = PictureType + i + ".png";
                var localData = File.ReadAllBytes(path);
                localData.ToString();
                var streamFinal = new MemoryStream(localData);
                streamFinal.Position = 0;
                var result = Convert.ToBase64String(localData);
              
                
                imgs.Add(new Picture(){PictureId = PictureId, PictureBody = result,FileName = fileName });
                imgs1.Add(new Picture() { PictureId = PictureId, PictureBody = result, FileName = fileName });
                PictureId++; 
                //using (var db = new ModelContext())
                //{
                //    var newPicture = new Picture();
                //    newPicture.PictureId = i + 9;
                //    newPicture.PictureBody = result;
                //    db.Pictures.Add(newPicture);
                //    db.SaveChanges();
                //}
            }
            return imgs1;
        }

        //método que guarda na pasta do projeto a imagem passada no PictureId
        public void DownloadImage(int PictureId, string fileName)
        {

            string PictureBody;
            string FolderAndFileName;

            using (var ctx = new ModelContext())
            {
                var Picture = (from s in ctx.Pictures
                    where s.PictureId == PictureId
                    select s).FirstOrDefault();
              PictureBody =  Picture.PictureBody;
            }

            Console.WriteLine("Attachment downloaded.");
            var fileContent = Convert.FromBase64String(PictureBody);
            Stream stream = new MemoryStream(fileContent);

            FolderAndFileName = FormatPictureType(fileName);
            using (var fileStream =
                new FileStream(projectPath + "\\Images\\"+ FolderAndFileName+"\\" + FolderAndFileName + PictureId + ".png", FileMode.OpenOrCreate))
            {
                var fileContent1 = Convert.FromBase64String(PictureBody);
                fileStream.Write(fileContent1, 0, fileContent1.Count());
            }
        }
        public string FormatPictureType(string Filename)
        {
            string result = "";
            if (Filename.Contains("User"))  result = "User";
            if (Filename.Contains("Park"))  result = "Park";
            if (Filename.Contains("Sport")) result = "Sport";

            return result;
        }
    }
}