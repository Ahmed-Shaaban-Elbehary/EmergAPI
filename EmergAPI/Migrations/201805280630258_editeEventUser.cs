namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editeEventUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "UserId", "dbo.Users");
            DropIndex("dbo.Events", new[] { "UserId" });
            DropColumn("dbo.Events", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "UserId");
            AddForeignKey("dbo.Events", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
