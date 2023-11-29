namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        Description = c.String(),
                        ISBN = c.String(),
                        PublishedYear = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        Edition = c.String(),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ShelfLocation = c.String(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.BorrowingRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        Status = c.String(),
                        BorrowedDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        ReturnedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        RegisteredDate = c.DateTime(nullable: false),
                        Member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .Index(t => t.EventId)
                .Index(t => t.MemberId)
                .Index(t => t.Member_Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Organizer = c.String(),
                        ContactNo = c.String(),
                        Email = c.String(),
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
                        Comment = c.String(),
                        ReviewDate = c.DateTime(nullable: false),
                        Member_Id = c.Int(),
                        Book_BookID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .ForeignKey("dbo.Books", t => t.Book_BookID)
                .Index(t => t.BookId)
                .Index(t => t.MemberId)
                .Index(t => t.Member_Id)
                .Index(t => t.Book_BookID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        Status = c.String(),
                        ReservedDate = c.DateTime(nullable: false),
                        BorrowedDate = c.DateTime(),
                        DueDate = c.DateTime(),
                        ReturnedDate = c.DateTime(),
                        Book_BookID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_BookID)
                .Index(t => t.BookId)
                .Index(t => t.MemberId)
                .Index(t => t.Book_BookID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Book_BookID", "dbo.Books");
            DropForeignKey("dbo.Reservations", "Book_BookID", "dbo.Books");
            DropForeignKey("dbo.Reservations", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Reservations", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.BorrowingRecords", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Reviews", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.Reviews", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Reviews", "BookId", "dbo.Books");
            DropForeignKey("dbo.EventRegistrations", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.EventRegistrations", "MemberId", "dbo.Members");
            DropForeignKey("dbo.EventRegistrations", "EventId", "dbo.Events");
            DropForeignKey("dbo.BorrowingRecords", "BookId", "dbo.Books");
            DropIndex("dbo.Reservations", new[] { "Book_BookID" });
            DropIndex("dbo.Reservations", new[] { "MemberId" });
            DropIndex("dbo.Reservations", new[] { "BookId" });
            DropIndex("dbo.Reviews", new[] { "Book_BookID" });
            DropIndex("dbo.Reviews", new[] { "Member_Id" });
            DropIndex("dbo.Reviews", new[] { "MemberId" });
            DropIndex("dbo.Reviews", new[] { "BookId" });
            DropIndex("dbo.EventRegistrations", new[] { "Member_Id" });
            DropIndex("dbo.EventRegistrations", new[] { "MemberId" });
            DropIndex("dbo.EventRegistrations", new[] { "EventId" });
            DropIndex("dbo.BorrowingRecords", new[] { "MemberId" });
            DropIndex("dbo.BorrowingRecords", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "CategoryID" });
            DropTable("dbo.Reservations");
            DropTable("dbo.Categories");
            DropTable("dbo.Reviews");
            DropTable("dbo.Events");
            DropTable("dbo.EventRegistrations");
            DropTable("dbo.Members");
            DropTable("dbo.BorrowingRecords");
            DropTable("dbo.Books");
        }
    }
}
