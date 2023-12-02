using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        [DataType(DataType.Date)]
        public DateTime RegisteredDate { get; set; }
        public virtual Event Event { get; set; }
        public virtual Member Member { get; set; }
    }
}
