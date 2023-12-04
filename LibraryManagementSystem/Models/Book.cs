using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models
{
    public class Book : ILibraryItem
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(100)] public string Title { get; set; }

        [Required] [StringLength(100)] public string Author { get; set; }

        [StringLength(100)] public string Description { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "ISBN must be between 10 and 13 characters long.")]
        [Index(IsUnique = true)]
        public string ISBN { get; set; }

        [Required] public int PublishedYear { get; set; }

        [ForeignKey("Category")]
        [Required] public int CategoryId { get; set; }

        [StringLength(100)] public string Edition { get; set; }

        [DataType(DataType.Currency)] public decimal Price { get; set; }

        [Required] [Range(0, 1000)] public int Quantity { get; set; }

        [StringLength(100)] public string ShelfLocation { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<BorrowingRecord> BorrowingRecords { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Book()
        {
            BorrowingRecords = new HashSet<BorrowingRecord>();
            Reviews = new HashSet<Review>();
            Reservations = new HashSet<Reservation>();
        }

        public string GetSummary()
        {
            return $"Book: {Title} by {Author}, published in {PublishedYear}. ISBN: {ISBN}";
        }

    }
}
