using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictacToee.Models
{
    internal class Board
    {
        private Cell[] cells;

        public Board()
        {
            cells = new Cell[9];
            for (int i = 0; i < 9; i++)
            {
                cells[i] = new Cell();
            }
        }

        public bool IsBoardFull()
        {
            foreach (var cell in cells)
            {
                if (cell.IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }

        public void SetCellMark(int location, MarkType mark)
        {
            if (location < 0 || location >= 9)
            {
                throw new Exception("InvalidCellLocationException");
            }

            cells[location].SetMark(mark);
            DrawBoard();
            Console.WriteLine();
        }

        public MarkType GetCellMark(int location)
        {
            if (location < 0 || location >= 9)
            {
                throw new Exception("InvalidCellLocationException");
            }

            return cells[location].GetMark();
        }

        public Cell[] GetCells()
        {
            return cells;
        }

        // Method to draw the board in the console
        public void DrawBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                string mark = cells[i].GetMark() == MarkType.EMPTY ? " " : cells[i].GetMark().ToString();
                Console.Write($" {mark} ");

                if (i % 3 != 2) Console.Write("|");

                if (i % 3 == 2 && i < 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("---+---+---");
                }
            }
            Console.WriteLine();
        }
    }





}
