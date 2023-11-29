using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class EventRegistration
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public int MemberId { get; set; }
        public DateTime RegisteredDate { get; set; }
        public Event Event { get; set; }
        public Member Member { get; set; }
    }
}
