using System.ComponentModel.DataAnnotations.Schema;

namespace Sesion04.ECommerceWeb.Entidades
{
    public class EntidadBase
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)] // Esto anula la capacidad de IDENTITY
        public int Id { get; set; }
    }
}
