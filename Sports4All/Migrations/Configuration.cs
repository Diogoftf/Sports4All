using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Sports4All.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        private DateTime dateStartEvent = new DateTime(2020, 2, 18);
        private readonly ICollection<Address> listAddresses = new Collection<Address>();
        private readonly ICollection<County> listCounties = new Collection<County>();
        private readonly ICollection<District> listDistricts = new Collection<District>();
        private readonly ICollection<Event> listEvents = new Collection<Event>();
        private readonly ICollection<Ground> listGrounds = new Collection<Ground>();
        private readonly ICollection<Material> listMaterials = new Collection<Material>();
        private readonly ICollection<ParkClassification> listParkClassifications = new Collection<ParkClassification>();
        private readonly ICollection<ParkEvaluation> listParkEvaluation = new Collection<ParkEvaluation>();
        private readonly ICollection<Park> listParks = new Collection<Park>();
        private readonly ICollection<Picture> listPictures = new Collection<Picture>();
        private readonly ICollection<Reserve> listReserves = new Collection<Reserve>();
        private readonly ICollection<Sport> listSports = new Collection<Sport>();
        private readonly ICollection<Use> listUse = new Collection<Use>();
        private readonly ICollection<UserClassification> listUserClassifications = new Collection<UserClassification>();
        private readonly ICollection<UserEvaluation> listUserEvaluations = new Collection<UserEvaluation>();
        private readonly ICollection<User> listUsers = new Collection<User>();
        private readonly ICollection<Material> materialsUse = new Collection<Material>();


        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

            //if (System.Diagnostics.Debugger.IsAttached == false)
            //{
            //    System.Diagnostics.Debugger.Launch();
            //}
        }

        private void AddDistricts()
        {
            listDistricts.Add(new District {DistrictId = 1, Name = "Madeira"});
            listDistricts.Add(new District {DistrictId = 2, Name = "Açores"});
        }

        private void AddCountries()
        {
            listCounties.Add(new County {CountyId = 1, DistrictId = 1, Name = "Machico"});
            listCounties.Add(new County {CountyId = 2, DistrictId = 2, Name = "São Miguel"});
            listCounties.Add(new County {CountyId = 3, DistrictId = 1, Name = "Funchal"});
            listCounties.Add(new County {CountyId = 4, DistrictId = 1, Name = "São Vicente"});
            listCounties.Add(new County {CountyId = 5, DistrictId = 1, Name = "Santa Cruz"});
        }


        private void AddAddress()
        {
            listAddresses.Add(new Address
                {AddressId = 1, PostalCode = "9200-209", Street = "Rua da fontinha nº2", CountyId = 1});
            listAddresses.Add(new Address
                {AddressId = 2, PostalCode = "9200-098", Street = "Rua do muro nº1", CountyId = 1});
        }


        private void AddPicture()
        {
            listPictures.Add(new Picture {PictureId = 1, Path = "User1"});
            listPictures.Add(new Picture {PictureId = 2, Path = "User2"});
            listPictures.Add(new Picture {PictureId = 3, Path = "User3"});
            listPictures.Add(new Picture {PictureId = 4, Path = "User4"});
            listPictures.Add(new Picture {PictureId = 5, Path = "Desporto1"});
            listPictures.Add(new Picture {PictureId = 6, Path = "Desporto2"});
            listPictures.Add(new Picture {PictureId = 7, Path = "Desporto3"});
            listPictures.Add(new Picture {PictureId = 8, Path = "Desporto4"});
            listPictures.Add(new Picture {PictureId = 9, Path = "Park1"});
            listPictures.Add(new Picture {PictureId = 10, Path = "Park2"});
        }

        private void AddSport()
        {
            listSports.Add(new Sport {SportId = 1, Name = "Futebol", Picture = listPictures.ToList()[4]});
            listSports.Add(new Sport {SportId = 2, Name = "Ténis", Picture = listPictures.ToList()[5]});
            listSports.Add(new Sport {SportId = 3, Name = "Futsal", Picture = listPictures.ToList()[6]});
            listSports.Add(new Sport {SportId = 4, Name = "Andebol", Picture = listPictures.ToList()[7]});
        }

        private void AddUser()
        {
            listUsers.Add(new User
            {
                PictureId = listPictures.ToList()[0].PictureId, Username = "andreMx", Age = 23,
                Email = "andre@gmail.com", Password = "123", PhoneNumber = 961451719,
                CountyId = listCounties.ToList()[3].CountyId
            });
            listUsers.Add(new User
            {
                PictureId = listPictures.ToList()[1].PictureId, Username = "ruben21", Age = 23,
                Email = "ruben1@gmail.com", Password = "123", PhoneNumber = 916656789,
                CountyId = listCounties.ToList()[2].CountyId
            });
        }

        private void AddPark()
        {
            listParks.Add(new Park
            {
                ParkId = 1, Name = "Agua de Pena", Address = listAddresses.ToList()[0],
                Description = "Teste Descrição1", Picture = listPictures.ToList()[8]
            });
            listParks.Add(new Park
            {
                ParkId = 2, Name = "Ludens Padel", Address = listAddresses.ToList()[1],
                Description = "Teste Descrição2", Picture = listPictures.ToList()[9]
            });
        }


        private void AddGround()
        {
            listGrounds.Add(new Ground
            {
                GroundId = 1, ParkId = 1, Price = 10, Sports = listSports.ToList(), Picture = listPictures.ToList()[8]
            });
            listGrounds.Add(new Ground
            {
                GroundId = 2, ParkId = 2, Price = 12, Sports = listSports.ToList(), Picture = listPictures.ToList()[9]
            });
        }

        private void AddReserve()
        {
            dateStartEvent.Date.AddHours(12);
            dateStartEvent.Date.AddMinutes(00);
            listReserves.Add(new Reserve
            {
                ReserveId = 1, Price = 10, UserId = listUsers.ToList()[0].Username,
                SportId = listSports.ToList()[0].SportId, GroundId = listGrounds.ToList()[0].GroundId,
                Date = dateStartEvent
            });
            listReserves.Add(new Reserve
            {
                ReserveId = 2, Price = 10, UserId = listUsers.ToList()[1].Username,
                SportId = listSports.ToList()[1].SportId, GroundId = listGrounds.ToList()[1].GroundId,
                Date = dateStartEvent
            });
        }


        private void AddEvent()
        {
            var dateEndEvent = dateStartEvent;
            dateStartEvent.Date.AddHours(12);
            dateStartEvent.Date.AddMinutes(00);
            dateEndEvent.Date.AddHours(14);
            dateEndEvent.Date.AddMinutes(00);
            listEvents.Add(new Event
            {
                EventId = 1, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 10, MinAge = 21,
                MaxAge = 31, Reserve = listReserves.ToList()[1], Name = "Treino - ADM vs Nacional", Users = listUsers
            });
            dateStartEvent = dateEndEvent = new DateTime(2019, 1, 25);
            dateStartEvent.Date.AddHours(9);
            dateStartEvent.Date.AddMinutes(30);
            dateEndEvent.Date.AddHours(11);
            dateEndEvent.Date.AddMinutes(00);
            listEvents.Add(new Event
            {
                EventId = 2, StartDate = dateStartEvent, EndDate = dateEndEvent, MaxPlayers = 6, MinAge = 10,
                Reserve = listReserves.ToList()[1], MaxAge = 18, Name = "Jogo Amigavel de Futebol", Users = listUsers
            });
        }
        private void AddUserEvaluation()
        {
            listUserEvaluations.Add(new UserEvaluation
            {
                EvaluationId = 1, EvaluatorId = listUsers.ToList()[0].Username,
                EventId = listEvents.ToList()[0].EventId, Skill = 4, FairPlay = 5,
                UserId = listUsers.ToList()[1].Username
            });
            listUserEvaluations.Add(new UserEvaluation
            {
                EvaluationId = 2, EvaluatorId = listUsers.ToList()[0].Username,
                EventId = listEvents.ToList()[1].EventId, Skill = 3, FairPlay = 2,
                UserId = listUsers.ToList()[1].Username
            });
        }

        private void AddParkEvaluation()
        {
            listParkEvaluation.Add(new ParkEvaluation
            {
                EvaluationId = 5, EvaluatorId = listUsers.ToList()[0].Username,
                EventId = listEvents.ToList()[0].EventId, Quality = 4, Price = 5, ParkId = listParks.ToList()[0].ParkId
            });
            listParkEvaluation.Add(new ParkEvaluation
            {
                EvaluationId = 6, EvaluatorId = listUsers.ToList()[0].Username,
                EventId = listEvents.ToList()[1].EventId, Quality = 3, Price = 2, ParkId = listParks.ToList()[1].ParkId
            });
            listParkEvaluation.Add(new ParkEvaluation
            {
                EvaluationId = 7, EvaluatorId = listUsers.ToList()[1].Username,
                EventId = listEvents.ToList()[0].EventId, Quality = 5, Price = 5, ParkId = listParks.ToList()[0].ParkId
            });
            listParkEvaluation.Add(new ParkEvaluation
            {
                EvaluationId = 8, EvaluatorId = listUsers.ToList()[1].Username,
                EventId = listEvents.ToList()[1].EventId, Quality = 4, Price = 4, ParkId = listParks.ToList()[1].ParkId
            });
        }

        private void ParkClassification()
        {
            listParkClassifications.Add(new ParkClassification
            {
                ClassificationId = 1, Park = listParks.ToList()[0], Points = 0, PriceAverage = 0, QualityAverage = 0,
                Ratio = 0
            });
            listParkClassifications.Add(new ParkClassification
            {
                ClassificationId = 2, Park = listParks.ToList()[1], Points = 0, PriceAverage = 0, QualityAverage = 0,
                Ratio = 0
            });
        }

        private void UserClassification()
        {
            listUserClassifications.Add(new UserClassification
            {
                ClassificationId = 3, User = listUsers.ToList()[0], Points = 0, SkillAverage = 0, FairplayAverage = 0,
                Ratio = 0
            });
            listUserClassifications.Add(new UserClassification
            {
                ClassificationId = 4, User = listUsers.ToList()[1], Points = 0, SkillAverage = 0, FairplayAverage = 0,
                Ratio = 0
            });
        }

        private void AddMaterial()
        {
            listMaterials.Add(new Material
            {
                MaterialId = 1, Available = 4, Price = 6, Name = "Bola", SportId = listSports.ToList()[0].SportId,
                ParkId = listParks.ToList()[0].ParkId
            });
            listMaterials.Add(new Material
            {
                MaterialId = 2, Available = 6, Price = 8, Name = "Raquete", SportId = listSports.ToList()[1].SportId,
                ParkId = listParks.ToList()[0].ParkId
            });


            materialsUse.Add(listMaterials.ToList()[0]);
            ICollection<int> listQuantityUse = new Collection<int>();
            listQuantityUse.Add(1);
            listUse.Add(new Use
            {
                UseId = 1, MaterialId = listMaterials.ElementAt(0).MaterialId, Quantity = 1,
                ReserveId = listReserves.ElementAt(0).ReserveId
            });
            listUse.Add(new Use
            {
                UseId = 2, MaterialId = listMaterials.ElementAt(1).MaterialId, Quantity = 1,
                ReserveId = listReserves.ElementAt(1).ReserveId
            });
        }

        protected override void Seed(ModelContext context)
        {
            AddDistricts();
            AddCountries();
            AddAddress();
            AddPicture();
            AddSport();
            AddUser();
            AddPark();
            AddGround();
            AddReserve();
            AddEvent();
            AddUserEvaluation();
            AddParkEvaluation();
            ParkClassification();
            UserClassification();
            AddMaterial();
            // Esta lista contem todas as avaliações feitas da josefa aos utilizadores desse evento especifico
            // Esta lista contem todas as avaliações feitas da josefa aos recintos
            ICollection<Evaluation> listEvaluationsRuben = new Collection<Evaluation>();
            ICollection<Reserve> listReservesRuben = new Collection<Reserve>();
            ICollection<Event> listEventsRuben = new Collection<Event>();
            listReservesRuben.Add(listReserves.ToList()[1]);
            listEventsRuben.Add(listEvents.ToList()[0]);

            foreach (var user in listUserEvaluations) 
                listEvaluationsRuben.Add(user);
            foreach (var ground in listParkEvaluation) 
                listEvaluationsRuben.Add(ground);
            foreach (var county in listCounties) 
                context.Counties.AddOrUpdate(county);
            foreach (var address in listAddresses) 
                context.Addresses.AddOrUpdate(address);
            foreach (var picture in listPictures) 
                context.Pictures.AddOrUpdate(picture);
            foreach (var user in listUsers) 
                context.Users.AddOrUpdate(user);
            foreach (var sport in listSports) 
                context.Sports.AddOrUpdate(sport);
            foreach (var park in listParks) 
                context.Parks.AddOrUpdate(park);
            foreach (var ground in listGrounds) 
                context.Grounds.AddOrUpdate(ground);
            foreach (var reserve in listReserves) 
                context.Reserves.AddOrUpdate(reserve);
            foreach (var events in listEvents) 
                context.Events.AddOrUpdate(events);
            foreach (var userEvaluation in listUserEvaluations) 
                context.Evaluations.AddOrUpdate(userEvaluation);
            foreach (var parkEvaluation in listParkEvaluation)
                context.Evaluations.AddOrUpdate(parkEvaluation);
            foreach (var parkClassification in listParkClassifications)
                context.Classifications.AddOrUpdate(parkClassification);
            foreach (var userClassification in listUserClassifications)
                context.Classifications.AddOrUpdate(userClassification);
            foreach (var material in listMaterials) 
                context.Materials.AddOrUpdate(material);
            foreach (var use in listUse) 
                context.Uses.AddOrUpdate(use);
            base.Seed(context);
        }
    }
}