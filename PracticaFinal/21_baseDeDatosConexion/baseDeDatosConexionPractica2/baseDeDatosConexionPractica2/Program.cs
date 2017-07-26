using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace baseDeDatosConexionPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionDDBB);

            string sql = "select * from Personas";

            SqlCommand comando = new SqlCommand(sql, conexion);

            conexion.Open();

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                Console.WriteLine("{0} {1} {2}",lector[0].ToString(), lector[1].ToString(), lector[2].ToString());
            }

            conexion.Close();
            Console.ReadLine();
        }
    }
}
