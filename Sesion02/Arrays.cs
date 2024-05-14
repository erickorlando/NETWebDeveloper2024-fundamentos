using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Sesion02.Modelos;

namespace Sesion02
{
    public class Arrays
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Arrays fuertemente tipados");
            
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] cadenas = new[] { "Valor 1", "Valor 2", "Valor 3" };

            int[] elementos = new int[5] { 99, 88, 77, 66, 55 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Separador();
            
            foreach (var cadena in cadenas)
            {
                Console.WriteLine(cadena);
            }

            Separador();

            Console.WriteLine($"El 3er array de este ejemplo tiene {elementos.Length} elementos");

            for (int x = 0; x < elementos.Length; x++)
            {
                Console.WriteLine($"El valor del item es {elementos[x]}");
            }
            
            Console.WriteLine("Vamos a reemplazar un valor del array");
            Console.WriteLine("Ingrese el indice del array a cambiar");

            if (byte.TryParse(Console.ReadLine(), out var indice))
            {
                Console.WriteLine($"Ingrese el nuevo valor para el indice {indice}");
                
                if (indice >= 0 && indice < elementos.Length)
                {
                    if (int.TryParse(Console.ReadLine(), out var nuevoValor))
                    {
                        elementos[indice] = nuevoValor;
                        Console.WriteLine($"El valor del item en el indice {indice} ha sido actualizado");
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es válido");
                    }
                }
                else
                {
                    Console.WriteLine("El indice ingresado no es válido");
                }

                foreach (var elemento in elementos)
                {
                    Console.WriteLine(elemento);
                }
            }
            
            Separador();
            Console.WriteLine("Uso de ArrayList (no esta fuertemente tipado)");

            var coleccion = new ArrayList(); // List<object>
            coleccion.Add("valor 1");
            coleccion.Add(5);
            coleccion.Add(50f);
            coleccion.Add(99.66d);
            coleccion.Add(1567.33m);
            coleccion.Add(Convert.ToByte("5"));
            coleccion.Add(true);
            coleccion.Add(5 > 30);

            Console.WriteLine($"El tamaño de la coleccion es: {coleccion.Count}");
            
            foreach (var objeto in coleccion)
            {
                Console.WriteLine($"Valor del array no tipado: {objeto} y el tipo de dato es: {objeto.GetType().Name}");
            }
            
            Separador();
            
            Console.WriteLine("Colecciones especializadas");

            var superheroes = new StringCollection();
            superheroes.Add("superman");
            superheroes.Add("ironman");
            superheroes.Add("capitan america");
            superheroes.Add("goku");

            Console.WriteLine($"La cantidad de superheroes son: {superheroes.Count}");
            
            foreach (var hero in superheroes)
            {
                Console.WriteLine(hero);
            }
            
            Separador();
            
            Console.WriteLine("Clases Genericas");
            List<Superheroe> superheroes2 = new List<Superheroe>();
            superheroes2.Add(new Superheroe() { Nombre = "Ironman", Superpoder = "Volar"});
            superheroes2.Add(new Superheroe() { Nombre = "Batman", Superpoder = "Millonario"});
            superheroes2.Add(new Superheroe() { Nombre = "Capitan America", Superpoder = "Agilidad"});

            var otraLista = new List<string>();
            otraLista.Add("Spiderman");
            otraLista.Add("Wonder Woman");
            otraLista.Add("Hulk");
            
            
            otraLista.AddRange(superheroes2.Select(p => p.Nombre));
            
            foreach (var superheroe in superheroes2)
            {
                Console.WriteLine(superheroe);
            }
            
            Separador();

            for (int i = 0; i < otraLista.Count; i++)
            {
                Console.WriteLine(otraLista[i]);
            }
            
            Console.WriteLine("Ingrese un criterio de busqueda (nombre):");
            var filtro = Console.ReadLine()!;

            if (otraLista.Contains(filtro))
            {
                Console.WriteLine($"El elemento {filtro} si se encuentra en la lista");
            }
            
            Separador();
            
            Console.WriteLine("Uso de diccionarios: (CLAVE-VALOR)");
            var diccionario = new Dictionary<string, int>();
            diccionario.Add("Manzana", 10);
            diccionario.Add("Naranja", 5);
            diccionario.Add("Plátano", 8);

            foreach (var item in diccionario)
            {
                Console.WriteLine($"Clave: {item.Key}, Valor: {item.Value}");
            }
            
            // Busqueda de elementos en un diccionario:
            Console.WriteLine("Ingrese una clave a buscar en el diccionario:");
            var clave = Console.ReadLine()!;

            if (diccionario.ContainsKey(clave))
            {
                Console.WriteLine($"El valor asociado a la clave {clave} es {diccionario[clave]}");
            }
            else
            {
                Console.WriteLine($"La clave {clave} no se encuentra en el diccionario");
            }
            
            Separador();
            
            Console.WriteLine("Diccionarios fuertemente tipados con clases:");
            
            var diccionarioSuperheroes = new Dictionary<string, Superheroe>();
            diccionarioSuperheroes.Add("New York", new Superheroe() { Nombre = "Ironman", Superpoder = "Volar" });
            diccionarioSuperheroes.Add("Gotica", new Superheroe() { Nombre = "Batman", Superpoder = "Millonario" });
            diccionarioSuperheroes.Add("Brooklyn",
                new Superheroe() { Nombre = "Capitan America", Superpoder = "Agilidad" });

            foreach (var item in diccionarioSuperheroes)
            {
                Console.WriteLine($"Ciudad: {item.Key}, {item.Value}");
            }

            var otroDiccionario = new Dictionary<string, object>();
            
            otroDiccionario.Add("llave1", new Superheroe());
            otroDiccionario.Add("llave2", "string generico");
            otroDiccionario.Add("llave2", 5);
            otroDiccionario.Add("llave2", 6f);
        }

        public static void Separador()
        {
            Console.WriteLine($"\n{new string('*', 100)}");
        }
    }
}
