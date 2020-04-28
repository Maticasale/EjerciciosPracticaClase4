using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public static class CalcularDiferenciaDeFechas
    {
        public static decimal CalcularDiferencia(this DateTime F1, DateTime F2) //3
        {
            double DiferenciaSegundos = (F1 - F2).TotalSeconds;
            decimal minutos = Convert.ToDecimal(DiferenciaSegundos / 60);
            return minutos;
        }
    }
}
