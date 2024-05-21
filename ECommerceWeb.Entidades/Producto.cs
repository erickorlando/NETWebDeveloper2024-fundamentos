namespace ECommerceWeb.Entidades;

public class Producto : EntidadBase
{
    public string Nombre { get; set; } = default!;

    public float Precio { get; set; }

    public override string ToString()
    {
        return $"{Id} : {Nombre} | $ {Precio:N2}";
    }
}