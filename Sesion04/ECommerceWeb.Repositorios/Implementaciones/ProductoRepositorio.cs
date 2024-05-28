using Microsoft.EntityFrameworkCore;
using Sesion04.ECommerceWeb.Entidades;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

namespace Sesion04.ECommerceWeb.Repositorios.Implementaciones;

public class ProductoRepositorio : RepositorioBase<Producto>, IProductoRepositorio
{
    public ProductoRepositorio(DbContext context) : base(context)
    {
    }
}