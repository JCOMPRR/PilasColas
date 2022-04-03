using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private string(string) lista;
        public Colas()
        {
            lista = new(string)();

        }

        public void Agregar(string dato)

        {
            lista.Add(dato);
        }
    }
}
