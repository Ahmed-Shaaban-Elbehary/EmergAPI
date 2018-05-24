namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTypeConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EventTypes", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EventTypes", "Name", c => c.String());
        }
    }
}
