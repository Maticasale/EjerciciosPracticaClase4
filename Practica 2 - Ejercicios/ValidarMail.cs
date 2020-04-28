using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practica_2___Ejercicios
{
    public static class ValidarMail
    {
        public static bool ValidarEmail(this string mail) //9
        {
            Regex rx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return rx.IsMatch(mail);
        }
    }
}
