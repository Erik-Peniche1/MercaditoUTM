using MercaditoUTM.Src.Core.Entities;
namespace MercaditoUTM.Src.Application;
public class ConsultarProductosServicio : IConsultarProductos {
    public List<Articulo> ConsultarProductos() {
        var random = new Random();
        var productos = new List<Articulo>();

        string[] categorias = { "Laptop", "Mouse", "Teclado", "Monitor", "Audifonos", "Webcam", "Microfono", "Bocinas" };
        string[] marcas = { "Dell", "HP", "Logitech", "Razer", "Sony", "Samsung", "LG", "HyperX" };
        string[] tipos = { "Gamer", "Oficina", "Inalambrico", "Alambrico", "Mecanico", "Membrana", "Curvo", "Plano" };

        for (int i = 0; i < 25; i++)
        {
            var categoria = categorias[random.Next(categorias.Length)];
            var marca = marcas[random.Next(marcas.Length)];
            var tipo = tipos[random.Next(tipos.Length)];
            var nombre = $"{categoria} {marca} {tipo}";
            var precio = (decimal)(random.NextDouble() * 10000) + 500;
            var stock = random.Next(1, 100);

            productos.Add(new Articulo { Nombre = nombre, Precio = Math.Round(precio, 2), Stock = stock });
        }

        return productos;
    }
}