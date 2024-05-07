namespace Sesion01;

public class Persona
{
    // Esto es una propiedad
    public string Nombre { get; set; } 

    public string Apellido { get; set; } = string.Empty;

    public void MostrarNombreCompleto()
    {
        Console.WriteLine($"{Nombre} {Apellido}");
    }
    
    // override significa sobrescribir
    public override string ToString()
    {
        return $"El nombre completo es {Nombre} {Apellido}";
    }

    // Constructor
    public Persona()
    {
        Nombre = string.Empty;
    }
}
