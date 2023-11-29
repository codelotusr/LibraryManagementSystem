﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }
        public int CategoryID { get; set; }
        public string Edition { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ShelfLocation { get; set; }

        // Navigation property for the Category
        public virtual Category Category { get; set; }

        // Navigation property for BorrowingRecords
        public virtual ICollection<BorrowingRecord> BorrowingRecords { get; set; }
    }
}
