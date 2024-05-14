using System.Diagnostics;
using Sesion02;

#if NET6_0
Console.ForegroundColor = ConsoleColor.Yellow;
#elif NET7_0
Console.ForegroundColor = ConsoleColor.Green;
#else
Console.ForegroundColor = ConsoleColor.Blue;
#endif
Console.WriteLine("Bienvenido a la sesion 02 del curso NET 8 Web Developer");
Console.Title = "Sesion 02";


#if WINDOWS
Console.WriteLine("Hola estoy en Windows");
#endif


bool valorValido = false;
do
{
    Console.WriteLine("Escoge una opcion:");
    Console.WriteLine("1. Sentencia switch");
    Console.WriteLine("2. Bucle for");
    Console.WriteLine("3. Bucle foreach");
    Console.WriteLine("4. Bucle while - do-while");
    Console.WriteLine("5. Manejo de excepciones");

    if (!byte.TryParse(Console.ReadLine(), out var opcion))
    {
        Console.WriteLine("Opcion no válida");
        //return; // Esto es un quiebre que cierra el programa
        valorValido = false;
    }
    else
    {
        switch (opcion)
        {
            case 1:
                SentenciaSwitch.Ejecutar();
                valorValido = true;
                break;
            case 2:
                BucleFor.Ejecutar();
                valorValido = true;
                break;
            case 3:
                BucleForEach.Ejecutar();
                Debugger.Break();
                valorValido = true;
                break;
            case 4:
                BucleWhile.Ejecutar();
                valorValido = true;
                break;
            case 5:
                BloqueTryCatch.Ejecutar();
                valorValido = true;
                break;
        }
    }

} while (!valorValido);

Console.WriteLine("Fin del programa :=O) ");
Console.ReadLine();