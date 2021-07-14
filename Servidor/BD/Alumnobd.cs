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
    class Alumnobd
    {
        Conexionbd opconexion;

        public Alumnobd()
        {
            opconexion = new Conexionbd();
        }
         
       
        public bool insertar(Alumnocls opalumnocls) // se insertan los datos de alumno en la BD
        {
            return opconexion.ingresoBD("INSERT INTO Alumno(Id_alumno,Dsc_nombre,Dsc_apellido1,Dsc_apellido2,Dsc_user_name,Dsc_password,Dsc_rol)VALUES('" + opalumnocls.Id_alumno + "','" + opalumnocls.Dsc_nombre + "','" + opalumnocls.Dsc_apellido1 + "','" + opalumnocls.Dsc_apellido2 + "', '" + opalumnocls.Dsc_user_name + "', '" + opalumnocls.Dsc_password + "', '" + opalumnocls.Dsc_rol + "')");
        }

        public static List<Alumnocls> llenarCbxAlumno()// se llenan los datos de Conductor en
                                                            // una lista 
        {
            Conexionbd opconexion = new Conexionbd();
            List<Alumnocls> lista = new List<Alumnocls>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnx = opconexion.iniciarConexion();

            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Alumno";
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {

                    Alumnocls entidad = new Alumnocls();
                    entidad.Id_alumno = Convert.ToString(lector[0]);
                    entidad.Dsc_nombre = Convert.ToString(lector[1]);
                    lista.Add(entidad);
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return lista;
        }



    }

    }

