using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public ReservationStatus Status { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReservedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BorrowedDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReturnedDate { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }

    }

    public enum ReservationStatus
    {
        Reserved,
        Borrowed,
        Returned,
        Overdue
    }
}
