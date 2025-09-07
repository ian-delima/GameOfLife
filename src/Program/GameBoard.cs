using System.Collections.Generic;

namespace Ucu.Poo.GameOfLife;

public class GameBoard // Su responsabilidad es conocer las dimensiones del tablero, generarlo y crear una nueva generación para el mismo
{
    private int height;
    private int width;
    private bool[,] matrix;

    public GameBoard(int height, int width, bool[,] initialMatrix)
    {
        this.height = height;
        this.width = width;
        this.matrix = initialMatrix;
    }

    public void NewGen()
    {
        bool[,] cloneboard = new bool[width, height];
        cloneboard = new bool[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < width && j >= 0 && j < height && matrix[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (matrix[x, y])
                {
                    aliveNeighbors--;
                }

                if (matrix[x, y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x, y] = false;
                }
                else if (matrix[x, y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y] = false;
                }
                else if (!matrix[x, y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y] = matrix[x, y];
                }
            }
        }

        this.matrix = cloneboard;
    }
}