using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public static class FechaString
    {
        public static DateTime DevolverFechaEnFormato(this string Fecha) //6
        {
            DateTime FechaConvertida;
            try
            {
                FechaConvertida = Convert.ToDateTime();
            }
            catch (Exception)
            {
                FechaConvertida = DateTime.MinValue;
            }
            return FechaConvertida;
        }
    }
}
