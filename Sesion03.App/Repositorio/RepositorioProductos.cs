using Sesion03.Entidades;

namespace Sesion03.App.Repositorio;

public class RepositorioProductos : RepositorioBase<Producto>, IRepositorioBase<Producto>
{
    public override void Listar()
    {
        foreach (var elemento in Lista)
        {
            Console.WriteLine($"{elemento.Nombre} cuesta $ {elemento.Precio:N2}");
        }

        Console.WriteLine($"Existen: {ContarElementos()} elementos");
    }

    public void Eliminar(Producto objeto)
    {
        Lista.Remove(objeto);
        Console.WriteLine("Elimino sin comprobar primero");
    }
}