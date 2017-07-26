using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// sql
using System.Data.SqlClient;
//using System.Data;
//using System.Data.Sql;

namespace _21_baseDeDatosConexion2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);
                SqlCommand comando = new SqlCommand("Select * from Personas", conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                ///*  obtener nombre de columnas. */
                //for (int i = 0; i < reader.FieldCount; i++)
                //{
                //    Console.WriteLine(reader.GetName(i));
                //}

                while(reader.Read())
                {
                    sb.AppendFormat("ID:{0} \nNombre:{1} \nApellido:{2} \nEdad:{3}\n", reader["id"], reader["nombre"], reader["apellido"], reader["edad"]);
                    sb.AppendLine("------------------");
                }

                Console.WriteLine(sb.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            Console.ReadKey();
        }
        
    }
}
