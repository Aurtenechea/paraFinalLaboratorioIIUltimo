using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrituraEnArchivo
{
    public static class  Guardador
    {
        public static bool GuardarPersona(Persona p)
        {
            bool b = true;
            StreamWriter escritor = null;
            try
            {
                escritor = new StreamWriter("persona.txt", true);
                escritor.WriteLine(p.ToString());
            }
            catch (Exception)
            {
                b = false;
            }
            finally 
            {
                escritor.Close();
            }
            return b;
        }

        public static Persona LeerUnaPersona() 
        {
            Persona p = null;
            StreamReader lector = null;
            string[] a = null;
            bool b = true;
            try 
	        {
                lector = new StreamReader("persona.txt");
                string s = lector.ReadLine();
                a = s.Split(',');
	        }
	        catch (Exception)
	        {
		        b = false;
	        }
            if (a != null)
                return new Persona(a[0], a[1]);
            else
                return null;
        }

        public static List<Persona> RetornarListado()
        {
            List<Persona> lsPersonas = new List<Persona>();
            try
            {
                using (StreamReader lector = new StreamReader("persona.txt"))
                {
                    string renglon;
                    string[] a = null;
                    while ((renglon = lector.ReadLine()) != null)
                    {
                        a = renglon.Split(',');
                        lsPersonas.Add(new Persona(a[0], a[1]));
                    }
                }
            }
            catch (Exception)
            {


            }
            return lsPersonas;

        }
    }
}
