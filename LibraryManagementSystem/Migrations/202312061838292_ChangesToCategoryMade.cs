namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToCategoryMade : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Category", c => c.Int(nullable: false));
        }
    }
}
