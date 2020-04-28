using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2___Ejercicios
{
    public class Clientes_Eje10_ //10
    {
        public string Nombre { get; set; }
        public int cuit { get; set; }
        public int Saldo { get; set; }

        public static Clientes_Eje10_ OperacionesClientes(Clientes_Eje10_ C1, Clientes_Eje10_ C2)
        {
            Clientes_Eje10_ ClienteARetornar = new Clientes_Eje10_();

            if (C1.cuit == C2.cuit)
            {
                C1.Saldo = C1.Saldo - C2.Saldo;
                ClienteARetornar = C1;
            }                
            else
            {
                if (C1.Saldo < C2.Saldo)
                    ClienteARetornar = C1;
                else
                    ClienteARetornar = C2;
            }
            return ClienteARetornar;
        }
    }
}
