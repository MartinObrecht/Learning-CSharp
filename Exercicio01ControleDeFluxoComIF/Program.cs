using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01ControleDeFluxoComIF
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 5000.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                double taxa = salario * 0.075;
                
                Console.WriteLine("A taxa de IR para sua faixa salarial é de 7,5% e pode" +
                    " deduzir até R$ 350. O valor da taxa é de R$ " + taxa);

            }
            if (salario >= 2800.01 && salario <= 3751.0)
            {
                double taxa = salario * 0.15;

                Console.WriteLine("A taxa de IR para sua faixa salarial é de 15% e pode deduzir até R$ 350. O valor" +
                    " da taxa é de R$ " + taxa);
            }
            if (salario >= 3751.01)
            {
                double taxa = salario * 0.225;
                
                Console.WriteLine("A taxa de IR para sua faixa salarial é de 22,5% e pode deduzir até R$ 650. O valor" +
                    " da taxa é de R$ " + taxa);
            }

            Console.ReadLine();
        }
    }
}
