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
    }
}
