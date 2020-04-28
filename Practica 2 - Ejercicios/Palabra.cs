using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public class Palabra
    {
        public string OracionIngresada { get; set; }

        public string IngresarOracion(string Oracion)
        {            
            return OracionIngresada = Oracion;
        }
    }

    public static class ContarPalabras //1
    {
        public static int IngresarOracion(this Palabra Oracion)
        {
            int cantidadPalabras = 1;
            if (Oracion.OracionIngresada == null)
                cantidadPalabras = 0;
            else
            {
                foreach (char caracter in Oracion.OracionIngresada)
                {
                    if (caracter == ' ')
                        cantidadPalabras++;                   
                }
            }        
            return cantidadPalabras; 
        }
    }

    public static class SobreescrituraMetodo1 //2
    {
        public static int IngresarOracion(this Palabra Oracion, char Separador)
        {
            int cantidadPalabras = 1;
            if (Oracion.OracionIngresada == null)
                cantidadPalabras = 0;
            else
            {
                foreach (char caracter in Oracion.OracionIngresada)
                {
                    if (caracter == Separador)
                        cantidadPalabras++;
                }
            }
            return cantidadPalabras;
        }

    }
}
