using ProyectoExtreme_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtreme_Negocio.Interfaces
{
    public interface IUsuario
    {
        List<Usuario> GetUsuarios();
    }
}
