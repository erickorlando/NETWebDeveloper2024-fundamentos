using ECommerceWeb.Entidades;

namespace ECommerceWeb.Repositorios.Interfaces
{
    // Aqui haremos un CRUD (CREATE, READ, UPDATE, DELETE)

    public interface IRepositorioBase<TEntidad>
        where TEntidad : EntidadBase // <----- Esto es un constraint (regla)
    {
        List<TEntidad> Listar();

        List<TEntidad> Listar(Func<TEntidad, bool> predicado);

        TEntidad? ObtenerPorId(int id);

        void Insertar(TEntidad entidad);
        
        void Actualizar(int id, TEntidad entidad);
        
        void Eliminar(int id);
    }
}
