using ECommerceWebApplication.Data;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Implementaciones;

namespace ECommerceWebApplication
{
    public class EjerciciosParte01
    {
        public static void Ejecutar()
        {
            Console.WriteLine("CATEGORIAS");

            var context = new ECommerceDbContext();

            var repositorio = new CategoriaRepositorio(context);

            Console.WriteLine("Ingrese el nombre para la categoria:");

            var categoria = new Categoria();

            categoria.Nombre = Console.ReadLine()!;

            Console.WriteLine("Ingrese la descripcion:");

            categoria.Descripcion = Console.ReadLine()!;

            repositorio.Insertar(categoria);

            Console.WriteLine("Registro guardado exitosamente");

            repositorio.Listar().ForEach(Console.WriteLine);

            Console.ReadLine();

            Console.WriteLine("PRODUCTOS");

            var repoProductos = new ProductoRepositorio(context);

            Console.WriteLine("Ingrese el nombre del producto:");
            var producto = new Producto()
            {
                Nombre = Console.ReadLine()!
            };

            Console.WriteLine("Ingrese el ID de la categoria:");
            if (int.TryParse(Console.ReadLine(), out var idCategoria))
            {
                producto.CategoriaId = idCategoria;

                Console.WriteLine("Ingrese el precio del producto:");
                if (float.TryParse(Console.ReadLine(), out var precio))
                {
                    producto.Precio = precio;

                    repoProductos.Insertar(producto);

                    repoProductos.Listar().ForEach(Console.WriteLine);
                }
                else
                {
                    Console.WriteLine("Error al leer el valor para el precio");
                }
            }
            else
            {
                Console.WriteLine("Error al leer el valor para la categoria");
            }
        }
    }
}
