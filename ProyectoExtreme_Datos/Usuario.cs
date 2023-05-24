using System;
using System.Collections.Generic;

namespace ProyectoExtreme_Datos
{
    public partial class Usuario
    {
        public Usuario()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Password { get; set; }
        public string? Dni { get; set; }
        public string? Carnet { get; set; }
        public string? Telefono { get; set; }
        public string? Provincia { get; set; }
        public string? Municipio { get; set; }
        public string? Direccion { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
