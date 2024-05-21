using ECommerceWeb.Entidades;
using ECommerceWeb.Repositorios.Interfaces;

namespace ECommerceWeb.Repositorios.Implementaciones;

public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio   
{
    public Cliente? BuscarPorEmail(string email)
    {
        return Datos.FirstOrDefault(p => p.Email == email);
    }
}