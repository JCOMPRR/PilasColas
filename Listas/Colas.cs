using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private List <string> lista;
        public Colas()
        {
            lista = new List<string>();

        }

        public void Agregar(string dato)

        {
            lista.Add(dato);
        }

        private bool ValidaVacio()
        {
            return (lista.Count == 0);
        }

        public void
    }
}
