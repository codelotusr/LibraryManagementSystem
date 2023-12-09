using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace LibraryManagementSystem.Models
{

    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=librarycontext") { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<BorrowingRecord> BorrowingRecords { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventRegistration> EventRegistrations { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Users")
                .Map<Member>(m => m.Requires("UserType").HasValue("Member"))
                .Map<Staff>(m => m.Requires("UserType").HasValue("Staff"));

            modelBuilder.Entity<BorrowingRecord>()
                .HasRequired(br => br.Book)
                .WithMany(b => b.BorrowingRecords)
                .HasForeignKey(br => br.BookId);

            modelBuilder.Entity<BorrowingRecord>()
                .HasRequired(br => br.Member)
                .WithMany()
                .HasForeignKey(br => br.MemberId);

            modelBuilder.Entity<Reservation>()
                .HasRequired(r => r.Book)
                .WithMany(b => b.Reservations)
                .HasForeignKey(r => r.BookId)
                .WillCascadeOnDelete(false); 

            modelBuilder.Entity<Reservation>()
                .HasRequired(r => r.Member)
                .WithMany()
                .HasForeignKey(r => r.MemberId);

            modelBuilder.Entity<Review>()
                .HasRequired(rv => rv.Book)
                .WithMany()
                .HasForeignKey(rv => rv.BookId);

            modelBuilder.Entity<Review>()
                .HasRequired(rv => rv.Member)
                .WithMany()
                .HasForeignKey(rv => rv.MemberId);

            modelBuilder.Entity<EventRegistration>()
                .HasRequired(er => er.Event)
                .WithMany()
                .HasForeignKey(er => er.EventId);

            modelBuilder.Entity<EventRegistration>()
                .HasRequired(er => er.Member)
                .WithMany()
                .HasForeignKey(er => er.MemberId);
        }

        public IEnumerable<Book> GetBooksByCategory(string category)
        {
            foreach (var book in Books)
            {
                if (book.Category == category)
                {
                    yield return book;
                }
            }
        }
    }


}
