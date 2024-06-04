namespace ECommerceWeb.Dto
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!; // default!;
        public string? Descripcion { get; set; }
    }
}
