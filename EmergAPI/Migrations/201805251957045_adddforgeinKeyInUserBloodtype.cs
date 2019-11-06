namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddforgeinKeyInUserBloodtype : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "BloodTypeId", newName: "bloodType_Id");
            RenameIndex(table: "dbo.Users", name: "IX_BloodTypeId", newName: "IX_bloodType_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "IX_bloodType_Id", newName: "IX_BloodTypeId");
            RenameColumn(table: "dbo.Users", name: "bloodType_Id", newName: "BloodTypeId");
        }
    }
}
