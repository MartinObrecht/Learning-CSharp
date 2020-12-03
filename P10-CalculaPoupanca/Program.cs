using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Popupança");

            double valoreIvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                //0.0036 é o valor de rendimento da poupança
                valoreIvestido += valoreIvestido * 0.0036;
                contadorMes++;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valoreIvestido + " reais.");
            }                     

            Console.ReadLine();

        }
    }
}
