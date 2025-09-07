using System.Threading.Tasks;

namespace Ucu.Poo.GameOfLife;

public class RunGame
using System;
using System.Threading.Tasks;

public class Example
{
    public static void Main()
    {
        var t = Task.Run(async delegate
        {
            await Task.Delay(1000);
            return 42;
        });
        t.Wait();
        for (int i = 0; i <= 200; i++)
        {
            
            await .Delay(500);
        }
    }
}