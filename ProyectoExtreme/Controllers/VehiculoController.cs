using Microsoft.AspNetCore.Mvc;
using ProyectoExtreme_Datos;
using ProyectoExtreme_Negocio.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectoExtreme_API.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        IVehiculo _vehiculo;

        public VehiculoController(IVehiculo vehiculo)
        {
            this._vehiculo = vehiculo;
        }



        // GET: api/<VehiculoController>
        [HttpGet]
        public IEnumerable<Vehiculo> Get()
        {
            return _vehiculo.GetVehiculos();
        }

        // GET api/<VehiculoController>/5
        [HttpGet("{id}")]
        public IEnumerable<Vehiculo> Get(int id)
        {
            return _vehiculo.GetVehiculos().Where(a=>a.Id==id);
        }

        // POST api/<vehiculoController>
        [HttpPost]
        public string Post([FromBody] Vehiculo vehiculo)
        {
            string resultado = _vehiculo.InsertVehiculo(vehiculo);

            return resultado;
        }

        // PUT api/<vehiculoController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Vehiculo vehiculo)
        {
            string resultado = _vehiculo.UpdateVehiculo(id, vehiculo);

            return resultado;
        }

        // DELETE api/<vehiculoController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string resultado = _vehiculo.DeleteVehiculo(id);

            return resultado;
        }
    }
}
