using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServidorApi.Data;
using ServidorApi.Models;

namespace ServidorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticulosController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ArticulosController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Articulo>>> Get(string? q, string? orden)
        {
            var query = _context.Articulos.AsQueryable();

            if (!string.IsNullOrWhiteSpace(q))
            {
                string texto = q.ToLower();
                query = query.Where(a => a.Nombre.ToLower().Contains(texto));
            }

            query = orden == "desc"
                ? query.OrderByDescending(a => a.Nombre)
                : query.OrderBy(a => a.Nombre);

            return await query.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Articulo>> Get(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null) return NotFound();
            return articulo;
        }

        [HttpPost]
        public async Task<ActionResult<Articulo>> Post(
            [FromForm] string nombre,
            [FromForm] int stock,
            [FromForm] decimal precio,
            IFormFile imagen)
        {
            var articulo = new Articulo
            {
                Nombre = nombre,
                Stock = stock,
                Precio = precio
            };

            if (imagen != null)
            {
                string carpeta = Path.Combine(_env.WebRootPath, "imagenes");
                Directory.CreateDirectory(carpeta);

                string ruta = Path.Combine(carpeta, imagen.FileName);

                using var stream = new FileStream(ruta, FileMode.Create);
                await imagen.CopyToAsync(stream);

                articulo.Imagen = "/imagenes/" + imagen.FileName;
            }

            _context.Articulos.Add(articulo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = articulo.Id }, articulo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(
            int id,
            [FromForm] string nombre,
            [FromForm] int stock,
            [FromForm] decimal precio,
            [FromForm] string imagenActual,
            IFormFile imagen)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null) return NotFound();

            articulo.Nombre = nombre;
            articulo.Stock = stock;
            articulo.Precio = precio;

            if (imagen != null)
            {
                if (!string.IsNullOrEmpty(articulo.Imagen))
                {
                    string rutaRelativa = articulo.Imagen
                        .Replace("/", Path.DirectorySeparatorChar.ToString())
                        .TrimStart(Path.DirectorySeparatorChar);

                    string rutaVieja = Path.Combine(_env.WebRootPath, rutaRelativa);

                    if (System.IO.File.Exists(rutaVieja))
                        System.IO.File.Delete(rutaVieja);
                }

                string carpeta = Path.Combine(_env.WebRootPath, "imagenes");
                Directory.CreateDirectory(carpeta);

                string rutaNueva = Path.Combine(carpeta, imagen.FileName);

                using var stream = new FileStream(rutaNueva, FileMode.Create);
                await imagen.CopyToAsync(stream);

                articulo.Imagen = "/imagenes/" + imagen.FileName;
            }
            else
            {
                articulo.Imagen = imagenActual;
            }

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var articulo = await _context.Articulos.FindAsync(id);
            if (articulo == null) return NotFound();

            if (!string.IsNullOrEmpty(articulo.Imagen))
            {
                string rutaRelativa = articulo.Imagen
                    .Replace("/", Path.DirectorySeparatorChar.ToString())
                    .TrimStart(Path.DirectorySeparatorChar);

                string rutaImagen = Path.Combine(_env.WebRootPath, rutaRelativa);

                if (System.IO.File.Exists(rutaImagen))
                    System.IO.File.Delete(rutaImagen);
            }

            _context.Articulos.Remove(articulo);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
