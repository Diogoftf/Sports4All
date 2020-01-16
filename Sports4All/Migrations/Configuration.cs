namespace Sports4All.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sports4All.ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sports4All.ModelContext context)
        {

            ICollection<District> listDistricts = new Collection<District>();

            listDistricts.Add(new District() { DistrictId = 1, Name = "Madeira" });
            listDistricts.Add(new District() { DistrictId = 2, Name = "Açores" });

            ICollection<County> listCounties = new Collection<County>();

            listCounties.Add(new County() { CountyId = 1, DistrictId = 1, Name = "Machico" });
            listCounties.Add(new County() { CountyId = 2, DistrictId = 2, Name = "São Miguel" });
            listCounties.Add(new County() { CountyId = 3, DistrictId = 1, Name = "Funchal" });
            listCounties.Add(new County() { CountyId = 4, DistrictId = 1, Name = "São Vicente" });
            listCounties.Add(new County() { CountyId = 5, DistrictId = 1, Name = "Santa Cruz" });


            // ICollection<Picture> listPictures = new Collection<Picture>();
            //listPictures.Add(new Picture() { PictureId = default, PicdtureBody = "imagemFicticia", User = listUsers.ToList()[0] });
            //Picture test = new Picture() { PictureId = 1, PicdtureBody = "imagemFicticia", User = listUsers.ToList()[0] };

            ICollection<Picture> listPictures = new Collection<Picture>();
            listPictures.Add(new Picture() { PictureId = 1, PictureBody = "Sigaaaaa" });
            listPictures.Add(new Picture() { PictureId = 2, PictureBody = "TESTEEEEEEEEEEEEE" });
            listPictures.Add(new Picture() { PictureId = 3, PictureBody = "VAMOSSSSSSSSSSSSSSSSSSSS" });

             ICollection<User> listUsers = new Collection<User>();
             listUsers.Add(new User() {PictureId = listPictures.First().PictureId, Username = "scarf", Age = 23, Email = "scarf1@gmail.com", Password = "123", PhoneNumber = 963456789, CountyId = 1});

            
            context.Pictures.AddOrUpdate(listPictures.ToList()[0]);
            context.Pictures.AddOrUpdate(listPictures.ToList()[1]);
            context.Pictures.AddOrUpdate(listPictures.ToList()[2]);
            context.Districts.AddOrUpdate(listDistricts.ToList()[0]);
            context.Districts.AddOrUpdate(listDistricts.ToList()[1]);
            context.Counties.AddOrUpdate(listCounties.ToList()[0]);
            context.Users.AddOrUpdate(listUsers.ToList()[0]);
            base.Seed(context);
        }
    }
}
