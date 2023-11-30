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
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(150)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public TimeSpan EventTime { get; set; }
        [Required]
        [StringLength(100)]
        public string Venue { get; set; }
        [Required]
        [StringLength(100)]
        public string Organizer { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }
        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
