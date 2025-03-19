using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Solicitar al usuario el número de estudiantes
        Console.Write("Ingrese el número de estudiantes: ");
        int numEstudiantes = int.Parse(Console.ReadLine());

        // Arreglos para almacenar nombres y calificaciones
        string[] nombres = new string[numEstudiantes];
        double[][] calificaciones = new double[numEstudiantes][];

        // Ingresar datos de cada estudiante
        for (int i = 0; i < numEstudiantes; i++)
        {
            Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
            nombres[i] = Console.ReadLine();

            calificaciones[i] = new double[3];
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Ingrese la calificación {j + 1} de {nombres[i]}: ");
                calificaciones[i][j] = double.Parse(Console.ReadLine());
            }
        }

        // Guardar la información en un archivo de texto
        using (StreamWriter sw = new StreamWriter("notas.txt"))
        {
            for (int i = 0; i < numEstudiantes; i++)
            {
                sw.Write(nombres[i] + " ");
                for (int j = 0; j < 3; j++)
                {
                    sw.Write(calificaciones[i][j] + " ");
                }
                sw.WriteLine();
            }
        }

        // Leer el archivo y calcular el promedio de cada estudiante
        using (StreamReader sr = new StreamReader("notas.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] datos = line.Split(' ');
                string nombre = datos[0];
                double suma = 0;

                for (int i = 1; i < datos.Length; i++)
                {
                    suma += double.Parse(datos[i]);
                }

                double promedio = suma / 3;
                Console.WriteLine($"El promedio de {nombre} es: {promedio}");
            }
        }
    }
}
