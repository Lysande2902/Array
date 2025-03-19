using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo para almacenar 10 números
        int[] numeros = new int[10];

        // Solicitar al usuario que ingrese 10 números
        Console.WriteLine("Ingrese 10 números:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Solicitar al usuario el número a eliminar
        Console.Write("Ingrese el número que desea eliminar: ");
        int numeroEliminar = int.Parse(Console.ReadLine());

        // Crear un nuevo arreglo para almacenar los números sin el valor eliminado
        int[] nuevoArreglo = new int[numeros.Length - 1];
        int indiceNuevoArreglo = 0;

        // Recorrer el arreglo original y copiar los números que no coincidan con el número a eliminar
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] != numeroEliminar)
            {
                nuevoArreglo[indiceNuevoArreglo] = numeros[i];
                indiceNuevoArreglo++;
            }
        }

        // Mostrar el nuevo arreglo sin el número eliminado
        Console.WriteLine("El nuevo arreglo es:");
        for (int i = 0; i < nuevoArreglo.Length; i++)
        {
            Console.Write(nuevoArreglo[i] + " ");
        }
    }
}
