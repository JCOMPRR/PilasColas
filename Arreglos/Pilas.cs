using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pilas
    {
        //Variables que se usaran todo el tiempo en el constructor
        private string[] array;
        private int max;
        private int tope;

        //int tamanio especifica el tamano del array
        public Pilas(int tamanio)
        {
            array = new string[tamanio];
            max = array.Length - 1;
            tope = 0;
        }
        private bool ValidaVacio() 
        {
            //if (tope < 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return (tope < 1);
        }

        private bool ValidaLleno()
        {
            return (tope > max);
        }

        public void Agregar(string Dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo lleno");
            }

            array[tope] = Dato;
            tope++;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo vacio");
            }

            tope--;
            array[tope] = null;
        }

        //string.Empty o "" para que no muestre nada
        public string Imprimir()
        {
            string datos = "";
            if (ValidaVacio())
            {
                return "Arreglo vacio";
            }

            for (int i = 0; i < tope; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }
    }
}
