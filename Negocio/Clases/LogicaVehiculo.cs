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

        public string InsertVehiculo(Vehiculo vehiculo)
        {
            db.Vehiculos.Add(vehiculo);
            db.SaveChanges();

            return "OK";
        }

        public string UpdateVehiculo(int id, Vehiculo vehiculoUpdate)
        {
            Vehiculo? vehiculo = db.Vehiculos.Where(a => a.Id == id).FirstOrDefault();

            if (vehiculo == null)
            {
                return "no se ha encontrado un vehiculo con este ID";
            }
            else
            {
                vehiculo.Marca = vehiculoUpdate.Marca;
                vehiculo.Modelo = vehiculoUpdate.Modelo;
                vehiculo.Potencia = vehiculoUpdate.Potencia;
                vehiculo.Categoria = vehiculoUpdate.Categoria;
                vehiculo.Potencia = vehiculoUpdate.Potencia;

                db.SaveChanges();
                return "OK";
            }

        }

        public string DeleteVehiculo(int id)
        {
            Vehiculo? vehiculo = db.Vehiculos.Where(a => a.Id == id).FirstOrDefault();

            if (vehiculo == null)
            {
                return "no se ha encontrado un vehiculo con este ID";
            }
            else
            {
                db.Vehiculos.Remove(vehiculo);
                db.SaveChanges();
                return "Vehiculo eliminado";
            }
        }

    }
}
