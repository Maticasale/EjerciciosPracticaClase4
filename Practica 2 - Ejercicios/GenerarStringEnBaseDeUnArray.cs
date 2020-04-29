using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public static class GenerarStringEnBaseDeUnArray
    {
        public static string GenerarString(this string[] ArrayPalabras, char Separador)
        {
            //Se puede usar arrayPalabras.split(separador)
            string final = "";
            foreach (var item in ArrayPalabras)
                final += Separador + item;

            return final;
        }
    }
}
