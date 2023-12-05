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
                        CategoryId = c.Int(nullable: false),
                        Edition = c.String(maxLength: 100),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        ShelfLocation = c.String(maxLength: 100),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.ISBN, unique: true)
                .Index(t => t.CategoryId)
                .Index(t => t.Category_Id);
            
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
                        Member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.MemberId)
                .Index(t => t.Member_Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 100),
                        Address = c.String(nullable: false, maxLength: 100),
                        PasswordHash = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
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
                        Member_Id = c.Int(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.Member_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.BookId)
                .Index(t => t.MemberId)
                .Index(t => t.Member_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.CategoryName, unique: true);
            
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
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.MemberId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Reservations", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Reservations", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Books", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.BorrowingRecords", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Reviews", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.Reviews", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Reviews", "BookId", "dbo.Books");
            DropForeignKey("dbo.EventRegistrations", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.EventRegistrations", "MemberId", "dbo.Members");
            DropForeignKey("dbo.EventRegistrations", "EventId", "dbo.Events");
            DropForeignKey("dbo.BorrowingRecords", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.BorrowingRecords", "BookId", "dbo.Books");
            DropIndex("dbo.Reservations", new[] { "MemberId" });
            DropIndex("dbo.Reservations", new[] { "BookId" });
            DropIndex("dbo.Categories", new[] { "CategoryName" });
            DropIndex("dbo.Reviews", new[] { "Book_Id" });
            DropIndex("dbo.Reviews", new[] { "Member_Id" });
            DropIndex("dbo.Reviews", new[] { "MemberId" });
            DropIndex("dbo.Reviews", new[] { "BookId" });
            DropIndex("dbo.EventRegistrations", new[] { "Member_Id" });
            DropIndex("dbo.EventRegistrations", new[] { "MemberId" });
            DropIndex("dbo.EventRegistrations", new[] { "EventId" });
            DropIndex("dbo.Members", new[] { "Email" });
            DropIndex("dbo.BorrowingRecords", new[] { "Member_Id" });
            DropIndex("dbo.BorrowingRecords", new[] { "MemberId" });
            DropIndex("dbo.BorrowingRecords", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "Category_Id" });
            DropIndex("dbo.Books", new[] { "CategoryId" });
            DropIndex("dbo.Books", new[] { "ISBN" });
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
