using MercaditoUTM.Src.Application;
using MercaditoUTM.Src.Core.Entities;

// Registrar nuevos productos
var servicioRegistro = new RegistrarProductoServicio();
Console.WriteLine("--- REGISTRANDO NUEVOS PRODUCTOS ---");
servicioRegistro.RegistrarProducto(new Articulo { Nombre = "SSD 1TB", Precio = 1500, Stock = 50 });
servicioRegistro.RegistrarProducto(new Articulo { Nombre = "Memoria RAM 16GB DDR4", Precio = 1200, Stock = 30 });
servicioRegistro.RegistrarProducto(new Articulo { Nombre = "Tarjeta de Video RTX 4060", Precio = 8000, Stock = 10 });
servicioRegistro.RegistrarProducto(new Articulo { Nombre = "Fuente de Poder 750W", Precio = 1800, Stock = 25 });
servicioRegistro.RegistrarProducto(new Articulo { Nombre = "Gabinete ATX", Precio = 1300, Stock = 40 });
Console.WriteLine("------------------------------------");
Console.WriteLine();

// Consultar y mostrar productos existentes
var servicio = new ConsultarProductosServicio();
var lista = servicio.ConsultarProductos();
Console.WriteLine("--- BIENVENIDO AL MERCADITO UTM ---");
foreach (var item in lista) {
    Console.WriteLine($"Producto: {item.Nombre} | Precio: ${item.Precio}");
}