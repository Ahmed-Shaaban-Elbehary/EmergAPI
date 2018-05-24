namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserConfiguration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DiseaseUsers", newName: "UserDisease");
            DropForeignKey("dbo.Users", "BloodType_Id", "dbo.BloodTypes");
            DropForeignKey("dbo.Events", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "BloodType_Id" });
            DropIndex("dbo.Users", new[] { "Gender_Id" });
            DropIndex("dbo.Events", new[] { "User_Id" });
            RenameColumn(table: "dbo.Users", name: "BloodType_Id", newName: "BloodTypeId");
            RenameColumn(table: "dbo.UserDisease", name: "Disease_Id", newName: "DiseaseId");
            RenameColumn(table: "dbo.UserDisease", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Events", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Users", name: "Gender_Id", newName: "GenderId");
            RenameIndex(table: "dbo.UserDisease", name: "IX_User_Id", newName: "IX_UserId");
            RenameIndex(table: "dbo.UserDisease", name: "IX_Disease_Id", newName: "IX_DiseaseId");
            DropPrimaryKey("dbo.UserDisease");
            AlterColumn("dbo.Users", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 255));
            AlterColumn("dbo.Users", "ConfirmPassword", c => c.String(maxLength: 255));
            AlterColumn("dbo.Users", "Email", c => c.String(maxLength: 255));
            AlterColumn("dbo.Users", "Birthdate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Users", "UpImage", c => c.String(maxLength: 1000));
            AlterColumn("dbo.Users", "Height", c => c.Decimal(precision: 9, scale: 2));
            AlterColumn("dbo.Users", "Weight", c => c.Decimal(precision: 9, scale: 2));
            AlterColumn("dbo.Users", "BloodTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "GenderId", c => c.Int(nullable: false));
            AlterColumn("dbo.Events", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.UserDisease", new[] { "UserId", "DiseaseId" });
            CreateIndex("dbo.Users", "BloodTypeId");
            CreateIndex("dbo.Users", "GenderId");
            CreateIndex("dbo.Events", "UserId");
            AddForeignKey("dbo.Users", "BloodTypeId", "dbo.BloodTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Events", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Events", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "BloodTypeId", "dbo.BloodTypes");
            DropIndex("dbo.Events", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "GenderId" });
            DropIndex("dbo.Users", new[] { "BloodTypeId" });
            DropPrimaryKey("dbo.UserDisease");
            AlterColumn("dbo.Events", "UserId", c => c.Int());
            AlterColumn("dbo.Users", "GenderId", c => c.Int());
            AlterColumn("dbo.Users", "BloodTypeId", c => c.Int());
            AlterColumn("dbo.Users", "Weight", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Users", "Height", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Users", "UpImage", c => c.String());
            AlterColumn("dbo.Users", "Birthdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
            AddPrimaryKey("dbo.UserDisease", new[] { "Disease_Id", "User_Id" });
            RenameIndex(table: "dbo.UserDisease", name: "IX_DiseaseId", newName: "IX_Disease_Id");
            RenameIndex(table: "dbo.UserDisease", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Users", name: "GenderId", newName: "Gender_Id");
            RenameColumn(table: "dbo.Events", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.UserDisease", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.UserDisease", name: "DiseaseId", newName: "Disease_Id");
            RenameColumn(table: "dbo.Users", name: "BloodTypeId", newName: "BloodType_Id");
            CreateIndex("dbo.Events", "User_Id");
            CreateIndex("dbo.Users", "Gender_Id");
            CreateIndex("dbo.Users", "BloodType_Id");
            AddForeignKey("dbo.Users", "Gender_Id", "dbo.Genders", "Id");
            AddForeignKey("dbo.Events", "User_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "BloodType_Id", "dbo.BloodTypes", "Id");
            RenameTable(name: "dbo.UserDisease", newName: "DiseaseUsers");
        }
    }
}
