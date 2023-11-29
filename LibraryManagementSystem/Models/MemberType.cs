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
        public string MemberTypeName { get; set; }
        public int MaxBooks { get; set; }
        public int MaxDays { get; set; }
        public int MaxReservations { get; set; }
        public int MaxRenewals { get; set; }
        public int MaxReviews { get; set; }
        public int MaxEvents { get; set; }
        public int MaxRegistrations { get; set; }
    }
}
