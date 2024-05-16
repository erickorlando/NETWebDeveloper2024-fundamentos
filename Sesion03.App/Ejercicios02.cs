using Sesion03.App.Repositorio;
using Sesion03.Entidades;

namespace Sesion03.App
{
    public class Ejercicios02
    {
        public static void Ejecutar()
        {
            Console.WriteLine("PRODUCTOS");

            var repositorio = new RepositorioProductos();

            repositorio.Lista.Add(new()
            {
                Codigo = "PROD-001",
                Nombre = "Xiaomi Redmi Note 13",
                Categoria = new("Celulares"),
                Dimensiones = new(10, 20),
                Precio = 500.99f
            });

            repositorio.Lista.Add(new()
            {
                Codigo = "PROD-002",
                Nombre = "Honor Magic 5 Lite",
                Categoria = new("Celulares"),
                Dimensiones = new(10, 20),
                Precio = 330.99f
            });


            //repositorio.ListarDetallado(); // Implementacion en la derivada
            repositorio.Listar(); // implementacion en la clase base

            repositorio.Eliminar(new Producto() { Nombre = "Xiaomi Redmi Note 13" });

            repositorio.Listar();

            Console.WriteLine("Categorias");
            Console.WriteLine(new string('*', 100));

            var repoCategorias = new RepositorioCategorias();

            repoCategorias.Lista.Add(new()
            {
                Nombre = "Celulares",
                TipoCategoria = TipoCategoria.Simple
            });

            var categoria = new Categoria()
            {
                Nombre = "Laptops",
                TipoCategoria = TipoCategoria.Compleja
            };

            repoCategorias.Lista.Add(categoria);

            repoCategorias.Listar();

            Console.WriteLine("\nProbamos la eliminacion");
            repoCategorias.Eliminar(categoria);

            repoCategorias.Listar();
        }
    }
}
