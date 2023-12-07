namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserLogicUpdateToDb : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "Email" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Users", "Email", unique: true);
        }
    }
}
