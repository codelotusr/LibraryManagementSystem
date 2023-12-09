using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class BorrowedBookDetails
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }
        public string Category { get; set; }
        public string Edition { get; set; }
        public string Description { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
