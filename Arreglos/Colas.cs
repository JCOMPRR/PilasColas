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

        private bool ValidaVacio()
        {
            return ((principio < 1 && final < 1)
                || principio== final);
        }

        private bool ValidaLleno()
        {
            return ((final > max));
        }

        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo lleno");
            }

            array[final] = dato;
            final++;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }

            array[principio] = null;
            principio++;
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "Arreglo vacio";
            }

            for (int i = principio; i < final; i++)
            {
                if (i > principio)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {array[i]}";
            }
                return datos;
            
        }
    }
}
