namespace Sesion03.App
{
    public class Ejercicios03
    {
        public static void Ejecutar()
        {
            
            Func<int, int> square = numero => numero * numero;
            
            Console.WriteLine("Resultado de la expresion lambda:");
            Console.WriteLine(square(5));

            var numeros = Enumerable.Range(1, 10);
            var numeroPares = numeros.Where(number => number % 2 == 0).ToList();
            
            numeroPares.ForEach(Console.WriteLine); // Sin mensaje
            
            numeroPares.ForEach(ImprimirNumero); // Con mensaje
            
            numeros.ToList().ForEach(ImprimirNumero);

            Console.ForegroundColor = ConsoleColor.Green;
            var otraLista = numeros.Where(EsPar).ToList();
            otraLista.ForEach(ImprimirNumero);
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Resultado del metodo tradicional");
            Console.WriteLine(Cuadrado(5));

            foreach (var numero in numeros)
            {
                if (EsPar(numero))
                    Console.WriteLine($"Numero par: {numero}");
            }
        }

        public static int Cuadrado(int numero)
        {
            return numero * numero;
        }

        public static bool EsPar(int numero)
        {
            var residuo = numero % 2; // Esta division devuelve el residuo
            
            // Esto es un if de principiantes
            //if (residuo == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            // Esto es un if mas elegante (sin poner if)
            //return residuo == 0;

            // Expresion ternaria, que en este caso es un poco obvia.
            return residuo == 0 ? true : false;
        }

        public static void ImprimirNumero(int numero)
        {
            Console.WriteLine($"El numero es: {numero}");
        }
    }
}
