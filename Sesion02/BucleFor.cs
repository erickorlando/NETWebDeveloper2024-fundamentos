namespace Sesion02;

public class BucleFor
{
    public static void Ejecutar()
    {
        Console.WriteLine("Bucle for - Estructura repetitiva");
        Console.WriteLine(new string('*', 100));

        byte entero = 5;
        entero++; // Le suma 1 al valor inicial

        Console.WriteLine(entero);

        entero--;

        ++entero;

        Console.WriteLine(entero);

        --entero;

        Console.WriteLine(entero);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Bucle for en forma ascendente");
        for (int i = 1; i <= 50; i++)
        {
            Console.WriteLine($"Chocolate numero COD-{i:0000}");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bucle en forma descendente");
        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine($"Chocolate numero COD-{i:0000}");
        }

        Console.ForegroundColor = ConsoleColor.White;
    }
}