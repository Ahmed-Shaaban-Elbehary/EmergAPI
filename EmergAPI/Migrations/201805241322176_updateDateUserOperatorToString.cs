namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDateUserOperatorToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Birthdate", c => c.String());
            AlterColumn("dbo.Operators", "Birthdate", c => c.String());
            AlterColumn("dbo.Operators", "Hiredate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Operators", "Hiredate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Operators", "Birthdate", c => c.DateTime(storeType: "date"));
            AlterColumn("dbo.Users", "Birthdate", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
