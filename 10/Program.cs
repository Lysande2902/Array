using System;

class Program
{
    static void Main()
    {
        // Crear una matriz de 3x3
        int[,] matriz = new int[3, 3];

        // Solicitar al usuario que ingrese los valores de la matriz
        Console.WriteLine("Ingrese los valores de la matriz 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Valor para la posición [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Solicitar al usuario el número por el cual multiplicar cada fila
        Console.Write("Ingrese el número por el cual multiplicar cada fila: ");
        int multiplicador = int.Parse(Console.ReadLine());

        // Multiplicar cada fila de la matriz por el número ingresado
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] *= multiplicador;
            }
        }

        // Mostrar la nueva matriz con los valores actualizados
        Console.WriteLine("La nueva matriz es:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
