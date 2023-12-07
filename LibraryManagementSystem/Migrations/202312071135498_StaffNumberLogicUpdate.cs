namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StaffNumberLogicUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Users", new[] { "StaffNumber" });
            AlterColumn("dbo.Users", "StaffNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "StaffNumber", c => c.Int());
            CreateIndex("dbo.Users", "StaffNumber", unique: true);
        }
    }
}
