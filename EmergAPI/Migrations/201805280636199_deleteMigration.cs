namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "bloodType_Id", "dbo.BloodTypes");
            DropForeignKey("dbo.UsersDiseases", "UserId", "dbo.Users");
            DropForeignKey("dbo.UsersDiseases", "DiseaseId", "dbo.Diseases");
            DropIndex("dbo.Users", new[] { "bloodType_Id" });
            DropIndex("dbo.UsersDiseases", new[] { "UserId" });
            DropIndex("dbo.UsersDiseases", new[] { "DiseaseId" });
            DropTable("dbo.UsersDiseases");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UsersDiseases",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        DiseaseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.DiseaseId });
            
            CreateIndex("dbo.UsersDiseases", "DiseaseId");
            CreateIndex("dbo.UsersDiseases", "UserId");
            CreateIndex("dbo.Users", "bloodType_Id");
            AddForeignKey("dbo.UsersDiseases", "DiseaseId", "dbo.Diseases", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UsersDiseases", "UserId", "dbo.Users", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Users", "bloodType_Id", "dbo.BloodTypes", "Id", cascadeDelete: true);
        }
    }
}
