namespace Sesion02;

public class BucleWhile
{
    public static void Ejecutar()
    {
        Console.WriteLine("Bucle while - Estructura repetitiva");
        Console.WriteLine(new string('*', 100));

        int personasEnFila = 5;

        while (personasEnFila > 0)
        {
            Console.WriteLine("Esperando...");
            personasEnFila--;
        }
        
        
        Console.WriteLine("\nBucle do-while");
        int contador = 0;
        do
        {
            Console.WriteLine("Contador: " + contador);
            contador++;
        } while (contador < 5);
 
    }
}