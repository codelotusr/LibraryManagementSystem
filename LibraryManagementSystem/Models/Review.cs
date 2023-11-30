using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
