using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Data;
//using System.Data.Sql;

namespace _21_baseDeDatosConexion
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Properties.Settings.Default.StringBaseDatos);


            StringBuilder texto = new StringBuilder();
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.StringBaseDatos);

                SqlCommand comando = new SqlCommand("Select * FROM Personas", conexion);

                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                texto.AppendLine("\n\nLISTADO EN BASE DE DATOS\n\n");
                while (reader.Read())
                {
                    texto.AppendFormat("ID: {0}\nApellido: {1}\nNombre: {2}\n Edad: {3}\n", reader[0], reader[2], reader[1], reader[3]);
                    texto.AppendLine("--------------------------------");
                }

                conexion.Close();
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(texto.ToString());

            
            Console.ReadKey();

        }
    }
}
