using ECommerceWeb.Entidades;
using ECommerceWeb.Repositorios.Interfaces;

namespace ECommerceWeb.Repositorios.Implementaciones
{
    public class RepositorioBase<TEntidad> : IRepositorioBase<TEntidad>
        where TEntidad : EntidadBase
    {
        public List<TEntidad> Datos { get; set; } = new();

        public List<TEntidad> Listar()
        {
            return Datos;
        }

        public List<TEntidad> Listar(Func<TEntidad, bool> predicado)
        {
            return Datos
                .Where(predicado)
                .ToList();
        }

        public virtual TEntidad? ObtenerPorId(int id)
        {
            return Datos.FirstOrDefault(p => p.Id == id);
        }

        public void Insertar(TEntidad entidad)
        {
            var cantidad = Datos.Count + 1;
            entidad.Id = cantidad;
            Datos.Add(entidad);
        }

        public void Actualizar(int id, TEntidad entidad)
        {
            // Aca reemplazamos la instancia existente
            Datos[id - 1] = entidad;
        }

        public void Eliminar(int id)
        {
            // Buscamos dentro de nuestra coleccion el ID que recibimos como argumento.
            var entidadExistente = Datos.FirstOrDefault(e => e.Id == id);
            if (entidadExistente is not null)
            {
                Datos.Remove(entidadExistente);
            }
        }
    }
}
