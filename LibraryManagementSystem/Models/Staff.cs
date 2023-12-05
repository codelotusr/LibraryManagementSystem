using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Staff : User
    {
        [Index(IsUnique = true)]
        [Required]
        public int StaffNumber { get; set; }

        [Required]
        public Boolean isAdmin { get; set; }

        public Staff()
        {
        }
    }
}
