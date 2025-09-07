using System.Threading.Tasks;
using Ucu.Poo.GameOfLife;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader(); // Instanciamos Reader
            GameBoard game = new GameBoard(20, 20, reader.FileReader()); // Generamos nueva GameBoard y le pasamos la matriz leída desde el FileReader
            for (int i = 0; i < 50; i++) // 50 veces
            {
                GamePrinter printer = new GamePrinter(game.NewGen()); // Hacemos un nuevo GamePrinter con la matriz de la nueva generación
                printer.PrintMatrix(); // Lo mandamos a imprimir
                Task.Delay(500).Wait(); // Esperamos medio segundo para ver la diferencia
            }
        }
    }
}