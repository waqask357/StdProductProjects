namespace StdProductProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUserName1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserTable", "ContactNo", c => c.String(maxLength: 150, unicode: false));
            AlterColumn("dbo.UserTable", "Username", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.UserTable", "Password", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserTable", "Password", c => c.String());
            AlterColumn("dbo.UserTable", "Username", c => c.String());
            AlterColumn("dbo.UserTable", "ContactNo", c => c.String());
        }
    }
}
