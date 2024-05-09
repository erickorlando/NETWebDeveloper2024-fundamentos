using Sesion02;

Console.WriteLine("Bienvenido a la sesion 02 del curso NET 8 Web Developer");
Console.Title = "Sesion 02";

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

        Console.WriteLine("Fin del programa :=O) ");
    }

} while (!valorValido);