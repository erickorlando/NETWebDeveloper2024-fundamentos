using Sesion04.ECommerceWeb.Entidades;

namespace Sesion04.ECommerceWeb.Repositorios.Interfaces;

public interface IVentaRepositorio : IRepositorioBase<Venta>
{
    Venta? MostrarVenta(int ventaId);

    List<VentaDetalle> ListarDetalles(int ventaId);

    void IniciarTransaccion();

    void AgregarDetalle(VentaDetalle ventaDetalle);

    void FinalizarTransaccion();

    void CancelarTransaccion();

    string ObtenerUltimoNumero();
}