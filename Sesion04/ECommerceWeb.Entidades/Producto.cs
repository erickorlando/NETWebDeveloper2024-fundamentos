using System.ComponentModel.DataAnnotations;

namespace Sesion04.ECommerceWeb.Entidades;

public class Producto : EntidadBase
{
    [StringLength(100)]
    public string Nombre { get; set; } = default!;

    public float Precio { get; set; }

    public Categoria Categoria { get; set; } = default!;

    public int CategoriaId { get; set; }

    public override string ToString()
    {
        return $"{Id} : {Nombre} | $ {Precio:N2}";
    }
}