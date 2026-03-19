namespace ServidorApi.Models
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int Stock { get; set; }
        public string Imagen { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}
