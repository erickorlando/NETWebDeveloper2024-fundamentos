using System.ComponentModel.DataAnnotations;

namespace Sesion04.ECommerceWeb.Entidades
{
    public class Categoria : EntidadBase
    {
        [StringLength(50)]
        public string Nombre { get; set; } = null!; // default!;

        [StringLength(100)]
        public string? Descripcion { get; set; }

        public override string ToString()
        {
            return $"{Id} =====> {Nombre} | {Descripcion}";
        }
    }
}
