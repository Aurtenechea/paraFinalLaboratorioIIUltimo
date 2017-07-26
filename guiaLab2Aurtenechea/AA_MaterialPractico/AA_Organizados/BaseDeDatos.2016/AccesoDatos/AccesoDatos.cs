using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class AccesoDatos
    {
        #region Atributos
        private SqlConnection _conexion;
        private SqlCommand _comando;
        #endregion

        #region Constructores
        public AccesoDatos() 
        {
            // CREO UN OBJETO SQLCONECTION
            this._conexion = new SqlConnection(Properties.Settings.Default.conexionEjercicio);
            /*Properties.Settings.Default.conexionEjercicio se define en propiedades del proyecto. 
             * Boton derecho propiedades sobre el proyecto. 
             * ahi crear un tipo string connection y conectar con la base de datos.
             * el nombre que se le de es el que hay que usar aca como parametro.
             * no es mas que la ruta con el nombre de la base de datos.
             */
            // CREO UN OBJETO SQLCOMMAND
            this._comando = new SqlCommand();
            /* almacena los 4 comandos select, update, delete, etc.
             */
            // INDICO EL TIPO DE COMANDO
            this._comando.CommandType = System.Data.CommandType.Text;
            /* el tipo de comando... siempre va a ser texto.
             */
            // ESTABLEZCO LA CONEXION
            this._comando.Connection = this._conexion;
            /* el comando usa la conexio previamente hecha.
             */
        }
        #endregion

        #region Métodos
        public List<Persona> ObtenerListaPersonas()
        {
            bool TodoOk = false;
            List<Persona> lista = new List<Persona>();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                _comando.CommandText = "SELECT * FROM Personas ORDER BY apellido, nombre";

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();
                /* abre la conexion con la base de datos.*/

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = _comando.ExecuteReader();
                /* _comando.ExecuteReader() de vuelve SqlDataReader. (hay varios tipos por eso es un sqlDataReader)
                 * los reader son punteros que apuntan a un elemento y solo pueden leerlos y se pueden mover solo para adelante. 
                 */
                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    lista.Add(new Persona(int.Parse(oDr[0].ToString()),oDr["apellido"].ToString(), oDr["nombre"].ToString(), int.Parse(oDr[3].ToString())));                    
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    this._conexion.Close();
                    /* cierra la conexion con la base de datos.*/
            }
            return lista;
        }

        public DataTable ObtenerTablaPersonas()
        {
            bool TodoOk = false;
            DataTable tabla = new DataTable("Personas");
            /* tiene que ser el mismo nombre que el de la DDBB */
            
            try
            {
                // INDICO EL TIPO DE COMANDO
                this._comando.CommandType = System.Data.CommandType.Text;
                // _comando es de tipo SqlCommand


                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = "SELECT * FROM Personas ORDER BY apellido DESC, nombre";
                

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this._comando.ExecuteReader();

                // CARGO LA TABLA CON REGISTROS...
                tabla.Load(oDr);

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    this._conexion.Close();
            }
            return tabla;
        }

        public bool InsertarPersona(Persona p)
        {
            bool todoOk = false;

            string sql = "INSERT INTO Personas (nombre, apellido, edad) VALUES(";
            sql = sql + "'" + p.Nombre + "','" + p.Apellido + "'," + p.Edad.ToString() + ")";
            // sql contiene la consulta nada mas


            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND
                this._comando.ExecuteNonQuery();
                /* que no devuelva nada. */


                todoOk = true;

            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    this._conexion.Close();               
            }
            return todoOk;
 
        }

        public Persona ObtenerPersonaPorApellido(string apellido)
        {
            bool TodoOk = false;
            Persona p = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = "SELECT * FROM Personas WHERE apellido = '" + apellido + "'";
                // ESTABLESCO LA CONEXION
                this._comando.Connection = this._conexion;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this._comando.ExecuteReader();

                // SI HAY REGISTROS...               
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    p = new Persona(int.Parse(oDr["id"].ToString()), oDr["apellido"].ToString(),
                        oDr["nombre"].ToString(), int.Parse(oDr["edad"].ToString()));
                }
                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception)
            {
                TodoOk = false;
            }
            finally
            {

                if (TodoOk)
                    this._conexion.Close();

            }

            return p;
        }

        public bool ModificarPersona(Persona p)
        {
            bool todoOk = false;
            string sql = "UPDATE Personas SET nombre = '" + p.Nombre + "', apellido = '";
            sql = sql + p.Apellido + "', edad = " + p.Edad.ToString() + " WHERE id = " + p.ID.ToString();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND
                this._comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    this._conexion.Close();
            }
            return todoOk;
        }

        public bool EliminarPersona(Persona p)
        {
            bool todoOk = false;

            string sql = "DELETE FROM Personas WHERE id = " + p.ID.ToString();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                this._comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                this._conexion.Open();

                // EJECUTO EL COMMAND
                this._comando.ExecuteNonQuery();

                todoOk = true;

            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    this._conexion.Close();
            }
            return todoOk;
        }
        #endregion
    }
}
