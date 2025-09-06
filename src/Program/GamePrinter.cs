namespace Ucu.Poo.GameOfLife;


public class GamePrinter
{
    private Gameboard board;
    
    public GamePrinter (GameBoard board) //Defino método constructor de un objeto board del tipo GameBoard
    {
        this.board = board;
    }

    public void PrintMatrix()
    {
        foreach (var row in board.matrix) 
        {
            foreach (var cell in row)
            {
                
                if (cell)           
                {
                    Console.Write("|X|"); 
                }
                else
                {
                    Console.Write("---");
                }
            }
            Console.WriteLine();
        }
    }
}
