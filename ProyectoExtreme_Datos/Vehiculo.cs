using System;
using System.Collections.Generic;

namespace ProyectoExtreme_Datos
{
    public partial class Vehiculo
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Potencia { get; set; }
        public string? Categoria { get; set; }
        public int? IdUsuario { get; set; }

        public virtual Usuario? IdUsuarioNavigation { get; set; }
    }
}
