namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        Email = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        mobileNo = c.Int(),
                        UpImage = c.String(),
                        Height = c.Decimal(precision: 18, scale: 2),
                        Weight = c.Decimal(precision: 18, scale: 2),
                        DiseaseId = c.Int(nullable: false),
                        BloodType_Id = c.Int(),
                        Gender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodTypes", t => t.BloodType_Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .Index(t => t.BloodType_Id)
                .Index(t => t.Gender_Id);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        dateTime = c.String(),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EventType_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventTypes", t => t.EventType_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.EventType_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Operators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        ConfirmPassword = c.String(),
                        IdentificationNumber = c.Int(),
                        MobilePhone = c.Int(),
                        Birthdate = c.DateTime(nullable: false),
                        Hiredate = c.DateTime(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsAdmin = c.Boolean(nullable: false),
                        Gender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .Index(t => t.Gender_Id);
            
            CreateTable(
                "dbo.DiseaseUsers",
                c => new
                    {
                        Disease_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Disease_Id, t.User_Id })
                .ForeignKey("dbo.Diseases", t => t.Disease_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Disease_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Operators", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Events", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes");
            DropForeignKey("dbo.DiseaseUsers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.DiseaseUsers", "Disease_Id", "dbo.Diseases");
            DropForeignKey("dbo.Users", "BloodType_Id", "dbo.BloodTypes");
            DropIndex("dbo.DiseaseUsers", new[] { "User_Id" });
            DropIndex("dbo.DiseaseUsers", new[] { "Disease_Id" });
            DropIndex("dbo.Operators", new[] { "Gender_Id" });
            DropIndex("dbo.Events", new[] { "User_Id" });
            DropIndex("dbo.Events", new[] { "EventType_Id" });
            DropIndex("dbo.Users", new[] { "Gender_Id" });
            DropIndex("dbo.Users", new[] { "BloodType_Id" });
            DropTable("dbo.DiseaseUsers");
            DropTable("dbo.Operators");
            DropTable("dbo.Genders");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Diseases");
            DropTable("dbo.Users");
            DropTable("dbo.BloodTypes");
        }
    }
}
