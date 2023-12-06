using LibraryManagementSystem.EntityUtils;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class ServiceLocator
    {
        public static LibraryContext LibraryContext { get; private set; }
        public static GenericEntity GenericEntity { get; private set; }

        public static void InitializeServices()
        {
            LibraryContext = new LibraryContext();
            GenericEntity = new GenericEntity(LibraryContext);
        }
    }
}
