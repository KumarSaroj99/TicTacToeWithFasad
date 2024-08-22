using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToee.Exceptions
{
    internal class CellAlreadyMarkedException : Exception
    {
        public CellAlreadyMarkedException()
            : base("Cell is already marked. Please choose an empty cell.") { }
    }
}
