using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToee.Models
{
    internal class ResultAnalyzer
    {
        private Board board;
        private ResultType result;

        public ResultAnalyzer(Board board)
        {
            this.board = board;
            this.result = ResultType.INPROGRESS;
        }

        public ResultType AnalyzeResult()
        {
            if (HorizontalWinCheck() || VerticalWinCheck() || DiagonalWinCheck())
            {
                return result;
            }
            else if (board.IsBoardFull())
            {
                result = ResultType.DRAW;
            }
            else
            {
                result = ResultType.INPROGRESS;
            }

            return result;
        }

        private bool HorizontalWinCheck()
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (board.GetCellMark(i) == board.GetCellMark(i + 1) &&
                    board.GetCellMark(i + 1) == board.GetCellMark(i + 2) &&
                    board.GetCellMark(i) != MarkType.EMPTY)
                {
                    result = (board.GetCellMark(i) == MarkType.X) ? ResultType.WIN : ResultType.LOOSE;
                    return true;
                }
            }
            return false;
        }

        private bool VerticalWinCheck()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board.GetCellMark(i) == board.GetCellMark(i + 3) &&
                    board.GetCellMark(i + 3) == board.GetCellMark(i + 6) &&
                    board.GetCellMark(i) != MarkType.EMPTY)
                {
                    result = (board.GetCellMark(i) == MarkType.X) ? ResultType.WIN : ResultType.LOOSE;
                    return true;
                }
            }
            return false;
        }

        private bool DiagonalWinCheck()
        {
            if (board.GetCellMark(0) == board.GetCellMark(4) &&
                board.GetCellMark(4) == board.GetCellMark(8) &&
                board.GetCellMark(0) != MarkType.EMPTY)
            {
                result = (board.GetCellMark(0) == MarkType.X) ? ResultType.WIN : ResultType.LOOSE;
                return true;
            }

            if (board.GetCellMark(2) == board.GetCellMark(4) &&
                board.GetCellMark(4) == board.GetCellMark(6) &&
                board.GetCellMark(2) != MarkType.EMPTY)
            {
                result = (board.GetCellMark(2) == MarkType.X) ? ResultType.WIN : ResultType.LOOSE;
                return true;
            }

            return false;
        }
    }


}
