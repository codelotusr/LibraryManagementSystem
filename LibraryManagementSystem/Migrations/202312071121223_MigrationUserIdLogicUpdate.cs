namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationUserIdLogicUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "UserId" });
            AddColumn("dbo.Users", "UserIdentification", c => c.String(nullable: false));
            DropColumn("dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "UserIdentification");
            CreateIndex("dbo.Users", "UserId", unique: true);
        }
    }
}
