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
        //Por que me sale error?
        public void Agregar(string dato)

        {
            lista.Add (dato);
        }

        private bool ValidaVacio()
        {
            return lista.Count == 0;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Lista Vacia");
            }
            lista.RemoveAt(0);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "lista vacia";
            }

            int listCount = lista.Count;
            for (int i = 0; i < listCount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {lista[i]}";
            }
            return datos;
        }
    }
}
