namespace LmycDataLib.Migrations
{
    using LmycDataLib.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LmycWebSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(LmycWebSite.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Boats.AddOrUpdate(
                   b => new {
                       b.BoatId,
                       b.BoatName,
                       b.Picture,
                       b.LengthInFeet,
                       b.Make,
                       b.Year,
                       b.RecordCreationDate,
                       b.CreatedBy
                   }, entities: DummyData.getBoats(context).ToArray());
            context.SaveChanges();
        }
    }
}
