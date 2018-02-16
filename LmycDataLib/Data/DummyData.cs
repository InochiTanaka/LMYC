using LmycDataLib;
using LmycWebSite.Models;
using System;
using System.Collections.Generic;

namespace LmycDataLib.Data
{
    public class DummyData
    {
        public static List<Boat> getBoats(ApplicationDbContext context)
        {
            List<Boat> boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatId = "A00111111",
                    BoatName= "John",
                    Picture = "pic01",
                    LengthInFeet = 18,
                    Make = "",
                    Year = 2018,
                    RecordCreationDate = DateTime.Now,
                    CreatedBy = "Inochi Tanaka",
                },
            };
            return boats;
        }
    }
}