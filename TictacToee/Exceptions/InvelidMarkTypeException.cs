using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToee.Exceptions
{
    internal class InvalidMarkTypeException : Exception
    {
        public InvalidMarkTypeException()
            : base("Invalid mark type. Only X and O are allowed.") { }
    }
}
