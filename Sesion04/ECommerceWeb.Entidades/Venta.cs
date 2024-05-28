using System.ComponentModel.DataAnnotations;

namespace Sesion04.ECommerceWeb.Entidades;

public class Venta : EntidadBase
{
    [StringLength(20)]
    public string NumeroFactura { get; set; } = default!;
    public DateTime FechaVenta { get; set; }
    public Cliente Cliente { get; set; } = default!;
    public int ClienteId { get; set; }
    public float TotalVenta { get; set; }

    public ICollection<VentaDetalle> Detalles { get; set; } = new List<VentaDetalle>();
}