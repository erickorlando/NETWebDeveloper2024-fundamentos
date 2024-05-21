using ECommerceWeb.Entidades;
using ECommerceWeb.Repositorios.Implementaciones;

Console.WriteLine("NET 8 WEB DEVELOPER - APLICACION REAL DE CONSOLA");

var repositorio = new CategoriaRepositorio();

repositorio.Insertar(new Categoria()
{
    Nombre = "Celulares"
});

repositorio.Insertar(new Categoria()
{
    Nombre = "Televisores",
    Descripcion = "Televisores de alta gama"
});

Console.WriteLine("Ingrese una nueva categoria:");
var categoria = new Categoria();

categoria.Nombre = Console.ReadLine()!;
Console.WriteLine("Ingrese una descripcion para la categoria:");
categoria.Descripcion = Console.ReadLine();

repositorio.Insertar(categoria);

//repositorio.Listar().ForEach(Console.WriteLine);

//Console.WriteLine("Vamos a modificar la descripcion de un elemento: (ingrese el ID a modificar)");

//if (int.TryParse(Console.ReadLine(), out var id))
//{
//    var categoriaExistente = repositorio.ObtenerPorId(id);
//    if (categoriaExistente is null)
//    {
//        Console.WriteLine($"Esta categoria con el ID {id} no existe en la coleccion");
//    }
//    else
//    {
//        Console.WriteLine("Ingrese la nueva descripción:");
//        categoriaExistente.Descripcion = Console.ReadLine();
//        repositorio.Actualizar(id, categoriaExistente);
//    }
//}


repositorio.Listar().ForEach(Console.WriteLine);

Console.WriteLine("Uso de la programacion funcional para nuestro patron repositorio:");
Console.WriteLine("Ingrese un criterio de busqueda: (Nombre)");
var criterio = Console.ReadLine()!;

// Equals = Busqueda exacta
// StartsWith = Busqueda desde el inicio de la cadena
// EndsWith = Busqueda desde el final de la cadena
// Contains = Busqueda dentro de la cadena


var categoriasEncontradas = repositorio.Listar(c => c.Nombre.Contains(criterio, StringComparison.InvariantCultureIgnoreCase));
categoriasEncontradas.ForEach(Console.WriteLine);

Console.WriteLine("Ingrese un criterio de busqueda: (Descripcion)");

var otroCriterio = Console.ReadLine()!;
var categoriasEncontradas2 = repositorio
    .Listar(cat =>
    {
        if (cat.Descripcion is not null)
        {
            return cat.Descripcion.StartsWith(otroCriterio);
        }

        return false;
    });

categoriasEncontradas2.ForEach(Console.WriteLine);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("PRODUCTOS");

var repoProductos = new ProductoRepositorio();

repoProductos.Insertar(new Producto() { Nombre = "Xiaomi Redmi Note 13", Precio = 500});
repoProductos.Insertar(new Producto() { Nombre = "Samsung S24", Precio = 1500});
repoProductos.Insertar(new Producto() { Nombre = "xxe 13", Precio = 800});
repoProductos.Insertar(new Producto() { Nombre = "Samsung S23", Precio = 750});
repoProductos.Insertar(new Producto() { Nombre = "Xiaomi Redmi Note 10", Precio = 720});
repoProductos.Insertar(new Producto() { Nombre = "Samsung S21", Precio = 150});


repoProductos.Listar().ForEach(Console.WriteLine);

var listaProductos = repoProductos.Listar(p => p.Precio >= 1000);

listaProductos.ForEach(Console.WriteLine);

//Console.WriteLine("Prueba de actualizacion:");

//var productoExistente = repoProductos.ObtenerPorId(2);
//if (productoExistente is not null)
//{
//    productoExistente.Precio *= 2;
    
//    repoProductos.Actualizar(2, productoExistente);
//}

//repoProductos.Listar().ForEach(Console.WriteLine);

