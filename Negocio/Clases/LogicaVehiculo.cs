using ProyectoExtreme_Datos;
using ProyectoExtreme_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtreme_Negocio.Clases
{
    public class LogicaVehiculo : IVehiculo
    {
        private ProyectoExtremeContext db;

        public LogicaVehiculo(ProyectoExtremeContext db)
        {
            this.db = db;
        }

        public List<Vehiculo> GetVehiculos()
        {
            return db.Vehiculos.ToList();
        }
    }
}
