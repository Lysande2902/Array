using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Solicitar al usuario el número de ventas a registrar
        Console.Write("Ingrese el número de ventas a registrar: ");
        int numVentas = int.Parse(Console.ReadLine());

        // Arreglos para almacenar los datos de las ventas
        string[] productos = new string[numVentas];
        int[] cantidades = new int[numVentas];
        double[] precios = new double[numVentas];

        // Ingresar los datos de cada venta
        for (int i = 0; i < numVentas; i++)
        {
            Console.Write($"Ingrese el nombre del producto {i + 1}: ");
            productos[i] = Console.ReadLine();

            Console.Write($"Ingrese la cantidad vendida de {productos[i]}: ");
            cantidades[i] = int.Parse(Console.ReadLine());

            Console.Write($"Ingrese el precio unitario de {productos[i]}: ");
            precios[i] = double.Parse(Console.ReadLine());
        }

        // Guardar las ventas en un archivo CSV
        using (StreamWriter sw = new StreamWriter("ventas.csv"))
        {
            for (int i = 0; i < numVentas; i++)
            {
                sw.WriteLine($"{productos[i]},{cantidades[i]},{precios[i]}");
            }
        }

        // Leer el archivo CSV y calcular el total de ventas
        double totalVentas = 0;
        using (StreamReader sr = new StreamReader("ventas.csv"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] datos = line.Split(',');
                string producto = datos[0];
                int cantidad = int.Parse(datos[1]);
                double precio = double.Parse(datos[2]);

                double totalVenta = cantidad * precio;
                totalVentas += totalVenta;
            }
        }

        // Mostrar el total de ventas del día
        Console.WriteLine($"El total de ventas del día es: {totalVentas:C}");
    }
}
