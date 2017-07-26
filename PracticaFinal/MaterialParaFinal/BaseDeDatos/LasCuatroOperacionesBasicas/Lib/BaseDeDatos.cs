using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Lib
{
    public static class BaseDeDatos
    {
        public static string leer()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);
                SqlCommand comando = new SqlCommand("Select * from Personas", conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    sb.AppendFormat("ID:{0} \nNombre:{1} \nApellido:{2} \nEdad:{3}\n", reader["id"], reader["nombre"], reader["apellido"], reader["edad"]);
                    sb.AppendLine("------------------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return sb.ToString();
        }

        public static void insertar() 
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);
            string sql = "INSERT INTO Personas(nombre,apellido,edad) VALUES(";
            sql += "'" + "nacho" + "','" + "Aurtenechea" + "'," + "26" + "";
            sql += ")";

            SqlCommand comando = new SqlCommand(sql, conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        public static void borrar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);
            string sql = "delete Personas where apellido = '" + "aurtenechea" + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        public static void modificar()
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);
            string sql = "update Personas set nombre='nachoModificado', edad=27 where nombre = '" + "nacho" + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }


        public static string ObtenerNombreDeColumnas() 
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);
            SqlCommand comando = new SqlCommand("Select * from Personas", conexion);
            conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();

            StringBuilder sb = new StringBuilder();
            /*  obtener nombre de columnas. */
            for (int i = 0; i < reader.FieldCount; i++)
            {
                sb.AppendFormat("indice: {0}, columna: {1}, tipoDato: {2}\n", i, reader.GetName(i), reader.GetDataTypeName(i));
            }
            return sb.ToString();
        }

    }
}
