﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;

namespace Sports4All.Controller
{
    public class MyEventsController
    {
        private readonly DateTime _todayDate;
        private ICollection<Event> _userEvents;
        private ICollection<User> _user;
        private int _userCompletedEventsCount { get; set; }
        private int _userNextEventsCount { get; set; }
        private int _userReservesCount { get; set; }

        public MyEventsController()
        {
            _todayDate = DateTime.Now;
            _userEvents = new Collection<Event>();
            _user = new Collection<User>();
        }
        public ICollection<Event> RetrieveCompletedEvents(string username)
        {
            using (var db = new ModelContext())
            {
                var UserCompletedEvents = db.Events.Where(c => c.Users.Any(i => i.Username.Equals(username)))
                    .Where(c => c.StartDate <= _todayDate)
                    .Include("Evaluations")
                    .Include("Reserve.Sport.Picture")
                    .Include("Reserve.Ground.Park.Picture")
                    .Include("Users")
                    .ToList();
                _userCompletedEventsCount = UserCompletedEvents.Count;
                return UserCompletedEvents;
            }
        }

        public ICollection<Event> RetrieveNextEvents(string username)
        {
            using (var db = new ModelContext())
            {
                var UserEvents = db.Events.Where(c => c.Users.Any(i => i.Username.Equals(username)))
                    .Where(c => c.StartDate >= _todayDate)
                    .Include("Evaluations")
                    .Include("Reserve.Sport")
                    .Include("Reserve.Ground.Park")
                    .Include("Users")
                    .ToList();
                _userNextEventsCount = UserEvents.Count;
                return UserEvents;
            }
        }

        public ICollection<Reserve> RetrieveUserReserves(string username)
        {
            using (var db = new ModelContext())
            {
                var UserReserves = db.Reserves.Where(c => c.User.Username.Equals(username))
                    .Where(c => c.Event != null && c.Event.EndDate >= _todayDate)
                    .Include("Event.Users")
                    .Include("Sport")
                    .Include("Ground.Park").ToList();
                _userReservesCount = UserReserves.Count;
                return UserReserves;
            }
        }

        public bool VerifyEvaluation(int eventId, string username)
        {
            var state = false;
            using (var db = new ModelContext())
            {
                var Evaluations = db.Evaluations
                    .Where(c => c.EvaluatorId.Equals(username) && c.EventId == eventId)
                    .ToList();
                if (Evaluations.Count != 0) state = true;
            }

            return state;
        }

        public ICollection<Event> EventsBySport(int sportId, int idLocation)
        {
            using (var db = new ModelContext())
            {
                List<Event> EventsbySport;
                if (idLocation == 0)
                {
                    EventsbySport = db.Events
                        .Where(c => c.Reserve.Sport.SportId == sportId && c.StartDate > _todayDate)
                        .Include("Reserve.Sport")
                        .Include("Reserve.Ground.Park")
                        .Include("Users")
                        .ToList();
                }
                else
                {
                    EventsbySport = db.Events
                        .Where(c => c.Reserve.Sport.SportId == sportId && c.StartDate > _todayDate 
                                    && c.Reserve.Ground.Park.Address.CountyId == idLocation)
                        .Include("Reserve.Sport")
                        .Include("Reserve.Ground.Park")
                        .Include("Users")
                        .ToList();
                }
                return EventsbySport;
            }
        }
        public ICollection<Event> EventsByGround(int parkId)
        {
            using (var db = new ModelContext())
            {
                var EventsbyGroundt = db.Events
                    .Where(c => c.Reserve.Ground.Park.ParkId == parkId && c.StartDate > _todayDate)
                    .Include("Reserve.Sport")
                    .Include("Reserve.Ground.Park")
                    .Include("Users")
                    .ToList();
                return EventsbyGroundt;
            }
        }

        public ICollection<Sport> RetrieveSingleSport(int sportId)
        {
            using (var db = new ModelContext())
            {
                var Sport = db.Sports
                    .Where(c => c.SportId== sportId)
                    .ToList();
                return Sport;
            }
        }
        public ICollection<Park> RetrieveSinglePark(int parkId)
        {
            using (var db = new ModelContext())
            {
                var Sport = db.Parks
                    .Where(c => c.ParkId == parkId)
                    .ToList();
                return Sport;
            }
        }
        public ICollection<Event> EventsbyGroundandSport(int parkId, string sport)
        {
            using (var db = new ModelContext())
            {
                var EventsbyGroundt = db.Events
                    .Where(c => c.Reserve.Ground.Park.ParkId == parkId && c.Reserve.Sport.Name.Equals(sport) &&
                                c.StartDate > _todayDate)
                    .Include("Reserve.Sport")
                    .Include("Reserve.Ground.Park")
                    .Include("Users")
                    .ToList();
                return EventsbyGroundt;
            }
        }

        public void UpdateEventRecord(int ReserveId, int maxAge, int minAge, int maxPlayers, DateTime startDate,
            DateTime endDate,string name)
        {
            using (var context = new ModelContext())
            {
                var reserveRecord = context.Reserves
                    .Where(a => a.ReserveId == ReserveId)
                    .Include("Event").ToList();
                reserveRecord[0].Event.MaxAge = maxAge;
                reserveRecord[0].Event.MinAge = minAge;
                reserveRecord[0].Event.MaxPlayers = maxPlayers;
                reserveRecord[0].Event.StartDate = startDate;
                reserveRecord[0].Event.EndDate = endDate;
                reserveRecord[0].Event.Name = name;
                context.SaveChanges();
            }
        }
        public void DeleteEvent(int EventId)
        {
            using (var context = new ModelContext())
            {
                var reserveRecord = context.Reserves
                    .Include("Uses")
                    .Include("Event")
                    .Include("Ground")
                    .Include("Sport")
                    .Include("User")
                    .Where(e => e.Event.EventId == EventId).Single();

                 context.Events.Remove(reserveRecord.Event);
                context.Reserves.Remove(reserveRecord);
                context.SaveChanges();
                

            }
        }

        public void UnregisterUser(int eventId, string username)
        {

            using (var context = new ModelContext())
            {
          
                var events = context.Events.Find(eventId);
                var users = context.Users.Find(username);

                context.Entry(events).Collection("Users").Load();
                events.Users.Remove(users);
                context.SaveChanges();
            }
        }

        public ICollection<User> RetrieveEnrolledUsers(int eventId)
        {
            using (var db = new ModelContext())
            {
                var EnrolledUsers = db.Users
                    .Where(c => c.Events.Any(i => i.EventId == eventId))
                    .Include("UserClassification")
                    .ToList();

                return EnrolledUsers;
            }
        }

        public Event RetrieveSingleEvent(int eventId)
        {
            using (var db = new ModelContext())
            {
                var SingleEvent = db.Events
                    .Where(c => c.EventId == eventId)
                    .Include("Reserve.Ground.Park.Picture")
                    .Include("Reserve.User")
                    .FirstOrDefault();
                return SingleEvent;
            }
        }

        public User RetrieveSingleUser(string username)
        {
            using (var db = new ModelContext())
            {
                var SingleUser = db.Users
                    .Where(c => c.Username.Equals(username))
                    .FirstOrDefault();
                return SingleUser;
            }
        }
        public bool CheckUserInEvent(int eventId, string username)
        {
            var users = RetrieveEnrolledUsers(eventId);
            var u = RetrieveSingleUser(username);
            var result = false;

            foreach (var user in users)
                if (user.Username.Equals(u.Username))
                {
                    result = true;
                    break;
                }

            return result;
        }

        public void JoinEvent(int eventId, string username)
        {
            using (var db = new ModelContext())
            {
                var Event = db.Events
                    .Where(c => c.EventId == eventId)
                    .Include("Users")
                    .FirstOrDefault();

                var SingleUser = db.Users
                    .Where(c => c.Username.Equals(username))
                    .FirstOrDefault();

                Event.Users.Add(SingleUser);
                db.SaveChanges();
            }
        }

        public UC_NextEventsandReserveItem ChangeButtons(int usersCount, int maxUsers, UC_NextEventsandReserveItem listitems, List<User> users, string _username)
        {
            if (usersCount == maxUsers)
                listitems.ChangeJoinEventbtn(false);

            foreach (var user in users)
                if (user.Username == _username)
                {
                    listitems.ChangeJoinEventbtn(false);
                    if (listitems.Owner.Equals(_username))
                    {
                        listitems.ChangeCancelbtn(true);
                    }
                    else
                    {
                        listitems.ChangeJoinEventbtn(false);
                        listitems.BringToFrontUnregister(true);
                    }

                    break;
                }
            return listitems;
        }
        public UC_NextEventsandReserveItem ChangeButtonsReserve(string Username, UC_NextEventsandReserveItem listitems)
        {
            if (Username.Equals(listitems.Owner))
            {
                listitems.ChangeJoinEventbtn(false);
            }
            else
            {
                listitems.ChangeCancelbtn(false);
                listitems.ChangeJoinEventbtn(true);
            }
            return listitems;
        }

    }
}