namespace LmycDataLib.Migrations.Boats
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boats",
                c => new
                    {
                        BoatId = c.Int(nullable: false, identity: true),
                        BoatName = c.String(),
                        Picture = c.String(),
                        LengthInFeet = c.Double(nullable: false),
                        Make = c.String(),
                        Year = c.Int(nullable: false),
                        RecordCreationDate = c.DateTime(nullable: false),
                        CreatedBy_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BoatId)
                .ForeignKey("dbo.AspNetUsers", t => t.CreatedBy_Id)
                .Index(t => t.CreatedBy_Id);
            
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "Street", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Province", c => c.String());
            AddColumn("dbo.AspNetUsers", "PostalCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "Country", c => c.String());
            AddColumn("dbo.AspNetUsers", "SaillingExperience", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Boats", "CreatedBy_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Boats", new[] { "CreatedBy_Id" });
            DropColumn("dbo.AspNetUsers", "SaillingExperience");
            DropColumn("dbo.AspNetUsers", "Country");
            DropColumn("dbo.AspNetUsers", "PostalCode");
            DropColumn("dbo.AspNetUsers", "Province");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Street");
            DropColumn("dbo.AspNetUsers", "MobileNumber");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropTable("dbo.Boats");
        }
    }
}
