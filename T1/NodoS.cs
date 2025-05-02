using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class NodoS
    {
        public Gato Dato { get; set; }
        public NodoS Sig { get; set; }

        public NodoS(Gato dato)
        {
            Dato = dato;
            Sig = null;
        }
    }
}
