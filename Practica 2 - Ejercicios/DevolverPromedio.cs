using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public static class Enteros
    {
        public static decimal devolverPromedio(this List<int> ListaEnteros) //4
        {
            int suma = 0;

            foreach (var item in ListaEnteros)
                suma += item;

            decimal promedo = suma + ListaEnteros.Count();
            return promedo;
        }

        public static int DevolverSumaparesPorRestaImpares(List<int> ListaEnteros) //5
        {
            int SumaPares = 0;
            int RestaImpares = 0;
            int ResultadoFinal = 0;

            foreach (var item in ListaEnteros)
            {
                if (item % 2 == 0)
                    SumaPares += item;
                else
                    RestaImpares -= item;
            }
            return RestaImpares = SumaPares * RestaImpares;
        }
    }
}
