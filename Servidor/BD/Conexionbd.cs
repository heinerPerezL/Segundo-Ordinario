using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Servidor.BD
{
    class Conexionbd
    {
        // String de Conexión
        private String cadenaConexion = @"Data Source=SMORENO_POR\SQL;Initial Catalog=Notas;Integrated Security=True";
        SqlConnection Conexion;

        public SqlConnection iniciarConexion()
        {
            this.Conexion = new SqlConnection(this.cadenaConexion);
            return this.Conexion;

        }

        /*Metodo Insertar datos */
        public bool ingresoBD(String comandoPrueba) // abre y cierra la conexión con la BD
        {
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = comandoPrueba;
                Comando.Connection = this.iniciarConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Retornar datos
        public DataSet Proceso(SqlCommand sqlmetodo)
        {
            DataSet Me = new DataSet();
            SqlDataAdapter Ad = new SqlDataAdapter();

            try
            {
                SqlCommand com = new SqlCommand();
                com = sqlmetodo;
                com.Connection = iniciarConexion();
                Ad.SelectCommand = com;
                Conexion.Open();
                Ad.Fill(Me);
                Conexion.Close();
                return Me;
            }
            catch
            {

                return Me;
            }
        }
    }
}








        






    
   
   

