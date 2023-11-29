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
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
