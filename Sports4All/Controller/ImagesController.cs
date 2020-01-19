﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sports4All.Controller
{
    public class ImagesController
    {
        private const int ImagesCount = 4;
        private IList<string> imgs = new List<string>();
        private readonly int PictureId = 23; //ID estático, futuramente para mudar.

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