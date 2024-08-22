using TictacToee.Exceptions;
using TictacToee.Models;

namespace TictacToee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            ResultAnalyzer analyzer = new ResultAnalyzer(board);

            try
            {
                // Hardcoded player moves
                board.SetCellMark(0, MarkType.X); // Player X
                
                board.SetCellMark(1, MarkType.O); // Player O
                
                board.SetCellMark(3, MarkType.X); // Player X
                
                board.SetCellMark(4, MarkType.O); // Player O
                
                board.SetCellMark(6, MarkType.X); // Player X
                
                //mark a cell thats already marked 
                //board.SetCellMark(0, MarkType.O); // This will throw CellAlreadyMarkedException
            }
            catch (CellAlreadyMarkedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidMarkTypeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }

            ResultType result = analyzer.AnalyzeResult();

            switch (result)
            {
                case ResultType.WIN:
                    Console.WriteLine("Player X Wins!");
                    break;
                case ResultType.DRAW:
                    Console.WriteLine("It's a Draw!");
                    break;
                case ResultType.INPROGRESS:
                    Console.WriteLine("Game is still in progress.");
                    break;
            }
        }
    }


}
