using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryManagementSystem.Models
{

    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryDBConnectionString")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
