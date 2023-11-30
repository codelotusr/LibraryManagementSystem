using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class BorrowingRecord
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }

        [Required]
        public BorrowingStatus Status { get; set; } 

        [Required]
        [DataType(DataType.Date)]
        public DateTime BorrowedDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReturnedDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual Member Member { get; set; }
    }

    public enum BorrowingStatus
    {
        Borrowed,
        Returned,
        Overdue
    }

}
