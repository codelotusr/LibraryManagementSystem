﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public abstract class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string PasswordHash { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<EventRegistration> EventRegistrations { get; set; }
        public virtual ICollection<BorrowingRecord> BorrowingRecords { get; set; }

        public User()
        {
            Reviews = new HashSet<Review>();
            EventRegistrations = new HashSet<EventRegistration>();
            BorrowingRecords = new HashSet<BorrowingRecord>();
        }
    }   
}