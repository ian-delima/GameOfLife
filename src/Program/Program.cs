using System;
using System.Threading.Tasks;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var reader = new Reader();
            for (int i = 0; i < 151; i++)
            {
                Console.WriteLine(reader.FileReader());
                Task.Delay(500);
            }

        }
    }
}