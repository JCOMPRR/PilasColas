using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Colas
    {
        private string[] array;
        private int max;
        private int principio;
        private int final;

        public Colas(int tamanio)
        {
            array = new string[tamanio];
            max = array.Length - 1;
            principio = 0;
            final = 0;
        }
    }
}
