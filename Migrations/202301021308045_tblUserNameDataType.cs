namespace StdProductProjects.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tblUserNameDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserTable", "FullName", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserTable", "FullName", c => c.String());
        }
    }
}
