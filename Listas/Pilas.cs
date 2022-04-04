using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> list;
        public Pilas()
        {
            list = new List<string>();
        }

        public void Agregar(string dato)
        {
            list.Add(dato);
        }

        private bool ValidaVacio()
        {
            return list.Count == 0;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Lista Vacia"):
            }

            Listas.RemoveAt(Listas.Count - 1);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "Lista vacia";
            }

            
        }
    }
    
}
