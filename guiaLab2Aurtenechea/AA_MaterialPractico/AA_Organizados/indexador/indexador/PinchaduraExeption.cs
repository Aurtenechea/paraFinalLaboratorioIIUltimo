using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class PinchaduraExeption : MiExeption
    {
        public string marca;
        public PinchaduraExeption (string text, DateTime hora, string marca)
            : base(text, hora)
        {
            this.marca = marca;
        }

    }
}
