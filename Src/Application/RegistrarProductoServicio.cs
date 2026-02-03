using MercaditoUTM.Src.Core.Entities;
using System;

namespace MercaditoUTM.Src.Application;

public class RegistrarProductoServicio : IRegistrarProducto
{
    public void RegistrarProducto(Articulo producto)
    {
        // En una aplicación real, aquí iría la lógica para guardar en la base de datos.
        Console.WriteLine($"Producto '{producto.Nombre}' registrado con éxito.");
    }
}
