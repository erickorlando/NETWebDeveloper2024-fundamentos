namespace Sesion04.ECommerceWeb.Entidades;

public class VentaDetalle : EntidadBase
{
    public Venta Venta { get; set; } = default!;
    public int VentaId { get; set; }
    public Producto Producto { get; set; } = default!;
    public int ProductoId { get; set; }
    public float PrecioUnitario { get; set; }
    public int Cantidad { get; set; }
    public float Total { get; set; }
}