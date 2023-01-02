namespace StdProductProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUserName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.UserModels", newName: "UserTable");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserTable", newName: "UserModels");
        }
    }
}
