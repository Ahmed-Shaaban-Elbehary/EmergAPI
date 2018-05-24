namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditeRelationBetweenUserOperatorAndGender : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Operators", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Users", "GenderId", "dbo.Genders");
            DropIndex("dbo.Users", new[] { "GenderId" });
            DropIndex("dbo.Operators", new[] { "GenderId" });
            AddColumn("dbo.Users", "Gender", c => c.Int(nullable: false));
            AddColumn("dbo.Operators", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "DiseaseId");
            DropColumn("dbo.Users", "GenderId");
            DropColumn("dbo.Diseases", "UserId");
            DropColumn("dbo.Operators", "GenderId");
            DropTable("dbo.Genders");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Operators", "GenderId", c => c.Int(nullable: false));
            AddColumn("dbo.Diseases", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "GenderId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "DiseaseId", c => c.Int(nullable: false));
            DropColumn("dbo.Operators", "Gender");
            DropColumn("dbo.Users", "Gender");
            CreateIndex("dbo.Operators", "GenderId");
            CreateIndex("dbo.Users", "GenderId");
            AddForeignKey("dbo.Users", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Operators", "GenderId", "dbo.Genders", "Id", cascadeDelete: true);
        }
    }
}
