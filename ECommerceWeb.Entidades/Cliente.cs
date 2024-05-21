namespace ECommerceWeb.Entidades;

public class Cliente : EntidadBase
{
    public string Nombre { get; set; } = default!;
    public string Apellidos { get; set; } = default!;
    public string Email { get; set; } = default!;
}