using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion02
{
    public class BucleForEach
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Bucle foreach - Estructura repetitiva");
            Console.WriteLine(new string('*', 100));
            
            string[] nombres = { "Juan", "Pedro", "María", "Ana", "Erick" };

            Console.WriteLine("Recorrido con foreach");
            foreach (string nombre in nombres)
            {
                Console.WriteLine($"\n{nombre}");
                
                Console.WriteLine($"Los caracteres del nombre {nombre} son:");
                foreach (char letra in nombre)
                {
                    Console.WriteLine(letra);
                }
            }
            
            Console.WriteLine($"\nRecorrido con for");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"En el indice {i} se encuentra {nombres[i]}");
            }
        }
    }
}
