using System;
using System.IO;
namespace Ucu.Poo.GameOfLife;

public class Reader // Su responsabilidad es generar una matriz inicial (por ahora a partir de un archivo leído)
{
    public bool[,] FileReader()
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if(contentLines[y][x] == '1')
                {
                    board[y, x] = true;
                }
            }
        }
        return board;
    }
}