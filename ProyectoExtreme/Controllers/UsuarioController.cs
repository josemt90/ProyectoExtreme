using Microsoft.AspNetCore.Mvc;
using ProyectoExtreme_Datos;
using ProyectoExtreme_Negocio.Clases;
using ProyectoExtreme_Negocio.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoExtreme_API.Controllers
{
    

   

    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //Creamos instancia de la interfaz de usuario y creamos el contructor pasandole esa instancia
        IUsuario _usuario;

        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _usuario.GetUsuarios();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public IEnumerable<Usuario> Get(int id)
        {
            return _usuario.GetUsuarios().Where(a=>a.Id==id);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public string Post([FromBody] Usuario usuario)
        {
           string resultado = _usuario.InsertUsuario(usuario);

            return resultado;
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Usuario usuario)
        {
            string resultado = _usuario.UpdateUsuario(id, usuario);

            return resultado;
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string resultado = _usuario.DeleteUsuario(id);

            return resultado;
        }
    }
}
