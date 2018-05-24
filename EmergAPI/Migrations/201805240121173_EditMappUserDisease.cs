namespace EmergAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditMappUserDisease : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserDisease", name: "UserId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UserDisease", name: "DiseaseId", newName: "UserId");
            RenameColumn(table: "dbo.UserDisease", name: "__mig_tmp__0", newName: "DiseaseId");
            RenameIndex(table: "dbo.UserDisease", name: "IX_UserId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UserDisease", name: "IX_DiseaseId", newName: "IX_UserId");
            RenameIndex(table: "dbo.UserDisease", name: "__mig_tmp__0", newName: "IX_DiseaseId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserDisease", name: "IX_DiseaseId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.UserDisease", name: "IX_UserId", newName: "IX_DiseaseId");
            RenameIndex(table: "dbo.UserDisease", name: "__mig_tmp__0", newName: "IX_UserId");
            RenameColumn(table: "dbo.UserDisease", name: "DiseaseId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.UserDisease", name: "UserId", newName: "DiseaseId");
            RenameColumn(table: "dbo.UserDisease", name: "__mig_tmp__0", newName: "UserId");
        }
    }
}
