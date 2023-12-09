using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Exceptions
{
    public class EntityOperationException : Exception
    {

        public EntityOperationException(string message) : base(message)
        {

        }

        public EntityOperationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
