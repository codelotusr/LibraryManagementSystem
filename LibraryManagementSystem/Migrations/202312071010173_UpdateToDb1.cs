namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToDb1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberTypes",
                c => new
                    {
                        MemberTypeId = c.Int(nullable: false, identity: true),
                        MemberTypeName = c.String(nullable: false, maxLength: 100),
                        MaxBooks = c.Int(nullable: false),
                        MaxDays = c.Int(nullable: false),
                        MaxReservations = c.Int(nullable: false),
                        MaxRenewals = c.Int(nullable: false),
                        MaxReviews = c.Int(nullable: false),
                        MaxEvents = c.Int(nullable: false),
                        MaxRegistrations = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberTypeId)
                .Index(t => t.MemberTypeName, unique: true);
            
            AddColumn("dbo.Users", "MemberType_MemberTypeId", c => c.Int());
            CreateIndex("dbo.Users", "MemberType_MemberTypeId");
            AddForeignKey("dbo.Users", "MemberType_MemberTypeId", "dbo.MemberTypes", "MemberTypeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "MemberType_MemberTypeId", "dbo.MemberTypes");
            DropIndex("dbo.MemberTypes", new[] { "MemberTypeName" });
            DropIndex("dbo.Users", new[] { "MemberType_MemberTypeId" });
            DropColumn("dbo.Users", "MemberType_MemberTypeId");
            DropTable("dbo.MemberTypes");
        }
    }
}
