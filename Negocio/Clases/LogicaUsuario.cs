using ProyectoExtreme_Datos;
using ProyectoExtreme_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoExtreme_Negocio.Clases
{
    public class LogicaUsuario : IUsuario
    {
        private ProyectoExtremeContext db;

        public LogicaUsuario(ProyectoExtremeContext db)
        {
            this.db = db;
        }

        public List<Usuario> GetUsuarios()
        {
            return db.Usuarios.ToList();
        }
            

    }
}
