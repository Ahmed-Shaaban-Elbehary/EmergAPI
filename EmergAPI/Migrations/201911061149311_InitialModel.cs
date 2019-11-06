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
                        Name = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Diseases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
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
                        EventType = c.Int(nullable: false),
                        IsProcessed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Operators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        Password = c.String(nullable: false, maxLength: 255),
                        ConfirmPassword = c.String(nullable: false, maxLength: 255),
                        IdentificationNumber = c.Int(),
                        MobilePhone = c.Int(),
                        Birthdate = c.String(),
                        Hiredate = c.String(),
                        Salary = c.Decimal(storeType: "smallmoney"),
                        IsAdmin = c.Boolean(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                        Password = c.String(maxLength: 255),
                        ConfirmPassword = c.String(maxLength: 255),
                        Email = c.String(maxLength: 255),
                        Birthdate = c.String(),
                        mobileNo = c.Int(),
                        UpImage = c.String(maxLength: 1000),
                        Height = c.Decimal(precision: 9, scale: 2),
                        Weight = c.Decimal(precision: 9, scale: 2),
                        Gender = c.Int(nullable: false),
                        bloodType_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Operators");
            DropTable("dbo.Events");
            DropTable("dbo.Diseases");
            DropTable("dbo.BloodTypes");
        }
    }
}
