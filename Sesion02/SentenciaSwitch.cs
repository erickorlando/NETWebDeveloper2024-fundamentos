namespace Sesion02;

public class SentenciaSwitch
{
    public static void Ejecutar()
    {
        Console.WriteLine("Sentencia switch - Estructura selectiva");
        Console.WriteLine(new string('*', 100));
        // Sentencia switch clásica

        Console.WriteLine("Escoge un numero del 1 al 10");
        var stringOpcion = Console.ReadLine();

        if (byte.TryParse(stringOpcion, out var opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Escogiste una opcion adecuada");
                    break;
                case 2:
                    Console.WriteLine("Lo que hiciste, estuvo estupendo!");
                    break;
                case 3:
                    Console.WriteLine("¡Uy! Te pasaste");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Genial! Estos numeros si que valen la pena");
                    break;
                case > 7 and <= 10:
                    Console.WriteLine("Ufff estos numeros si que están volando!");
                    break;
                case > 10:
                    Console.WriteLine("El valor no puede superar el umbral de 10");
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Fin del programa, sin haber escogido una opción :-(");
        }
        

        // Sentencia switch nueva (C# 12)

        Console.WriteLine("Escoja un valor del 1 al 100");
        var otroValor = Console.ReadLine();
        string mensaje = string.Empty;

        if (byte.TryParse(otroValor, out var opcionNueva))
        {
            // La nueva sintaxis de switch solo se utiliza si queremos devolver algun valor
            mensaje = opcionNueva switch
            {
                1 => "Escogiste una opcion muy baja",
                2 => "Vas mejorando",
                3 => "Sigue intentándolo",
                _ => "Seguiré esperando tus intentos"
            };
        }
        else
        {
            mensaje = "No se pudo completar las opciones, porque el valor no es válido";
        }

        Console.WriteLine(mensaje);
    }
}