using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades2;
using Entidades3;


namespace Entidades1
{
    public class Comercio
    {
        private string _duenio;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;


        public Comercio(string duenio)
        {
            this._duenio = duenio;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();

        }

        public static void MostrarArticulos(Comercio ComercioAMostrar)
        {
            Console.WriteLine("Lista de articulos del comercio..");

            foreach (Articulo item in ComercioAMostrar._misArticulos)
	        {
                Console.WriteLine(item.NombreYCodigo);
	        }
           
        }

        public static void MostrarGanancia (Comercio comercioParaResumen)
        {
            float total = 0;

            foreach (Venta item in comercioParaResumen._misVentas)
            {
                total += item.RetornarGanancia();
            }

            Console.WriteLine("Total de ganancia del comercio de " + comercioParaResumen._duenio + ": " + total.ToString());
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {
            bool flagExiste = false; 
            foreach (Articulo item in this._misArticulos)
	        {
                if (item == articuloComprado)
                {
                    item.Stock = item + articuloComprado; 
                    flagExiste = true;
                    break;
                }
	        }
            if (flagExiste == false)
            {
                this._misArticulos.Add(articuloComprado);
            }
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            bool flagExiste = false;
            foreach (Articulo item in this._misArticulos)
            {
                if (item == articuloSolicitado )
                {
                    if (item.HayStock(cantidad))
                    {
                        item.Stock = item - cantidad;
                        this._misVentas.Add(new Venta(articuloSolicitado, cantidad));
                    }
                    else 
                    {
                        Console.WriteLine("El siguiente articulo no tiene stock para la venta ");
                        Console.WriteLine(articuloSolicitado.NombreYCodigo.ToString());
                    }
                        
                    flagExiste = true;
                    break;
                }
            }
            if (flagExiste == false)
            {
                Console.WriteLine("El siguiente articulo no existe en nuestro comercio ");
            }
        }

    }
}
