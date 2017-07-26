using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        public List<Llamada> _listaDeLlamadas;
        public string _razonSocial;
        // faltan las propiedades.
        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia((TipoLlamada)2);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia((TipoLlamada)1);
            }
        }
        public float GananciaPorLocal
        {
            get
            {
                return this.CalcularGanancia((TipoLlamada)0);
            }
        }



        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa): this()
        {
            this._razonSocial = nombreEmpresa;
        }
        
        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre de la empresa: " + this._razonSocial+ ".");
            sb.AppendLine("");
        
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float r = 0;
            Provincial prov;
            Local loc;

            switch ((int)tipo)
            {
                case 0:
                    foreach (var item in _listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            loc = (Local)item;
                            r += loc.CostoLlamada;
                        }
                    }
                        break;
                case 1:
                    foreach (var item in _listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            prov = (Provincial)item;
                            r += prov.CostoLlamada;
                        }
                    }
                        break;
                case 2:
                    foreach (var item in _listaDeLlamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            prov = (Provincial)item;
                            r += prov.CostoLlamada;
                        }
                        else if (item.GetType() == typeof(Local))
                        {
                            loc = (Local)item;
                            r += loc.CostoLlamada;
                        }
                    }
                        break;
            }
            return r;
        }


    }
}
