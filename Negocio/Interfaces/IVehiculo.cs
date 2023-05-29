using ProyectoExtreme_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtreme_Negocio.Interfaces
{

    //VIDEO: https://www.youtube.com/watch?v=Mgcn8wx07bk&t=339s

    public interface IVehiculo
    {
        List<Vehiculo> GetVehiculos();
        string InsertVehiculo(Vehiculo vehiculo);
        string UpdateVehiculo(int id, Vehiculo vehiculo);
        string DeleteVehiculo(int id);
    }
}
