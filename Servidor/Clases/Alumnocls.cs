using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Clases
{
    class Alumnocls // se daclaran las variables
    {
        public Alumnocls() { }
        public Alumnocls(string id_alumno, string dsc_nombre, string dsc_apellido1, string dsc_apellido2, string dsc_user_name, string dsc_password, string dsc_rol)
        {
            Id_alumno = id_alumno;
            Dsc_nombre = dsc_nombre;
            Dsc_apellido1 = dsc_apellido1;
            Dsc_apellido2 = dsc_apellido2;
            Dsc_user_name = dsc_user_name;
            Dsc_password = dsc_password;
            Dsc_rol = dsc_rol;
        }

        public String Id_alumno { get; set; }
        public String Dsc_nombre { get; set; }
        public String Dsc_apellido1 { get; set; }
        public String Dsc_apellido2 { get; set; }
        public String Dsc_user_name { get; set; }
        public String Dsc_password { get; set; }
        public String Dsc_rol { get; set; }



    }
}
