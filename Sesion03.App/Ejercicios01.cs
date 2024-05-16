using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sesion03.Entidades;

namespace Sesion03.App
{
    public class Ejercicios01
    {
        public static void Ejecutar()
        {
            var categoria1 = new Categoria();
            categoria1.Nombre = "Televisores";
            categoria1.TipoCategoria = TipoCategoria.Compleja;

            var categoria2 = new Categoria("Celulares");
            categoria2.TipoCategoria = null;

            var list = new List<Categoria>() { categoria1, categoria2 };

            foreach (var categoria in list)
            {
                // Operador de asignacion de coalescencia ??=

                Console.WriteLine($"{categoria} -> {(int)(categoria.TipoCategoria ??= 0)}");

                // Operador de Coalescencia ??
                Console.WriteLine(categoria.TipoCategoria ?? TipoCategoria.Simple);

                // Operador ternario ?
                var stringCategoria = categoria.TipoCategoria == null ? "sin categoria" : "con categoria";

                Console.WriteLine($"Operador ternario: {stringCategoria}");

                Console.WriteLine();
            }

            Console.WriteLine("Productos:\n");

            var producto01 = new Producto
            {
                Categoria = new("Computadoras"), // Aqui el constructor infiere el tipo
                //Categoria = new Categoria("Computadoras"), // Aca es explicito
                Codigo = "0001",
                Nombre = "Laptop ASUS ROG",
                Precio = 5600,
                Dimensiones = new Dimensiones()
                {
                    Alto = 50,
                    Ancho = 85
                }
            };

            var producto02 = new Producto
            {
                Categoria = categoria1,
                Codigo = "0002",
                Nombre = "TV LG 80''",
                Precio = 4399.99F,
                Dimensiones = new() // Se infiere el tipo
                {
                    Alto = 500,
                    Ancho = 850
                }
            };


            var producto03 = new Producto
            {
                Categoria = categoria2,
                Codigo = "0003",
                Nombre = "Samsung Galaxy S24",
                Precio = 5399.99F,
                Dimensiones = new(60, 15)
            };

            var resultado = producto01.Dimensiones.Sumar();

            var listaProductos = new List<Producto> { producto01, producto02, producto03 };

            Console.WriteLine(resultado);

            foreach (var prod in listaProductos)
            {
                Console.WriteLine($"{prod} {prod.Categoria} {prod.Dimensiones}");
            }
        }
    }
}
