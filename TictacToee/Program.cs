using TictacToee.Models;

namespace TictacToee
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Board board = new Board();
                ResultAnalyzer analyzer = new ResultAnalyzer(board);

                // Hardcoded player moves
                board.SetCellMark(0, MarkType.X); // Player X
                
                board.SetCellMark(1, MarkType.O); // Player O
                
                board.SetCellMark(3, MarkType.X); // Player X
                
                board.SetCellMark(4, MarkType.O); // Player O
                
                board.SetCellMark(6, MarkType.X); // Player X
                
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
