using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades1;
using Entidades3;


namespace Entidades2
{
    public class Venta
    {
        private Articulo _articuloVendido;
        private int _cantidad;

        public Venta(Articulo articuloVentido, int cantidad)
        {
            this._cantidad = cantidad;
            this._articuloVendido = articuloVentido;
        }

        public float RetornarGanancia()
        {
            return this._articuloVendido.PrecioVenta * _cantidad;
        }
    }
}
