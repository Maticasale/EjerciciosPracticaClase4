using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Palabra palabra = new Palabra();
            palabra.IngresarOracion("Hello World");
            Console.WriteLine(palabra.OracionIngresada);
            Console.WriteLine(palabra.IngresarOracion());
            Console.ReadKey();
        }
    }
}
