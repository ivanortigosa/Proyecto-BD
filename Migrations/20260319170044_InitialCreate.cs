using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServidorApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Imagen = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articulos",
                columns: new[] { "Id", "Imagen", "Nombre", "Precio", "Stock" },
                values: new object[,]
                {
                    { 1, "/fotos/Aceite de oliva virgen extra 1L 779.png", "Aceite de oliva virgen extra 1L", 7.79m, 25 },
                    { 2, "/fotos/Agua mineral 1,5L 075.png", "Agua mineral 1,5L", 0.75m, 120 },
                    { 3, "/fotos/Arroz redondo 1kg 195.png", "Arroz redondo 1kg", 1.95m, 80 },
                    { 4, "/fotos/Azúcar blanco 1kg 150.png", "Azúcar blanco 1kg", 1.50m, 70 },
                    { 5, "/fotos/Barra de pan 075.png", "Barra de pan", 0.75m, 150 },
                    { 6, "/fotos/Carne picada mixta 500g 520.png", "Carne picada mixta 500g", 5.20m, 35 },
                    { 7, "/fotos/Chocolate con leche 100g 299.png", "Chocolate con leche 100g", 2.00m, 46 },
                    { 8, "/fotos/Detergente líquido 2L 1420.png", "Detergente líquido 2L", 14.20m, 30 },
                    { 9, "/fotos/Galletas María 100.png", "Galletas María", 1.00m, 90 },
                    { 10, "/fotos/Helado de vainilla 1L 412.png", "Helado de vainilla 1L", 4.12m, 25 },
                    { 11, "/fotos/Huevos camperos (12u) 419.png", "Huevos camperos (12u)", 4.19m, 50 },
                    { 12, "/fotos/Leche semidesnatada 1L 135.png", "Leche semidesnatada 1L", 1.35m, 110 },
                    { 13, "/fotos/Leche sin lactosa 1L 155.png", "Leche sin lactosa 1L", 1.55m, 90 },
                    { 14, "/fotos/Lechuga iceberg 130.png", "Lechuga iceberg", 1.30m, 40 },
                    { 15, "/fotos/Lentejas pardinas 1kg 350.png", "Lentejas pardinas 1kg", 3.50m, 60 },
                    { 16, "/fotos/Manzanas Golden 1kg 199.png", "Manzanas Golden 1kg", 1.99m, 70 },
                    { 17, "/fotos/Naranjas 1kg 225.png", "Naranjas 1kg", 2.25m, 65 },
                    { 18, "/fotos/Pan de molde integral 135.png", "Pan de molde integral", 1.35m, 55 },
                    { 19, "/fotos/Papel higiénico (12 rollos) 715.png", "Papel higiénico (12 rollos)", 7.15m, 45 },
                    { 20, "/fotos/Pasta espaguetis 1kg 120.png", "Pasta espaguetis 1kg", 1.20m, 85 },
                    { 21, "/fotos/Pechuga de pollo 1kg 649.png", "Pechuga de pollo 1kg", 6.49m, 30 },
                    { 22, "/fotos/Pizza congelada 4 quesos 395.png", "Pizza congelada 4 quesos", 3.95m, 50 },
                    { 23, "/fotos/Plátanos 1kg Canarias 292.png", "Plátanos 1kg Canarias", 2.92m, 75 },
                    { 24, "/fotos/Refresco de cola 2L 215.png", "Refresco de cola 2L", 2.15m, 95 },
                    { 25, "/fotos/Sal fina 1kg 040.png", "Sal fina 1kg", 0.40m, 100 },
                    { 26, "/fotos/Tomates pera 1kg 144.png", "Tomates pera 1kg", 1.44m, 60 },
                    { 27, "/fotos/Vinagre de vino 500ml 079.png", "Vinagre de vino 500ml", 0.79m, 80 },
                    { 28, "/fotos/Yogur proteico de fresa 199.png", "Yogur proteico de fresa", 1.99m, 70 },
                    { 29, "/fotos/Yogur proteico natural 199.png", "Yogur proteico natural", 1.99m, 70 },
                    { 30, "/fotos/Zanahorias 1kg 135.png", "Zanahorias 1kg", 1.35m, 85 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");
        }
    }
}
