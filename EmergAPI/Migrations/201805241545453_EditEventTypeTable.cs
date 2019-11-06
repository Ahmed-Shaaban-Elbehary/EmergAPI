namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditEventTypeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "EvenTypetId", "dbo.EventTypes");
            DropIndex("dbo.Events", new[] { "EvenTypetId" });
            AddColumn("dbo.Events", "EventType", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "EvenTypetId");
            DropTable("dbo.EventTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Events", "EvenTypetId", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "EventType");
            CreateIndex("dbo.Events", "EvenTypetId");
            AddForeignKey("dbo.Events", "EvenTypetId", "dbo.EventTypes", "Id", cascadeDelete: true);
        }
    }
}
