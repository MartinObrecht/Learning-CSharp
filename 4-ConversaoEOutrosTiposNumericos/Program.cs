using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 4");

            //precisão maior que o float após o ponto
            double salario;
            salario = 1200.50;
            Console.WriteLine(salario);

            //convertendo double em int - int é um tipo de variável que suporta 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //o long é uma variável de 64bits
            long numeros;
            numeros = 15000000000000000;
            Console.WriteLine(numeros);

            //o short é uma variável que de 16 bits
            short idade = 30000;
            Console.WriteLine(idade);

            //precisão curta de casas após o ponto - devemos colocar o f pq o float não é tão utilizado,
            //assim precisamos confirmar que é um float
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
            


        }
    }
}
