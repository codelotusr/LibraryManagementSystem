using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models
{
    public class Magazine : ILibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; }
        public int PublishedYear { get; }
        public string Publisher { get; set; }

        public string GetSummary()
        {
            return $"Magazine: {Title} by {Publisher}";
        }

    }
}
