using Sports4All.Controller;

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
           
            ImagesController imgsController = new ImagesController();

            ICollection<District> listDistricts = new Collection<District>();

            listDistricts.Add(new District() { DistrictId = 1, Name = "Madeira" });
            listDistricts.Add(new District() { DistrictId = 2, Name = "Açores" });

            ICollection<County> listCounties = new Collection<County>();

            listCounties.Add(new County() { CountyId = 1, DistrictId = 1, Name = "Machico" });
            listCounties.Add(new County() { CountyId = 2, DistrictId = 2, Name = "São Miguel" });
            listCounties.Add(new County() { CountyId = 3, DistrictId = 1, Name = "Funchal" });
            listCounties.Add(new County() { CountyId = 4, DistrictId = 1, Name = "São Vicente" });
            listCounties.Add(new County() { CountyId = 5, DistrictId = 1, Name = "Santa Cruz" });
            
          // IList<string> images = imgsController.InsertImagetoDB();

           ICollection<Picture> listPictures = new Collection<Picture>();
           listPictures.Add(new Picture() { PictureId = 1, PictureBody = "testee"  });
           listPictures.Add(new Picture() { PictureId = 2, PictureBody = "testee" });
           listPictures.Add(new Picture() { PictureId = 3, PictureBody = "testee" });
           listPictures.Add(new Picture() { PictureId = 4, PictureBody = "testee" });
            listPictures.Add(new Picture() { PictureId = 5, PictureBody = "testee" });
            listPictures.Add(new Picture() { PictureId = 6, PictureBody = "testee" });
            listPictures.Add(new Picture() { PictureId = 7, PictureBody = "testee" });
            listPictures.Add(new Picture() { PictureId = 8, PictureBody = "testee" });

            /* 
           ICollection<User> listUsers = new Collection<User>();
           listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "andreMx", Age = 23, Email = "andre@gmail.com", Password = "123", PhoneNumber = 961451719, CountyId = listCounties.ToList()[3].CountyId });
           listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "ruben21", Age = 23, Email = "ruben1@gmail.com", Password = "123", PhoneNumber = 916656789, CountyId = listCounties.ToList()[2].CountyId });


           ICollection<Sport> listSports = new Collection<Sport>();
           listSports.Add(new Sport() { SportId = 1, Name = "Futebol", Picture = listPictures.ToList()[2] });
           listSports.Add(new Sport() { SportId = 2, Name = "Ténis", Picture = listPictures.ToList()[3] });
           listSports.Add(new Sport() { SportId = 3, Name = "Futsal", Picture = listPictures.ToList()[4] });
           listSports.Add(new Sport() { SportId = 4, Name = "Andebol", Picture = listPictures.ToList()[5] });

           ICollection<Address> listAddresses = new Collection<Address>();
           listAddresses.Add(new Address() { AddressId = 1, PostalCode = "9200-209", Street = "Rua da fontinha nº2", CountyId = 1 });
           listAddresses.Add(new Address() { AddressId = 2, PostalCode = "9200-098", Street = "Rua do muro nº1", CountyId = 1 });

           ICollection<Park> listParks = new Collection<Park>();
           listParks.Add(new Park() { ParkId = 1, Name = "Agua de Pena", Adress = listAddresses.ToList()[0], Description = "Teste Descrição1", Picture = listPictures.ToList()[0] });
           listParks.Add(new Park() { ParkId = 2, Name = "Ludens Padel", Adress = listAddresses.ToList()[1], Description = "Teste Descrição2", Picture = listPictures.ToList()[1] });

           ICollection<Ground> listGrounds = new Collection<Ground>();
           listGrounds.Add(new Ground() { GroundId = 1, ParkId = 1, Sports = listSports.ToList(), Picture = listPictures.ToList()[6] });
           listGrounds.Add(new Ground() { GroundId = 2, ParkId = 2, Sports = listSports.ToList(), Picture = listPictures.ToList()[7] });

           DateTime dateStartEvent = new DateTime(2020, 2, 18);
           dateStartEvent.Date.AddHours(12); dateStartEvent.Date.AddMinutes(00);
           ICollection<Reserve> listReserves = new Collection<Reserve>();
           listReserves.Add(new Reserve() { ReserveId = 1, Price = 10, UserId = listUsers.ToList()[0].Username, SportId = listSports.ToList()[0].SportId, GroundId = listGrounds.ToList()[0].GroundId, Date = dateStartEvent });
           listReserves.Add(new Reserve() { ReserveId = 2, Price = 10, UserId = listUsers.ToList()[1].Username, SportId = listSports.ToList()[1].SportId, GroundId = listGrounds.ToList()[0].GroundId, Date = dateStartEvent });
           listReserves.Add(new Reserve() { ReserveId = 3, Price = 10, UserId = listUsers.ToList()[0].Username, SportId = listSports.ToList()[2].SportId, GroundId = listGrounds.ToList()[0].GroundId, Date = dateStartEvent });
           listReserves.Add(new Reserve() { ReserveId = 4, Price = 10, UserId = listUsers.ToList()[0].Username, SportId = listSports.ToList()[3].SportId, GroundId = listGrounds.ToList()[0].GroundId, Date = dateStartEvent });

           ICollection<Event> listEvents = new Collection<Event>();

           DateTime dateEndEvent = dateStartEvent;
           dateStartEvent.Date.AddHours(12); dateStartEvent.Date.AddMinutes(00);
           dateEndEvent.Date.AddHours(14); dateEndEvent.Date.AddMinutes(00);
           listEvents.Add(new Event() { EventId = 1, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 10, MinAge = 21, MaxAge = 31, Reserve = listReserves.ToList()[1], Name = "Treino - ADM vs Nacional" });
           dateStartEvent = dateEndEvent = new DateTime(2019, 1, 25);
           dateStartEvent.Date.AddHours(9); dateStartEvent.Date.AddMinutes(30);
           dateEndEvent.Date.AddHours(11); dateEndEvent.Date.AddMinutes(00);
           listEvents.Add(new Event() { EventId = 2, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 6, MinAge = 10, Reserve = listReserves.ToList()[1], MaxAge = 18, Name = "Jogo Amigavel de Futebol" });
           dateStartEvent = dateEndEvent = new DateTime(2020, 1, 2);
           dateStartEvent.Date.AddHours(14); dateStartEvent.Date.AddMinutes(00);
           dateEndEvent.Date.AddHours(16); dateEndEvent.Date.AddMinutes(00);
           listEvents.Add(new Event() { EventId = 3, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 12, MinAge = 20, Reserve = listReserves.ToList()[2], MaxAge = 40, Name = "Torneio de Padel" });
           dateStartEvent = dateEndEvent = new DateTime(2019, 1, 15);
           dateStartEvent.Date.AddHours(18); dateStartEvent.Date.AddMinutes(00);
           dateEndEvent.Date.AddHours(20); dateEndEvent.Date.AddMinutes(00);
           listEvents.Add(new Event() { EventId = 4, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 8, MinAge = 30, Reserve = listReserves.ToList()[3], MaxAge = 50, Name = "Jogo Amigavel de Tenis" });

           ICollection<UserEvaluation> listUserEvaluations = new Collection<UserEvaluation>();
           listUserEvaluations.Add(new UserEvaluation() { EvaluationId = 1, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[0].EventId, Skill = 4, FairPlay = 5, UserId = listUsers.ToList()[0].Username });
           listUserEvaluations.Add(new UserEvaluation() { EvaluationId = 2, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[1].EventId, Skill = 3, FairPlay = 2, UserId = listUsers.ToList()[0].Username });
           listUserEvaluations.Add(new UserEvaluation() { EvaluationId = 3, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[2].EventId, Skill = 5, FairPlay = 5, UserId = listUsers.ToList()[0].Username });
           listUserEvaluations.Add(new UserEvaluation() { EvaluationId = 4, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[3].EventId, Skill = 3, FairPlay = 4, UserId = listUsers.ToList()[0].Username });

           ICollection<GroundEvaluation> listGroundEvaluations = new Collection<GroundEvaluation>();
           listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 5, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[0].EventId, Quality = 4, Price = 5, GroundId = listGrounds.ToList()[0].GroundId });
           listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 6, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[1].EventId, Quality = 3, Price = 2, GroundId = listGrounds.ToList()[0].GroundId });
           listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 7, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[2].EventId, Quality = 5, Price = 5, GroundId = listGrounds.ToList()[0].GroundId });
           listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 8, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[3].EventId, Quality = 4, Price = 4, GroundId = listGrounds.ToList()[0].GroundId });

           // Esta lista contem todas as avaliações feitas da josefa aos utilizadores desse evento especifico
           // Esta lista contem todas as avaliações feitas da josefa aos recintos
           ICollection<Evaluation> listEvaluationsRuben = new Collection<Evaluation>();
           ICollection<Reserve> listReservesRuben = new Collection<Reserve>();
           ICollection<Event> listEventsRuben= new Collection<Event>();
           listReservesRuben.Add(listReserves.ToList()[1]);
           listEventsRuben.Add(listEvents.ToList()[0]);

           foreach (UserEvaluation user in listUserEvaluations)
           {
               listEvaluationsRuben.Add(user);
           }

           foreach (GroundEvaluation ground in listGroundEvaluations)
           {
               listEvaluationsRuben.Add(ground);
           }
           /////////
           /*
               listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "rubinol0uco", Age = 23, Email = "rubino@gmail.com", Password = "123", PhoneNumber = 961451339, CountyId = listCounties.ToList()[2].CountyId, County = listCounties.ToList()[2] });
                       listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "rafaela33", Age = 23, Email = "rubino@gmail.com", Password = "123", PhoneNumber = 961451229, CountyId = listCounties.ToList()[2].CountyId, County = listCounties.ToList()[2] });
                       listUsers.Add(new User() { PictureId = listPictures.First().PictureId, Username = "michaelfx", Age = 23, Email = "michaelDal@gmail.com", Password = "123", PhoneNumber = 926456783, CountyId = listCounties.ToList()[3].CountyId, County = listCounties.ToList()[3] });
           */
           //////////////////
          
          
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
            /*
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


              foreach (Ground ground in listGrounds)
              {
                  context.Grounds.AddOrUpdate(ground);
              }

              foreach (Reserve reserve in listReserves)
              {
                  context.Reserves.AddOrUpdate(reserve);
              }

              foreach (Event events in listEvents)
              {
                  context.Events.AddOrUpdate(events);
              }

              foreach (UserEvaluation userEvaluation in listUserEvaluations)
              {
                  context.Evaluations.AddOrUpdate(userEvaluation);
              }
              */

            base.Seed(context);
        }
    }
}
