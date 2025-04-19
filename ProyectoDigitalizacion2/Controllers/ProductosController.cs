using Microsoft.AspNetCore.Mvc;
using ProyectoDigitalizacion2.Components.Models;

namespace ProyectoDigitalizacion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var productos = _context.Productos.ToList();
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Productos producto)
        {
            try
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = _context.Productos.FirstOrDefault(u => u.Id == id);
            if (producto == null)
                return NotFound();

            try
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al eliminar: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }
    }
}
