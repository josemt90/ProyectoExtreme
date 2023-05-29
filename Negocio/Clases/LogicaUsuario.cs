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

        public string InsertUsuario(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();

            return "OK" ;
        }

        public string UpdateUsuario(int id,Usuario usuarioUpdate)
        {
          Usuario? usuario = db.Usuarios.Where(a => a.Id == id).FirstOrDefault();

            if (usuario == null)
            {
                return "no se ha encontrado un usuario con este ID";
            }
            else
            {
                usuario.Dni = usuarioUpdate.Dni;
                usuario.Nombre = usuarioUpdate.Nombre;
                usuario.Apellidos = usuarioUpdate.Apellidos;
                usuario.Carnet = usuarioUpdate.Carnet;
                usuario.Direccion = usuarioUpdate.Direccion;
                usuario.Municipio = usuarioUpdate.Municipio;
                usuario.Telefono = usuarioUpdate.Telefono;
                usuario.Password = usuarioUpdate.Password;
                usuario.Provincia = usuarioUpdate.Provincia;

                db.SaveChanges();
                return "OK";
            }

        }

        public string DeleteUsuario(int id)
        {
            Usuario? usuario = db.Usuarios.Where(a => a.Id == id).FirstOrDefault();

            if (usuario == null)
            {
                return "no se ha encontrado un usuario con este ID";
            }
            else
            {
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
                return "usuario eliminado";
            }
        }


    }
}
