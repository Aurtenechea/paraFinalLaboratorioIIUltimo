using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exepcion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string dato;
            //int numero;

            try
            {   
                // solo lo que puede dar error (puede ir todo pero no hacerlo)
                // se ejecuta esto. Si da un error se ejecuta lo que hay en catch.
                //dato = Console.ReadLine();
                //numero = int.Parse(dato);
                //numero = numero / numero;
                Program.lanzarError(); //lo de abajo no se ejecuta..
                Program.operar();
            }
            catch (FormatException ex) // solo se ejecuta un catch.. lo elige por el primer catch que coincida con el tipo de error segun este declarado en el parametro del catch
            {
                Console.WriteLine("error de formato");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("divido por cero");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex) // ex es una variable que contiene el objeto del tipo exeption que sus metodos son virtuales para poder sobreescribirlos
            {
                // se decide por orden jerarquico.
                // los catch van de lo particular a lo general
                // cualquier eror que no entren en los anteriores entrara en este..
                Console.WriteLine("General");

                Console.WriteLine(ex.Message);


                // throw;
            }

            finally 
            {
                // esto se ejecuta siempre por mas que no haya error en el try..
            }


            

            Console.ReadKey();
        }

        public static void operar ()
        {
            try
            {
                string dato;
                int numero;
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception ex)
            {
                // operaciones para guardar la operacion 
        
                throw new Exception("Se quedo sin internet"); //lanza un objeto exeption para que lo capture un catch 
            }
            
        }

        public static void lanzarError()
        {
            throw new Exception("Se quedo sin memoria RAM");
            //el throw nunca sabe quien lo va a capturar
            //la idea es que vaya pasando por varios lugares hasta llegar al program con la info de donde fue el error
        }

    }
}
