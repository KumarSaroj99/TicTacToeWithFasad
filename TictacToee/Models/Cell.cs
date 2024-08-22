using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TictacToee.Exceptions;

namespace TictacToee.Models
{
    internal class Cell
    {
        private MarkType mark;

        public Cell()
        {
            mark = MarkType.EMPTY;
        }

        public bool IsEmpty()
        {
            return mark == MarkType.EMPTY;
        }

        public MarkType GetMark()
        {
            return mark;
        }

        public void SetMark(MarkType mark)
        {
            if (mark != MarkType.X && mark != MarkType.O)
            {
                throw new InvalidMarkTypeException();
            }
            if (!IsEmpty())
            {
                throw new CellAlreadyMarkedException();
            }
            this.mark = mark;
        }

        public void ClearAllMarks()
        {
            mark = MarkType.EMPTY;
        }
    }


}
