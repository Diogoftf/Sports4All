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

            ICollection<Sport> listSports = new Collection<Sport>();
            listSports.Add(new Sport() { SportId = 1, Name = "Futebol", Picture = listPictures.ToList()[0] });
            listSports.Add(new Sport() { SportId = 2, Name = "Ténis", Picture = listPictures.ToList()[0] });
            listSports.Add(new Sport() { SportId = 3, Name = "Pádel", Picture = listPictures.ToList()[0] });
            listSports.Add(new Sport() { SportId = 4, Name = "Basquetebol", Picture = listPictures.ToList()[0] });
            listSports.Add(new Sport() { SportId = 5, Name = "Futsal", Picture = listPictures.ToList()[0] });
            listSports.Add(new Sport() { SportId = 6, Name = "Andebol", Picture = listPictures.ToList()[0] });

            ICollection<Address> listAddresses = new Collection<Address>();
             listAddresses.Add(new Address() { AddressId = 1, PostalCode = "9200-209", Street = "Rua da fontinha nº2", CountyId = 1});
             listAddresses.Add(new Address() { AddressId = 2, PostalCode = "9200-098", Street = "Rua do muro nº1", CountyId = 1});

            ICollection<Park> listParks = new Collection<Park>();
            listParks.Add(new Park() { ParkId = 1, Name = "Agua de Pena", Adress = listAddresses.ToList()[0] });
            listParks.Add(new Park() { ParkId = 2, Name = "Ludens Padel", Adress = listAddresses.ToList()[1]});

            foreach (District districit in listDistricts)
            {
                context.Districts.AddOrUpdate(districit);
            }

            foreach (County county in listCounties)
            {
                context.Counties.AddOrUpdate(county);
            }

            foreach (Picture picture in listPictures)
            {
                context.Pictures.AddOrUpdate(picture);
            }

            foreach (User user in listUsers)
            {
                context.Users.AddOrUpdate(user);
            }

            foreach (Sport sport in listSports)
            {
                context.Sports.AddOrUpdate(sport);
            }

            foreach (Address address in listAddresses)
            {
                context.Addresses.AddOrUpdate(address);
            }

            foreach (Park park in listParks)
            {
                context.Parks.AddOrUpdate(park);
            }
            base.Seed(context);
        }
    }
}
