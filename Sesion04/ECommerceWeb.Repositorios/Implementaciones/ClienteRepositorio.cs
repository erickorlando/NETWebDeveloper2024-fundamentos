using ECommerceWeb.DataAccess.Data;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

namespace Sesion04.ECommerceWeb.Repositorios.Implementaciones;

public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
{
    public ClienteRepositorio(ECommerceDbContext context) : base(context)
    {
    }

    public Cliente? BuscarPorEmail(string email)
    {
        return Context.Set<Cliente>()
            .FirstOrDefault(p => p.Email == email);
    }
}