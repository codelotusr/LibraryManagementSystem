﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models
{
    public class Book : ILibraryItem, IFormattable, IComparable<Book>, IEquatable<Book>
    {
        [Key] public int Id { get; set; }

        [Required] [StringLength(100)] public string Title { get; set; }

        [Required] [StringLength(100)] public string Author { get; set; }

        [StringLength(100)] public string Description { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "ISBN must be between 10 and 13 characters long.")]
        [Index(IsUnique = true)]
        public string ISBN { get; set; }

        [Required] public int PublishedYear { get; set; }

        [Required] public string Category { get; set; }

        [StringLength(100)] public string Edition { get; set; }

        [DataType(DataType.Currency)] public decimal Price { get; set; }

        [Required] [Range(0, 1000)] public int Quantity { get; set; }

        [StringLength(100)] public string ShelfLocation { get; set; }

        public virtual ICollection<BorrowingRecord> BorrowingRecords { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }

        public Book()
        {
            BorrowingRecords = new HashSet<BorrowingRecord>();
            Reviews = new HashSet<Review>();
            Reservations = new HashSet<Reservation>();
        }

        public string GetSummary()
        {
            return $"Book: {Title} by {Author}, published in {PublishedYear}. ISBN: {ISBN}";
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "G";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                case "FULL":
                    return $"Title: {Title}, Author: {Author}, Year: {PublishedYear}, ISBN: {ISBN}";
                case "BRIEF":
                    return $"{Title} by {Author}, year {PublishedYear}";
                default:
                    throw new FormatException($"The {format} format string is not supported.");
            }
        }

        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;
            return this.PublishedYear.CompareTo(other.PublishedYear);
        }

        public bool Equals(Book other)
        {
            if (other == null)
                return false;

            return this.ISBN == other.ISBN;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Book bookObj = obj as Book;
            if (bookObj == null)
                return false;
            else
                return Equals(bookObj);
        }

        public override int GetHashCode()
        {
            return this.ISBN.GetHashCode();
        }

        public static bool operator ==(Book left, Book right)
        {
            if (object.ReferenceEquals(left, null))
            {
                return object.ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(Book left, Book right)
        {
            return !(left == right);
        }

    }

}
