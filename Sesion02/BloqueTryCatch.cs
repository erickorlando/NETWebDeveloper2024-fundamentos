namespace Sesion02;

public class BloqueTryCatch
{
    public static void Ejecutar()
    {
        try
        {
            Console.WriteLine("Ingresa un valor numerico:");

            byte numero = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"El numero ingresado es: {numero:000}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error de formato");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error de desbordamiento, el numero es superior a 255 o menor a 0");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ups! hay un error!");
        }
        finally
        {
            Console.WriteLine("Yo me ejecuto haya o no haya error");
        }
    }
}