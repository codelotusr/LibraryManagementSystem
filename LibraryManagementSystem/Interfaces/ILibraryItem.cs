using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces
{
    public interface ILibraryItem
    {
        int Id { get; }
        string Title { get; }
        string Author { get; }
        int PublishedYear { get; }
        string GetSummary();
    }
}
