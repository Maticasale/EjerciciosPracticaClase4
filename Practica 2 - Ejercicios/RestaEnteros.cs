using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public static class RestaEnteros //12
    {
        public static int RestarEnteros(this int E1, int E2)
        {
            return E1 - E2;
        }
    }

    public static class SobreescribirOperador
    {
        public static decimal Sobreescribir(this int E1, int E2)
        {
            return Convert.ToDecimal(E1 / E2);
        } 
    }


}
