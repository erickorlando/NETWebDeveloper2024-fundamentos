using Microsoft.AspNetCore.Mvc;
using Sesion04.ECommerceWeb.Repositorios.Interfaces;

namespace ECommerceWeb.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VentasController : ControllerBase
{
    private readonly IVentaRepositorio _repositorio;

    public VentasController(IVentaRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet]
    public IActionResult Get(int id)
    {
        var venta = _repositorio.MostrarVenta(id);

        if (venta is null)
            return NotFound("No se encontro el registro");

        return Ok(new
        {
            Id = venta.Id,
            NombreCliente = venta.Cliente.Nombre + " " + venta.Cliente.Apellidos,
            NumeroProductos = venta.Detalles.Count,
        });
    }
}