namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsporcessedInEventTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "IsProcessed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "IsProcessed");
        }
    }
}
