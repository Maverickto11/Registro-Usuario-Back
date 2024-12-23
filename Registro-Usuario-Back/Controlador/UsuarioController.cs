using Microsoft.AspNetCore.Mvc;
using Registro_Usuario_Back.Entidad;
using Registro_Usuario_Back.Repositorio;

namespace Registro_Usuario_Back.Controlador
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = await _usuarioRepository.GetUsuariosAsync();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _usuarioRepository.GetUsuarioByIdAsync(id);
            if (usuario == null)
            {
                return NotFound(new { message = "Usuario no encontrado" });
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> AddUsuario([FromBody] Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest(new { message = "Datos inválidos" });
            }

            var nuevoUsuario = await _usuarioRepository.AddUsuarioAsync(usuario);
            return Ok(new { message = "Usuario registrado con éxito", usuario = nuevoUsuario });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var eliminado = await _usuarioRepository.DeleteUsuarioAsync(id);
            if (!eliminado)
            {
                return NotFound(new { message = "Usuario no encontrado" });
            }
            return Ok(new { message = "Usuario eliminado correctamente" });
        }
    }
}