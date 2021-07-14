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
    class Cursobd
    {
        Conexionbd opconexion;

        public Cursobd()
        {
            opconexion = new Conexionbd();
        }
         
       
        public bool insertar(Cursocls opcursocls) // se insertan los datos de alumno en la BD
        {
            return opconexion.ingresoBD("INSERT INTO Cursos(Id_curso,Dsc_curso,Dsc_Grado,Can_Horas)VALUES('" + opcursocls.Id_curso + "','" + opcursocls.Dsc_curso + "','" + opcursocls.Dsc_Grado + "','" + opcursocls.Dsc_Horas + "')");

        }


        public static List<Cursocls> llenarCbxCurso()// se llenan los datos de Conductor en
                                                       // una lista 
        {
            Conexionbd opconexion = new Conexionbd();
            List<Cursocls> lista = new List<Cursocls>();
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnx = opconexion.iniciarConexion();

            try
            {
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Cursos";
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {

                    Cursocls entidad = new Cursocls();
                    entidad.Id_curso = Convert.ToString(lector[0]);
                    entidad.Dsc_curso= Convert.ToString(lector[1]);
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



