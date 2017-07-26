using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public class ClaseUno
    {
        public ClaseUno() {
            try
            {
                ClaseUno.metodoEstatico();
            }
            catch (Exception e)
            {
                throw new Exception("Excepcion desde constructor de ClaseUno", e);
            }
        }

        public ClaseUno(string s) { 
            
        }
        
        public static void metodoEstatico(){
            try
            {
                ClaseUno dos = new ClaseUno("sarasa");
                dos.metodoInstancia();
            }
            catch (Exception e)
            {
                throw new Exception("Excepcion desde metodoEstatico de ClaseUno", e);
            }

        }


        public void metodoInstancia() {
            try
            {
                ClaseDos dos = new ClaseDos();
            }
            catch (Exception e)
            {
                throw new Exception("Excepcion desde metodoInstancia de ClaseUno", e);
            }
        }


    }
}
