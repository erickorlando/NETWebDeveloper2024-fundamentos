using Sesion04.ECommerceWeb.Entidades;

namespace Sesion04.ECommerceWeb.Repositorios.Interfaces;

public interface IClienteRepositorio : IRepositorioBase<Cliente>
{
    Cliente? BuscarPorEmail(string email);
}