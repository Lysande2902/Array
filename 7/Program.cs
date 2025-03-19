using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un texto:");
        string texto = Console.ReadLine();

        // Guardar en archivo
        string filePath = "texto.txt";
        File.WriteAllText(filePath, texto);

        // Verificar existencia antes de leer
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Error: El archivo no se encontró.");
            return;
        }

        // Leer archivo
        string textoLeido = File.ReadAllText(filePath);
        Console.WriteLine("\nContenido del archivo:");
        Console.WriteLine(textoLeido);

        // Procesamiento del texto
        int numCaracteres = textoLeido.Length;
        int numLineas = textoLeido.Split('\n').Length;

        // Eliminar puntuación para un conteo más preciso
        string textoSinPuntuacion = Regex.Replace(textoLeido, @"[^\w\s]", "");

        string[] palabras = textoSinPuntuacion.Split(
            new[] { ' ', '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries
        );
        int numeroDePalabras = palabras.Length;

        // Mostrar estadísticas
        Console.WriteLine($"\nEl texto contiene:");
        Console.WriteLine($"- {numeroDePalabras} palabras.");
        Console.WriteLine($"- {numCaracteres} caracteres.");
        Console.WriteLine($"- {numLineas} líneas.");

        // Guardar estadísticas en otro archivo
        string statsFile = "estadisticas.txt";
        string estadisticas =
            $"Palabras: {numeroDePalabras}\nCaracteres: {numCaracteres}\nLíneas: {numLineas}";
        File.WriteAllText(statsFile, estadisticas);

        Console.WriteLine($"\nLas estadísticas se han guardado en {statsFile}.");
    }
}
