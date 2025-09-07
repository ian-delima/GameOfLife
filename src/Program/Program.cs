using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] matrix =
            {
                new bool[] { true, false, true },
                new bool[] { false, true, false },
                new bool[] { true, true, false }
            };

            GamePrinter printer = new GamePrinter(matrix);
            printer.PrintMatrix();
        }
    }
}