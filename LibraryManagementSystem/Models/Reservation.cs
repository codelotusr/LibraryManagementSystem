using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Status { get; set; }
        public DateTime ReservedDate { get; set; }
        public DateTime? BorrowedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
