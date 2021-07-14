using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servidor.BD;
using Servidor.Clases;
using System.Data.SqlClient;
using System.Data;

namespace Servidor.BD
{
    
    class CursosAlumnobd
    {
        Conexionbd opconexion;

        public CursosAlumnobd()
        {
            opconexion = new Conexionbd();
        }

        public DataSet MostrarCxA()
        {
            SqlCommand mos = new SqlCommand("SELECT * FROM CursosAlumno");
            return opconexion.Proceso(mos); 




        }

        

    




    }
}
