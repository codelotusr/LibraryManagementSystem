namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToUserLogic : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "MemberType_MemberTypeId", "dbo.MemberTypes");
            DropIndex("dbo.Users", new[] { "MemberType_MemberTypeId" });
            DropIndex("dbo.MemberTypes", new[] { "MemberTypeName" });
            AddColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "UserId", unique: true);
            DropColumn("dbo.Users", "MemberType_MemberTypeId");
            DropTable("dbo.MemberTypes");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.MemberTypeId);
            
            AddColumn("dbo.Users", "MemberType_MemberTypeId", c => c.Int());
            DropIndex("dbo.Users", new[] { "UserId" });
            DropColumn("dbo.Users", "UserId");
            CreateIndex("dbo.MemberTypes", "MemberTypeName", unique: true);
            CreateIndex("dbo.Users", "MemberType_MemberTypeId");
            AddForeignKey("dbo.Users", "MemberType_MemberTypeId", "dbo.MemberTypes", "MemberTypeId");
        }
    }
}
