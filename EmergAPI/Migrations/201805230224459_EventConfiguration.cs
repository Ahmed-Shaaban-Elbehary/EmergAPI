namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventConfiguration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EventType_Id" });
            RenameColumn(table: "dbo.Events", name: "EventType_Id", newName: "EvenTypetId");
            AlterColumn("dbo.Events", "EvenTypetId", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "EvenTypetId");
            AddForeignKey("dbo.Events", "EvenTypetId", "dbo.EventTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EvenTypetId", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EvenTypetId" });
            AlterColumn("dbo.Events", "EvenTypetId", c => c.Int());
            RenameColumn(table: "dbo.Events", name: "EvenTypetId", newName: "EventType_Id");
            CreateIndex("dbo.Events", "EventType_Id");
            AddForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes", "Id");
        }
    }
}
