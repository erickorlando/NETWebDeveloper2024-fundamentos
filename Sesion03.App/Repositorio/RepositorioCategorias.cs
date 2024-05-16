using Sesion03.Entidades;

namespace Sesion03.App.Repositorio;

public class RepositorioCategorias : RepositorioBase<Categoria>, IRepositorioBase<Categoria>
{
    public void Eliminar(Categoria objeto)
    {
        if (Lista.Contains(objeto))
        {
            Lista.Remove(objeto);
            Console.WriteLine("Acabo de eliminar el registro de categoria");
        }
    }
}