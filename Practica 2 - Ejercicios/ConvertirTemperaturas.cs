using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public static class ConvertirTemperaturas //11
    {
        public static double ConvertirTemperaturaAFahrenheit(this double TempCelcius)
        {
            return TempCelcius *= 2.12;
        }
        public static double ConvertirTemperaturaACelcius(this double TempFahrenheit)
        {
            return TempFahrenheit /= 2.12;
        }
    }
}
