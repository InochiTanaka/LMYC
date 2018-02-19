using LmycDataLib;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LmycDataLib.Data
{
    public class DummyData
    {
        public static List<ApplicationUser> getUser(ApplicationDbContext context)
        {
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var user1 = new ApplicationUser();
            var user2 = new ApplicationUser();
            var user3 = new ApplicationUser();
            List<ApplicationUser> users = new List<ApplicationUser>();

            user1.UserName = "haomingkai";
            user1.Email = "haomingkai@gmail.com";
            string user1PWD = "P@$$w0rd";
            user1.FirstName = "Benjamin";
            user1.LastName = "Hao";
            user1.EmailConfirmed = true;
            user1.MobileNumber = "7780000001";
            user1.Street = "1st St.";
            user1.City = "Burnaby";
            user1.Province = "BC";
            user1.PostalCode = "A1AA1A";
            user1.Country = "Canada";
            user1.SaillingExperience = "None";
            UserManager.Create(user1, user1PWD);


            user2.UserName = "Ed";
            user2.Email = "Ed@gmail.com";
            string user2PWD = "P@$$w0rd";
            user2.FirstName = "Ed";
            user2.LastName = "Smith";
            user2.EmailConfirmed = true;
            user2.MobileNumber = "7780000002";
            user2.Street = "2nd St.";
            user2.City = "Burnaby";
            user2.Province = "BC";
            user2.PostalCode = "A2AA2A";
            user2.Country = "Canada";
            user2.SaillingExperience = "1 Year";
            UserManager.Create(user2, user2PWD);


            user3.UserName = "m";
            user3.Email = "m@gmail.com";
            string user3PWD = "P@$$w0rd";
            user3.FirstName = "m";
            user3.LastName = "m";
            user3.EmailConfirmed = true;
            user3.MobileNumber = "7780000003";
            user3.Street = "3rd St.";
            user3.City = "Vancouver";
            user3.Province = "BC";
            user3.PostalCode = "B3BB3B";
            user3.Country = "Canada";
            UserManager.Create(user3, user3PWD);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            //UserManager.AddToRole(user3.Id, "Member");
            return users;
        }

        public static List<Boat> getBoat(ApplicationDbContext context)
        {
            List<Boat> Boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatName = "Marquis 420 Sport Coupe",
                    Picture = "http://images.boats.com/resize/1/87/46/6298746_20170713143815495_1_LARGE.jpg?w=900&h=900",
                    LengthInFeet = 41.99,
                    Make = "Marquis",
                    Year = 2011,
                    RecordCreationDate = new DateTime(2018,1,1),
                },

                                new Boat()
                {
                    BoatName = "Wendon Sky Lounge",
                    Picture = "http://images.boats.com/resize/1/87/46/6298746_20170713143815495_1_LARGE.jpg?w=900&h=900",
                    LengthInFeet = 72.99,
                    Make = "Wendon",
                    Year = 2004,
                    RecordCreationDate = new DateTime(2018,1,2),
                },

                                               new Boat()
                {
                    BoatName = "Bavaria Cruiser 46",
                    Picture = "http://images.boats.com/resize/1/87/46/6298746_20170713143815495_1_LARGE.jpg?w=900&h=900",
                    LengthInFeet = 45.99,
                    Make = "Bavaria",
                    Year = 2018,
                    RecordCreationDate = new DateTime(2018,1,3),
                },

            };
            return Boats;
        }
    }
}