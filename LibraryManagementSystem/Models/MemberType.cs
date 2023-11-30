using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class MemberType
    {
        [Key]
        public int MemberTypeId { get; set; }
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string MemberTypeName { get; set; }
        [Required]
        [Range(0, 100)]
        public int MaxBooks { get; set; }
        [Required]
        [Range(0, 90)]
        public int MaxDays { get; set; }
        [Required]
        [Range(0, 100)]
        public int MaxReservations { get; set; }
        [Required]
        [Range(0, 15)]
        public int MaxRenewals { get; set; }
        [Required]
        [Range(0, 100)]
        public int MaxReviews { get; set; }
        [Required]
        [Range(0, 100)]
        public int MaxEvents { get; set; }
        [Required]
        [Range(0, 100)]
        public int MaxRegistrations { get; set; }

        public virtual ICollection<Member> Members { get; set; }

        public MemberType()
        {
            Members = new HashSet<Member>();
        }
    }
}
