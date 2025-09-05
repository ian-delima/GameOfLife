using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var reader = new FileReader();
            Console.WriteLine(reader.Reader());
            

        }
    }
}
