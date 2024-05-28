using System.ComponentModel.DataAnnotations;

namespace Sesion04.ECommerceWeb.Entidades;

public class Cliente : EntidadBase
{
    [StringLength(100)]
    public string Nombre { get; set; } = default!;

    [StringLength(100)]
    public string Apellidos { get; set; } = default!;

    [StringLength(500)]
    public string Email { get; set; } = default!;
}