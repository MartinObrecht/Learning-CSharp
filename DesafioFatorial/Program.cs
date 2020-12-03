using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFatorial
{
    class Program
    {
        static void Main(string[] args)
        {           
            for (int n = 1; n <= 10; n++)
            {
                int resultado = 1;
                for (int fatorial = 1; fatorial <= n; fatorial++)
                {
                    resultado = resultado * fatorial;                                       
                }
                 
                Console.WriteLine("O fatorial de " + n + " é: " + resultado);
            }
            Console.ReadLine();
        }
    }
}
