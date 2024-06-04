using ECommerceWebApplication.Data;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Implementaciones;

namespace ECommerceWebApplication
{
    public class EjerciciosParte02
    {
        public static void Ejecutar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            var context = new ECommerceDbContext();

            var repoVenta = new VentaRepositorio(context);

            try
            {
                repoVenta.IniciarTransaccion();

                var venta = new Venta
                {
                    ClienteId = 1,
                    FechaVenta = DateTime.Now,
                    NumeroFactura = repoVenta.ObtenerUltimoNumero(),
                };

                repoVenta.AgregarDetalle(new VentaDetalle
                {
                    ProductoId = 1,
                    Cantidad = 2,
                    PrecioUnitario = 100,
                    Total = 2 * 100,
                    Venta = venta
                });

                repoVenta.AgregarDetalle(new VentaDetalle
                {
                    ProductoId = 2,
                    Cantidad = 2,
                    PrecioUnitario = 500,
                    Total = 2 * 500,
                    Venta = venta
                });

                repoVenta.AgregarDetalle(new VentaDetalle
                {
                    ProductoId = 3,
                    Cantidad = 1,
                    PrecioUnitario = 99.99f,
                    Venta = venta,
                    Total = 99.99f
                });

                // Calculamos el total
                venta.TotalVenta = 5000;

                repoVenta.Insertar(venta);
                repoVenta.FinalizarTransaccion();

               
            }
            catch (Exception ex)
            {
                repoVenta.CancelarTransaccion();
            }

            repoVenta.Listar().ForEach(p =>
            {
                Console.WriteLine($"Venta: {p.Id} | {p.NumeroFactura} | {p.FechaVenta:D} ");
            });

            Console.WriteLine("Seleccione una venta para mostrar:");

            var ventaId = int.Parse(Console.ReadLine()!);

            var ventaRegistrada = repoVenta.MostrarVenta(ventaId);

            if (ventaRegistrada is null) return;

            Console.WriteLine($"Venta: {ventaRegistrada.Id} | {ventaRegistrada.NumeroFactura} | {ventaRegistrada.FechaVenta:d} | Cliente: {ventaRegistrada.Cliente.Nombre} {ventaRegistrada.Cliente.Apellidos} ");

            Console.WriteLine($"Cantidad de Productos en esta venta: {ventaRegistrada.Detalles.Count}");

            ventaRegistrada.Detalles.ToList().ForEach(p =>
            {
                Console.WriteLine($"Producto: {p.Producto.Nombre} | Categoria: {p.Producto.Categoria.Nombre} | Cantidad: {p.Cantidad} | Precio Unitario: {p.PrecioUnitario} | Total: {p.Total}");
            });

            Console.WriteLine("Listar detalles unicamente de la tabla sin relaciones");

            repoVenta.ListarDetalles(ventaId).ForEach(p =>
            {
                Console.WriteLine($"Producto: {p.ProductoId} | Cantidad: {p.Cantidad} | Precio Unitario: {p.PrecioUnitario} | Total: {p.Total}");
            });
        }
    }
}
