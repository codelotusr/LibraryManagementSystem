using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string Venue { get; set; }
        public string Organizer { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
    }
}
