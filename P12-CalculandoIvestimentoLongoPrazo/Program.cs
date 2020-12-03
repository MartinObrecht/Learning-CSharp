using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculandoIvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double taxa = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {           
                    valorInvestido *= taxa;
                    
                }

                taxa += 0.0010;               
            }

            Console.WriteLine("Ao final do período de 5 anos você terá R$ " + valorInvestido + ".");
            Console.ReadLine();
        }
    }
}
