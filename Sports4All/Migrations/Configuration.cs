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
             listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "josefa", Age = 23, Email = "josefa31@gmail.com", Password = "123", PhoneNumber = 916656789, CountyId = 3 });
             listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "andreMx", Age = 23, Email = "andre@gmail.com", Password = "123", PhoneNumber = 961451719, CountyId = 4 });
             listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "ruben21", Age = 23, Email = "ruben1@gmail.com", Password = "123", PhoneNumber = 916656789, CountyId = 3 });
             listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "rubinol0uco", Age = 23, Email = "rubino@gmail.com", Password = "123", PhoneNumber = 961451339, CountyId = 3 });
             listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "rafaela33", Age = 23, Email = "rubino@gmail.com", Password = "123", PhoneNumber = 961451229, CountyId = 3 });
             listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "michaelfx", Age = 23, Email = "michaelDal@gmail.com", Password = "123", PhoneNumber = 926456783, CountyId = 4 });

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
            /*
            ICollection<Reserve> listReserves = new Collection<Reserve>();
            listReserves.Add(new Reserve() { ReserveId = 1, Price = 10, UserId = listUsers.ToList()[0].Username, SportId = listSports.ToList()[0].SportId  });
            listReserves.Add(new Reserve() { ReserveId = 2, Price = 10, UserId = listUsers.ToList()[1].Username, SportId = listSports.ToList()[1].SportId  });
            listReserves.Add(new Reserve() { ReserveId = 3, Price = 10, UserId = listUsers.ToList()[0].Username, SportId = listSports.ToList()[2].SportId  });
            listReserves.Add(new Reserve() { ReserveId = 4, Price = 10, UserId = listUsers.ToList()[2].Username, SportId = listSports.ToList()[3].SportId  });*/
            /* 
                        ICollection<Event> listEvents = new Collection<Event>();
                        DateTime dateStartEvent = new DateTime(2019, 1, 18);
                        DateTime dateEndEvent = dateStartEvent;
                        dateStartEvent.Date.AddHours(12); dateStartEvent.Date.AddMinutes(00);
                        dateEndEvent.Date.AddHours(14); dateEndEvent.Date.AddMinutes(00);
                        listEvents.Add(new Event() { EventId = 1, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 10, MinAge = 21, MaxAge = 31, Name = "Treino - ADM vs Nacional" });
                      dateStartEvent = dateEndEvent = new DateTime(2019, 1, 25);
                        dateStartEvent.Date.AddHours(9); dateStartEvent.Date.AddMinutes(30);
                        dateEndEvent.Date.AddHours(11); dateEndEvent.Date.AddMinutes(00);
                        listEvents.Add(new Event() { EventId = 2, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 6, MinAge = 10, MaxAge = 18, Name = "Jogo Amigavel de Futebol" });
                        dateStartEvent = dateEndEvent = new DateTime(2020, 1, 2);
                        dateStartEvent.Date.AddHours(14); dateStartEvent.Date.AddMinutes(00);
                        dateEndEvent.Date.AddHours(16); dateEndEvent.Date.AddMinutes(00);
                        listEvents.Add(new Event() { EventId = 3, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 12, MinAge = 20, MaxAge = 40, Name = "Torneio de Padel" });
                        dateStartEvent = dateEndEvent = new DateTime(2019, 1, 15);
                        dateStartEvent.Date.AddHours(18); dateStartEvent.Date.AddMinutes(00);
                        dateEndEvent.Date.AddHours(20); dateEndEvent.Date.AddMinutes(00);
                        listEvents.Add(new Event() { EventId = 4, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 8, MinAge = 30, MaxAge = 50, Name = "Jogo Amigavel de Tenis" });
            */

            foreach (District district in listDistricts)
            {
                context.Districts.AddOrUpdate(district);
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

            foreach (Reserve reserve in listReserves)
            {
                context.Reserves.AddOrUpdate(reserve);
            }
            /*


            foreach (Event events in listEvents)
            {
                context.Events.AddOrUpdate(events);
            }
            */


            base.Seed(context);
        }
    }
}
