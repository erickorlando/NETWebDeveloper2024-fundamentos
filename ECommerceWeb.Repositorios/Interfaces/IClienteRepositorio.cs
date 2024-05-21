using ECommerceWeb.Entidades;

namespace ECommerceWeb.Repositorios.Interfaces;

public interface IClienteRepositorio : IRepositorioBase<Cliente>
{
    Cliente? BuscarPorEmail(string email);
}