namespace ECommerceWeb.Entidades
{
    public class Categoria : EntidadBase
    {
        public string Nombre { get; set; } = null!; // default!;
        public string? Descripcion { get; set; }

        public override string ToString()
        {
            return $"{Id} =====> {Nombre} | {Descripcion}";
        }
    }
}
