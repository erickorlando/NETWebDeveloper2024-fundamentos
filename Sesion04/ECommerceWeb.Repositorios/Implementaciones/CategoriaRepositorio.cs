using ECommerceWeb.DataAccess.Data;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

namespace Sesion04.ECommerceWeb.Repositorios.Implementaciones
{
    public class CategoriaRepositorio : RepositorioBase<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorio(ECommerceDbContext context) 
            : base(context)
        {
        }

        public override Categoria? ObtenerPorId(int id)
        {
            Console.WriteLine("Este es el obtener por ID de Categoria");
            return Context.Set<Categoria>().FirstOrDefault(e => e.Id == id);
        }
    }
}
