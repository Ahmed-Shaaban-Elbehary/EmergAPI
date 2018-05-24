namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OperatorConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Operators", "Gender_Id", "dbo.Genders");
            DropIndex("dbo.Operators", new[] { "Gender_Id" });
            RenameColumn(table: "dbo.Operators", name: "Gender_Id", newName: "GenderId");
            AlterColumn("dbo.Operators", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Operators", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Operators", "Password", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Operators", "ConfirmPassword", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Operators", "Birthdate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Operators", "Hiredate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Operators", "Salary", c => c.Decimal(storeType: "smallmoney"));
            AlterColumn("dbo.Operators", "GenderId", c => c.Int(nullable: false));
            CreateIndex("dbo.Operators", "GenderId");
            AddForeignKey("dbo.Operators", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Operators", "GenderId", "dbo.Genders");
            DropIndex("dbo.Operators", new[] { "GenderId" });
            AlterColumn("dbo.Operators", "GenderId", c => c.Int());
            AlterColumn("dbo.Operators", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Operators", "Hiredate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Operators", "Birthdate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Operators", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Operators", "Password", c => c.String());
            AlterColumn("dbo.Operators", "Email", c => c.String());
            AlterColumn("dbo.Operators", "Name", c => c.String());
            RenameColumn(table: "dbo.Operators", name: "GenderId", newName: "Gender_Id");
            CreateIndex("dbo.Operators", "Gender_Id");
            AddForeignKey("dbo.Operators", "Gender_Id", "dbo.Genders", "Id");
        }
    }
}
