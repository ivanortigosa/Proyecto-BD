using Microsoft.EntityFrameworkCore;
using ServidorApi.Models;

namespace ServidorApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Articulo> Articulos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>().HasData(
                new Articulo { Id = 1, Nombre = "Aceite de oliva virgen extra 1L", Stock = 25, Imagen = "/imagenes/Aceite de oliva virgen extra 1L 779.png", Precio = 7.79m },
                new Articulo { Id = 2, Nombre = "Agua mineral 1,5L", Stock = 120, Imagen = "/imagenes/Agua mineral 1,5L 075.png", Precio = 0.75m },
                new Articulo { Id = 3, Nombre = "Arroz redondo 1kg", Stock = 80, Imagen = "/imagenes/Arroz redondo 1kg 195.png", Precio = 1.95m },
                new Articulo { Id = 4, Nombre = "Azúcar blanco 1kg", Stock = 70, Imagen = "/imagenes/Azúcar blanco 1kg 150.png", Precio = 1.50m },
                new Articulo { Id = 5, Nombre = "Barra de pan", Stock = 150, Imagen = "/imagenes/Barra de pan 075.png", Precio = 0.75m },
                new Articulo { Id = 6, Nombre = "Carne picada mixta 500g", Stock = 35, Imagen = "/imagenes/Carne picada mixta 500g 520.png", Precio = 5.20m },
                new Articulo { Id = 7, Nombre = "Chocolate con leche 100g", Stock = 46, Imagen = "/imagenes/Chocolate con leche 100g 299.png", Precio = 2.00m },
                new Articulo { Id = 8, Nombre = "Detergente líquido 2L", Stock = 30, Imagen = "/imagenes/Detergente líquido 2L 1420.png", Precio = 14.20m },
                new Articulo { Id = 9, Nombre = "Galletas María", Stock = 90, Imagen = "/imagenes/Galletas María 100.png", Precio = 1.00m },
                new Articulo { Id = 10, Nombre = "Helado de vainilla 1L", Stock = 25, Imagen = "/imagenes/Helado de vainilla 1L 412.png", Precio = 4.12m },
                new Articulo { Id = 11, Nombre = "Huevos camperos (12u)", Stock = 50, Imagen = "/imagenes/Huevos camperos (12u) 419.png", Precio = 4.19m },
                new Articulo { Id = 12, Nombre = "Leche semidesnatada 1L", Stock = 110, Imagen = "/imagenes/Leche semidesnatada 1L 135.png", Precio = 1.35m },
                new Articulo { Id = 13, Nombre = "Leche sin lactosa 1L", Stock = 90, Imagen = "/imagenes/Leche sin lactosa 1L 155.png", Precio = 1.55m },
                new Articulo { Id = 14, Nombre = "Lechuga iceberg", Stock = 40, Imagen = "/imagenes/Lechuga iceberg 130.png", Precio = 1.30m },
                new Articulo { Id = 15, Nombre = "Lentejas pardinas 1kg", Stock = 60, Imagen = "/imagenes/Lentejas pardinas 1kg 350.png", Precio = 3.50m },
                new Articulo { Id = 16, Nombre = "Manzanas Golden 1kg", Stock = 70, Imagen = "/imagenes/Manzanas Golden 1kg 199.png", Precio = 1.99m },
                new Articulo { Id = 17, Nombre = "Naranjas 1kg", Stock = 65, Imagen = "/imagenes/Naranjas 1kg 225.png", Precio = 2.25m },
                new Articulo { Id = 18, Nombre = "Pan de molde integral", Stock = 55, Imagen = "/imagenes/Pan de molde integral 135.png", Precio = 1.35m },
                new Articulo { Id = 19, Nombre = "Papel higiénico (12 rollos)", Stock = 45, Imagen = "/imagenes/Papel higiénico (12 rollos) 715.png", Precio = 7.15m },
                new Articulo { Id = 20, Nombre = "Pasta espaguetis 1kg", Stock = 85, Imagen = "/imagenes/Pasta espaguetis 1kg 120.png", Precio = 1.20m },
                new Articulo { Id = 21, Nombre = "Pechuga de pollo 1kg", Stock = 30, Imagen = "/imagenes/Pechuga de pollo 1kg 649.png", Precio = 6.49m },
                new Articulo { Id = 22, Nombre = "Pizza congelada 4 quesos", Stock = 50, Imagen = "/imagenes/Pizza congelada 4 quesos 395.png", Precio = 3.95m },
                new Articulo { Id = 23, Nombre = "Plátanos 1kg Canarias", Stock = 75, Imagen = "/imagenes/Plátanos 1kg Canarias 292.png", Precio = 2.92m },
                new Articulo { Id = 24, Nombre = "Refresco de cola 2L", Stock = 95, Imagen = "/imagenes/Refresco de cola 2L 215.png", Precio = 2.15m },
                new Articulo { Id = 25, Nombre = "Sal fina 1kg", Stock = 100, Imagen = "/imagenes/Sal fina 1kg 040.png", Precio = 0.40m },
                new Articulo { Id = 26, Nombre = "Tomates pera 1kg", Stock = 60, Imagen = "/imagenes/Tomates pera 1kg 144.png", Precio = 1.44m },
                new Articulo { Id = 27, Nombre = "Vinagre de vino 500ml", Stock = 80, Imagen = "/imagenes/Vinagre de vino 500ml 079.png", Precio = 0.79m },
                new Articulo { Id = 28, Nombre = "Yogur proteico de fresa", Stock = 70, Imagen = "/imagenes/Yogur proteico de fresa 199.png", Precio = 1.99m },
                new Articulo { Id = 29, Nombre = "Yogur proteico natural", Stock = 70, Imagen = "/imagenes/Yogur proteico natural 199.png", Precio = 1.99m },
                new Articulo { Id = 30, Nombre = "Zanahorias 1kg", Stock = 85, Imagen = "/imagenes/Zanahorias 1kg 135.png", Precio = 1.35m }
            );
        }
    }
}
