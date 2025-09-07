using System;

namespace Ucu.Poo.GameOfLife;

public class GamePrinter //Declaro la clase GamePrinter
{
    private bool[,] matrix; //Declaro un atributo privado matrix 

    public GamePrinter(bool[,] matrix) //Método constructor que recibe matrix (de tipo bool[,] como parámetro)
    {
        this.matrix = matrix; //Asigno el parámetro matrix recibido al atributo matrix de la clase GamePrinter
    }

    public void PrintMatrix() //Defino método público PrintMatrix
    {
        int columnas = matrix.GetLength(1); //Guardo la cantidad de columas del bool[,]matrix en la variable columnas
        int contador = 0; //Inicializo un contador en 0 

        foreach (bool valor in matrix) // Recorro los valores de la matrix uno por uno 
        {
            if (valor == true) // Si el valor es true imprimo "|X|"
            {
                Console.Write("|X|");
            }
            else// Sino imprimo "---"
            {
                Console.Write("---");
            }

            contador++; // El contador se incremeta en 1
            if (contador % columnas == 0) // Si el contador es divisible entre la cantidad de columnas, se hace un salto de línea
            {
                Console.WriteLine();
            }
        }
    }
}