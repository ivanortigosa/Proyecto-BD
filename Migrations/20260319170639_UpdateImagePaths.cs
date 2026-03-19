using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServidorApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImagePaths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Imagen",
                value: "fotos/Aceite de oliva virgen extra 1L 779.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Imagen",
                value: "fotos/Agua mineral 1,5L 075.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Imagen",
                value: "fotos/Arroz redondo 1kg 195.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Imagen",
                value: "fotos/Azúcar blanco 1kg 150.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Imagen",
                value: "fotos/Barra de pan 075.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Imagen",
                value: "fotos/Carne picada mixta 500g 520.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Imagen",
                value: "fotos/Chocolate con leche 100g 299.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Imagen",
                value: "fotos/Detergente líquido 2L 1420.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Imagen",
                value: "fotos/Galletas María 100.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Imagen",
                value: "fotos/Helado de vainilla 1L 412.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Imagen",
                value: "fotos/Huevos camperos (12u) 419.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Imagen",
                value: "fotos/Leche semidesnatada 1L 135.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Imagen",
                value: "fotos/Leche sin lactosa 1L 155.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Imagen",
                value: "fotos/Lechuga iceberg 130.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Imagen",
                value: "fotos/Lentejas pardinas 1kg 350.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Imagen",
                value: "fotos/Manzanas Golden 1kg 199.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 17,
                column: "Imagen",
                value: "fotos/Naranjas 1kg 225.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 18,
                column: "Imagen",
                value: "fotos/Pan de molde integral 135.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 19,
                column: "Imagen",
                value: "fotos/Papel higiénico (12 rollos) 715.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 20,
                column: "Imagen",
                value: "fotos/Pasta espaguetis 1kg 120.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 21,
                column: "Imagen",
                value: "fotos/Pechuga de pollo 1kg 649.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 22,
                column: "Imagen",
                value: "fotos/Pizza congelada 4 quesos 395.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 23,
                column: "Imagen",
                value: "fotos/Plátanos 1kg Canarias 292.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 24,
                column: "Imagen",
                value: "fotos/Refresco de cola 2L 215.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 25,
                column: "Imagen",
                value: "fotos/Sal fina 1kg 040.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 26,
                column: "Imagen",
                value: "fotos/Tomates pera 1kg 144.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 27,
                column: "Imagen",
                value: "fotos/Vinagre de vino 500ml 079.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 28,
                column: "Imagen",
                value: "fotos/Yogur proteico de fresa 199.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 29,
                column: "Imagen",
                value: "fotos/Yogur proteico natural 199.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 30,
                column: "Imagen",
                value: "fotos/Zanahorias 1kg 135.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Imagen",
                value: "/fotos/Aceite de oliva virgen extra 1L 779.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Imagen",
                value: "/fotos/Agua mineral 1,5L 075.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Imagen",
                value: "/fotos/Arroz redondo 1kg 195.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Imagen",
                value: "/fotos/Azúcar blanco 1kg 150.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 5,
                column: "Imagen",
                value: "/fotos/Barra de pan 075.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 6,
                column: "Imagen",
                value: "/fotos/Carne picada mixta 500g 520.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 7,
                column: "Imagen",
                value: "/fotos/Chocolate con leche 100g 299.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 8,
                column: "Imagen",
                value: "/fotos/Detergente líquido 2L 1420.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 9,
                column: "Imagen",
                value: "/fotos/Galletas María 100.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 10,
                column: "Imagen",
                value: "/fotos/Helado de vainilla 1L 412.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 11,
                column: "Imagen",
                value: "/fotos/Huevos camperos (12u) 419.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 12,
                column: "Imagen",
                value: "/fotos/Leche semidesnatada 1L 135.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 13,
                column: "Imagen",
                value: "/fotos/Leche sin lactosa 1L 155.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 14,
                column: "Imagen",
                value: "/fotos/Lechuga iceberg 130.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 15,
                column: "Imagen",
                value: "/fotos/Lentejas pardinas 1kg 350.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 16,
                column: "Imagen",
                value: "/fotos/Manzanas Golden 1kg 199.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 17,
                column: "Imagen",
                value: "/fotos/Naranjas 1kg 225.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 18,
                column: "Imagen",
                value: "/fotos/Pan de molde integral 135.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 19,
                column: "Imagen",
                value: "/fotos/Papel higiénico (12 rollos) 715.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 20,
                column: "Imagen",
                value: "/fotos/Pasta espaguetis 1kg 120.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 21,
                column: "Imagen",
                value: "/fotos/Pechuga de pollo 1kg 649.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 22,
                column: "Imagen",
                value: "/fotos/Pizza congelada 4 quesos 395.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 23,
                column: "Imagen",
                value: "/fotos/Plátanos 1kg Canarias 292.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 24,
                column: "Imagen",
                value: "/fotos/Refresco de cola 2L 215.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 25,
                column: "Imagen",
                value: "/fotos/Sal fina 1kg 040.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 26,
                column: "Imagen",
                value: "/fotos/Tomates pera 1kg 144.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 27,
                column: "Imagen",
                value: "/fotos/Vinagre de vino 500ml 079.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 28,
                column: "Imagen",
                value: "/fotos/Yogur proteico de fresa 199.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 29,
                column: "Imagen",
                value: "/fotos/Yogur proteico natural 199.png");

            migrationBuilder.UpdateData(
                table: "Articulos",
                keyColumn: "Id",
                keyValue: 30,
                column: "Imagen",
                value: "/fotos/Zanahorias 1kg 135.png");
        }
    }
}
