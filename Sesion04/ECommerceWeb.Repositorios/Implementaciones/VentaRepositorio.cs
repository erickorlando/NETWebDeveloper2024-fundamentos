using ECommerceWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

namespace Sesion04.ECommerceWeb.Repositorios.Implementaciones;

public class VentaRepositorio : RepositorioBase<Venta>, IVentaRepositorio
{
    public VentaRepositorio(ECommerceDbContext context) 
        : base(context)
    {
    }

    public Venta? MostrarVenta(int ventaId)
    {
        return Context.Set<Venta>()
            .Include(x => x.Cliente) // Include es para la tabla relacionada directa
            .Include(x => x.Detalles)
            .ThenInclude(d => d.Producto) // ThenInclude se usa para tablas relacionadas en colecciones.
            .ThenInclude(c => c.Categoria)
            .FirstOrDefault(p => p.Id == ventaId);
    }

    public List<VentaDetalle> ListarDetalles(int ventaId)
    {
        return Context.Set<VentaDetalle>()
            .Where(x => x.VentaId == ventaId)
            .ToList();
    }

    public void IniciarTransaccion()
    {
        Context.Database.BeginTransaction();
    }

    public void AgregarDetalle(VentaDetalle ventaDetalle)
    {
        Context.Set<VentaDetalle>().Add(ventaDetalle);
        // Obviamos el uso del SaveChanges para evitar que se guarde en la BD (por ahora).
    }

    public override void Insertar(Venta entidad)
    {
        Context.Set<Venta>().Add(entidad);
    }

    public void FinalizarTransaccion()
    {
        Context.Database.CommitTransaction();
        Context.SaveChanges();
    }

    public void CancelarTransaccion()
    {
        Context.Database.RollbackTransaction();
    }

    /// <summary>
    /// Esto es un ejemplo muy basico, de obtener un registro para el count
    /// </summary>
    public string ObtenerUltimoNumero()
    {
        var cantidad = Context.Set<Venta>()
            .Count() + 1;

        return cantidad.ToString("0000");
    }
}