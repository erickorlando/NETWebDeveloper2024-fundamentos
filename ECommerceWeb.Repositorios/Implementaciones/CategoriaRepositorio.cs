using ECommerceWeb.Entidades;
using ECommerceWeb.Repositorios.Interfaces;

namespace ECommerceWeb.Repositorios.Implementaciones
{
    public class CategoriaRepositorio : RepositorioBase<Categoria>, ICategoriaRepositorio
    {
        public override Categoria? ObtenerPorId(int id)
        {
            Console.WriteLine("Este es el obtener por ID de Categoria");
            return Datos.FirstOrDefault(e => e.Id == id);
        }
    }
}
