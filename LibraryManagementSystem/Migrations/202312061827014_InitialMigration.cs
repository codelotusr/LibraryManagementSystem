namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Author = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 100),
                        ISBN = c.String(nullable: false, maxLength: 13),
                        PublishedYear = c.Int(nullable: false),
                        Category = c.Int(nullable: false),
                        Edition = c.String(maxLength: 100),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        ShelfLocation = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.ISBN, unique: true);
            
            CreateTable(
                "dbo.BorrowingRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        BorrowedDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        ReturnedDate = c.DateTime(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.BookId)
                .Index(t => t.MemberId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        PasswordHash = c.String(nullable: false, maxLength: 100),
                        StaffNumber = c.Int(),
                        isAdmin = c.Boolean(),
                        UserType = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true)
                .Index(t => t.StaffNumber, unique: true);
            
            CreateTable(
                "dbo.EventRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        RegisteredDate = c.DateTime(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.EventId)
                .Index(t => t.MemberId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 150),
                        EventDate = c.DateTime(nullable: false),
                        EventTime = c.Time(nullable: false, precision: 7),
                        Venue = c.String(nullable: false, maxLength: 100),
                        Organizer = c.String(nullable: false, maxLength: 100),
                        ContactNo = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 100),
                        ReviewDate = c.DateTime(nullable: false),
                        Book_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.BookId)
                .Index(t => t.MemberId)
                .Index(t => t.Book_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        ReservedDate = c.DateTime(nullable: false),
                        BorrowedDate = c.DateTime(),
                        DueDate = c.DateTime(),
                        ReturnedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId)
                .ForeignKey("dbo.Users", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "User_Id", "dbo.Users");
            DropForeignKey("dbo.EventRegistrations", "User_Id", "dbo.Users");
            DropForeignKey("dbo.BorrowingRecords", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Reviews", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Reservations", "MemberId", "dbo.Users");
            DropForeignKey("dbo.Reservations", "BookId", "dbo.Books");
            DropForeignKey("dbo.BorrowingRecords", "MemberId", "dbo.Users");
            DropForeignKey("dbo.Reviews", "MemberId", "dbo.Users");
            DropForeignKey("dbo.Reviews", "BookId", "dbo.Books");
            DropForeignKey("dbo.EventRegistrations", "MemberId", "dbo.Users");
            DropForeignKey("dbo.EventRegistrations", "EventId", "dbo.Events");
            DropForeignKey("dbo.BorrowingRecords", "BookId", "dbo.Books");
            DropIndex("dbo.Reservations", new[] { "MemberId" });
            DropIndex("dbo.Reservations", new[] { "BookId" });
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            DropIndex("dbo.Reviews", new[] { "Book_Id" });
            DropIndex("dbo.Reviews", new[] { "MemberId" });
            DropIndex("dbo.Reviews", new[] { "BookId" });
            DropIndex("dbo.EventRegistrations", new[] { "User_Id" });
            DropIndex("dbo.EventRegistrations", new[] { "MemberId" });
            DropIndex("dbo.EventRegistrations", new[] { "EventId" });
            DropIndex("dbo.Users", new[] { "StaffNumber" });
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.BorrowingRecords", new[] { "User_Id" });
            DropIndex("dbo.BorrowingRecords", new[] { "MemberId" });
            DropIndex("dbo.BorrowingRecords", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "ISBN" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Reviews");
            DropTable("dbo.Events");
            DropTable("dbo.EventRegistrations");
            DropTable("dbo.Users");
            DropTable("dbo.BorrowingRecords");
            DropTable("dbo.Books");
        }
    }
}
