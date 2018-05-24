namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BloodTypeConfiguration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BloodTypes", "Name", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BloodTypes", "Name", c => c.String());
        }
    }
}
