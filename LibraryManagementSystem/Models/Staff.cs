using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    internal class Staff : User
    {
        [Index(IsUnique = true)]
        [Required]
        public string StaffId { get; set; }

        public Staff()
        {
        }
    }
}
