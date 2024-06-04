using Microsoft.EntityFrameworkCore;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

namespace Sesion04.ECommerceWeb.Repositorios.Implementaciones
{
    public class RepositorioBase<TEntidad> : IRepositorioBase<TEntidad>
        where TEntidad : EntidadBase
    {
        protected readonly DbContext Context;

        protected RepositorioBase(DbContext context)
        {
            Context = context;
        }
        
        public List<TEntidad> Listar()
        {
            return Context
                .Set<TEntidad>()
                .ToList();
        }

        public List<TEntidad> Listar(Func<TEntidad, bool> predicado)
        {
            return Context.Set<TEntidad>()
                .Where(predicado)
                .ToList();
        }

        public virtual TEntidad? ObtenerPorId(int id)
        {
            return Context.Set<TEntidad>()
                .FirstOrDefault(p => p.Id == id);
        }

        public virtual void Insertar(TEntidad entidad)
        {
            Context.Set<TEntidad>().Add(entidad); // Esto lo agrega a la coleccion del DbSet
            Context.SaveChanges(); // Esto confirma el guardado del registro
        }

        public void Actualizar(int id, TEntidad entidad)
        {
            var registro = ObtenerPorId(id);
            if (registro is not null)
            {
                registro = entidad;
                Context.SaveChanges(); // Esto usara el ChangeTracker
            }
        }

        public void Eliminar(int id)
        {
            // Buscamos dentro de nuestra coleccion el ID que recibimos como argumento.
            var entidadExistente = ObtenerPorId(id);
            if (entidadExistente is not null)
            {
                Context.Set<TEntidad>().Remove(entidadExistente); // Lo quita de la coleccion
                Context.SaveChanges();
            }
        }
    }
}
