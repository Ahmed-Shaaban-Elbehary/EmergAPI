namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DiseaseConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Diseases", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Diseases", "Name", c => c.String());
            AlterColumn("dbo.Diseases", "Name", c => c.String(maxLength: 10));
        }
    }
}
