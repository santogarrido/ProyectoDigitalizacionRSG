using Microsoft.AspNetCore.Mvc;
using ProyectoDigitalizacion2.Components.Models;

namespace ProyectoDigitalizacion2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = _context.Usuarios.ToList();
            return Ok(usuarios);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }
    }
}
