namespace LmycDataLib.Migrations.Boats
{
    using LmycDataLib.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LmycDataLib.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Boats";
        }

        protected override void Seed(LmycDataLib.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(p => p.Id, DummyData.getUser(context).ToArray());
            context.SaveChanges();
            context.Boats.AddOrUpdate(c => c.BoatId, DummyData.getBoat(context).ToArray());
            context.SaveChanges();
        }
    }
}
