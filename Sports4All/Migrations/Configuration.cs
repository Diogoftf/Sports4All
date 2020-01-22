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

            //if (System.Diagnostics.Debugger.IsAttached == false)
            //{
            //    System.Diagnostics.Debugger.Launch();
            //}
        }

        protected override void Seed(Sports4All.ModelContext context)
        {

            ImagesController imagesController = new ImagesController();
            ICollection<Picture> imgs = new Collection<Picture>();


            ICollection<District> listDistricts = new Collection<District>();

            listDistricts.Add(new District() { DistrictId = 1, Name = "Madeira" });
            listDistricts.Add(new District() { DistrictId = 2, Name = "Açores" });

            ICollection<County> listCounties = new Collection<County>();

            listCounties.Add(new County() { CountyId = 1, DistrictId = 1, Name = "Machico" });
            listCounties.Add(new County() { CountyId = 2, DistrictId = 2, Name = "São Miguel" });
            listCounties.Add(new County() { CountyId = 3, DistrictId = 1, Name = "Funchal" });
            listCounties.Add(new County() { CountyId = 4, DistrictId = 1, Name = "São Vicente" });
            listCounties.Add(new County() { CountyId = 5, DistrictId = 1, Name = "Santa Cruz" });

            ICollection<Address> listAddresses = new Collection<Address>();
            listAddresses.Add(new Address() { AddressId = 1, PostalCode = "9200-209", Street = "Rua da fontinha nº2", CountyId = 1 });
            listAddresses.Add(new Address() { AddressId = 2, PostalCode = "9200-098", Street = "Rua do muro nº1", CountyId = 1 });

             imagesController.InsertImagetoDB("User", 4, imgs);
              imagesController.InsertImagetoDB("Park", 3, imgs);
              imagesController.InsertImagetoDB("Sport", 5, imgs);
            
            
            ICollection<Picture> listPictures = new Collection<Picture>();
            listPictures.Add(new Picture() { PictureId = 1, PictureBody = imagesController.imgs1.ToList()[0].PictureBody,FileName = imagesController.imgs1.ToList() [0].FileName});
            listPictures.Add(new Picture() { PictureId = 2, PictureBody = imagesController.imgs1.ToList()[1].PictureBody, FileName = imagesController.imgs1.ToList()[1].FileName });
            listPictures.Add(new Picture() { PictureId = 3, PictureBody = imagesController.imgs1.ToList()[2].PictureBody, FileName = imagesController.imgs1.ToList()[2].FileName });
            listPictures.Add(new Picture() { PictureId = 4, PictureBody = imagesController.imgs1.ToList()[3].PictureBody, FileName = imagesController.imgs1.ToList()[3].FileName });
            //park picture
            listPictures.Add(new Picture() { PictureId = 5, PictureBody = imagesController.imgs1.ToList()[4].PictureBody, FileName = imagesController.imgs1.ToList()[4].FileName });
            listPictures.Add(new Picture() { PictureId = 6, PictureBody = imagesController.imgs1.ToList()[5].PictureBody, FileName = imagesController.imgs1.ToList()[5].FileName });
            listPictures.Add(new Picture() { PictureId = 7, PictureBody = imagesController.imgs1.ToList()[6].PictureBody, FileName = imagesController.imgs1.ToList()[6].FileName });
            //sport picture
            listPictures.Add(new Picture() { PictureId = 8, PictureBody = imagesController.imgs1.ToList()[7].PictureBody, FileName = imagesController.imgs1.ToList()[7].FileName });
            listPictures.Add(new Picture() { PictureId = 9, PictureBody = imagesController.imgs1.ToList()[8].PictureBody, FileName = imagesController.imgs1.ToList()[8].FileName });
            listPictures.Add(new Picture() { PictureId = 10, PictureBody = imagesController.imgs1.ToList()[9].PictureBody, FileName = imagesController.imgs1.ToList()[9].FileName });
            listPictures.Add(new Picture() { PictureId = 11, PictureBody = imagesController.imgs1.ToList()[10].PictureBody, FileName = imagesController.imgs1.ToList()[10].FileName });
            listPictures.Add(new Picture() { PictureId = 12, PictureBody = imagesController.imgs1.ToList()[11].PictureBody, FileName = imagesController.imgs1.ToList()[11].FileName });


            //listPictures.Add(new Picture() { PictureId = 1, PictureBody = imgs.ToList()[0].PictureBody, FileName = imgs.ToList()[0].FileName });
            //listPictures.Add(new Picture() { PictureId = 2, PictureBody = imgs.ToList()[1].PictureBody, FileName = imgs.ToList()[1].FileName });
            //listPictures.Add(new Picture() { PictureId = 3, PictureBody = "Desporto1" });
            //listPictures.Add(new Picture() { PictureId = 4, PictureBody = "Desporto2" });
            //listPictures.Add(new Picture() { PictureId = 5, PictureBody = "Desporto3" });
            //listPictures.Add(new Picture() { PictureId = 6, PictureBody = "Desporto4" });
            //listPictures.Add(new Picture() { PictureId = 7, PictureBody = "Park1" });
            //listPictures.Add(new Picture() { PictureId = 8, PictureBody = "Park2" });

            ICollection<Sport> listSports = new Collection<Sport>();
            listSports.Add(new Sport() { SportId = 1, Name = "Futebol", Picture = listPictures.ToList()[7] });
            listSports.Add(new Sport() { SportId = 2, Name = "Ténis", Picture = listPictures.ToList()[8] });
            listSports.Add(new Sport() { SportId = 3, Name = "Futsal", Picture = listPictures.ToList()[9] });
            listSports.Add(new Sport() { SportId = 4, Name = "Andebol", Picture = listPictures.ToList()[10] });

            /*  listPictures.ToList()[2].Sport = listSports.ToList()[0];
              listPictures.ToList()[3].Sport = listSports.ToList()[1];
              listPictures.ToList()[4].Sport = listSports.ToList()[2];
              listPictures.ToList()[5].Sport = listSports.ToList()[3];*/

            ICollection<User> listUsers = new Collection<User>();
            listUsers.Add(new User() { PictureId = listPictures.ToList()[0].PictureId, Username = "andreMx", Age = 23, Email = "andre@gmail.com", Password = "123", PhoneNumber = 961451719, CountyId = listCounties.ToList()[3].CountyId });
            listUsers.Add(new User() { PictureId = listPictures.ToList()[1].PictureId, Username = "ruben21", Age = 23, Email = "ruben1@gmail.com", Password = "123", PhoneNumber = 916656789, CountyId = listCounties.ToList()[2].CountyId });

            ICollection<Park> listParks = new Collection<Park>();
            listParks.Add(new Park() { ParkId = 1, Name = "Agua de Pena", Adress = listAddresses.ToList()[0], Description = "Teste Descrição1", Picture = listPictures.ToList()[4] });
            listParks.Add(new Park() { ParkId = 2, Name = "Ludens Padel", Adress = listAddresses.ToList()[1], Description = "Teste Descrição2", Picture = listPictures.ToList()[5] });

            ICollection<Ground> listGrounds = new Collection<Ground>();
            listGrounds.Add(new Ground() { GroundId = 1, ParkId = 1, Sports = listSports.ToList(), Picture = listPictures.ToList()[6] });
            listGrounds.Add(new Ground() { GroundId = 2, ParkId = 2, Sports = listSports.ToList(), Picture = listPictures.ToList()[11] });

             DateTime dateStartEvent = new DateTime(2020, 2, 18);
             dateStartEvent.Date.AddHours(12); dateStartEvent.Date.AddMinutes(00);
             ICollection<Reserve> listReserves = new Collection<Reserve>();
             listReserves.Add(new Reserve() {ReserveId = 1, Price = 10, UserId = listUsers.ToList()[0].Username, SportId = listSports.ToList()[0].SportId, GroundId = listGrounds.ToList()[0].GroundId, Date = dateStartEvent });
             listReserves.Add(new Reserve() { ReserveId = 2, Price = 10, UserId = listUsers.ToList()[1].Username, SportId = listSports.ToList()[1].SportId, GroundId = listGrounds.ToList()[1].GroundId, Date = dateStartEvent });
      
             ICollection<Event> listEvents = new Collection<Event>();
             DateTime dateEndEvent = dateStartEvent;
             dateStartEvent.Date.AddHours(12); dateStartEvent.Date.AddMinutes(00);
             dateEndEvent.Date.AddHours(14); dateEndEvent.Date.AddMinutes(00);
             listEvents.Add(new Event() { EventId = 1, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 10, MinAge = 21, MaxAge = 31, Reserve = listReserves.ToList()[1], Name = "Treino - ADM vs Nacional", Users = listUsers });
             dateStartEvent = dateEndEvent = new DateTime(2019, 1, 25);
             dateStartEvent.Date.AddHours(9); dateStartEvent.Date.AddMinutes(30);
             dateEndEvent.Date.AddHours(11); dateEndEvent.Date.AddMinutes(00);
             listEvents.Add(new Event() { EventId = 2, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 6, MinAge = 10, Reserve = listReserves.ToList()[1], MaxAge = 18, Name = "Jogo Amigavel de Futebol", Users = listUsers });
  
             ICollection<UserEvaluation> listUserEvaluations = new Collection<UserEvaluation>();
             listUserEvaluations.Add(new UserEvaluation() { EvaluationId = 1, EvaluatorId = listUsers.ToList()[0].Username, EventId = listEvents.ToList()[0].EventId, Skill = 4, FairPlay = 5, UserId = listUsers.ToList()[1].Username });
             listUserEvaluations.Add(new UserEvaluation() { EvaluationId = 2, EvaluatorId = listUsers.ToList()[0].Username, EventId = listEvents.ToList()[1].EventId, Skill = 3, FairPlay = 2, UserId = listUsers.ToList()[1].Username });

             ICollection<GroundEvaluation> listGroundEvaluations = new Collection<GroundEvaluation>();
             listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 5, EvaluatorId = listUsers.ToList()[0].Username, EventId = listEvents.ToList()[0].EventId, Quality = 4, Price = 5, GroundId = listGrounds.ToList()[0].GroundId });
             listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 6, EvaluatorId = listUsers.ToList()[0].Username, EventId = listEvents.ToList()[1].EventId, Quality = 3, Price = 2, GroundId = listGrounds.ToList()[1].GroundId });
             listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 7, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[0].EventId, Quality = 5, Price = 5, GroundId = listGrounds.ToList()[0].GroundId });
             listGroundEvaluations.Add(new GroundEvaluation() { EvaluationId = 8, EvaluatorId = listUsers.ToList()[1].Username, EventId = listEvents.ToList()[1].EventId, Quality = 4, Price = 4, GroundId = listGrounds.ToList()[1].GroundId });

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
     
            foreach (District district in listDistricts)
            {
                context.Districts.AddOrUpdate(district);
            }

            foreach (County county in listCounties)
            {
                context.Counties.AddOrUpdate(county);
            }

            foreach (Address address in listAddresses)
            {
                context.Addresses.AddOrUpdate(address);
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
            

            base.Seed(context);
        }
    }
}
