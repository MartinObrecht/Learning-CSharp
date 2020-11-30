using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //aspas simples para o tipod de dado char - 16bits de tamanho
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia";
            string cursosProgramacao = 
@"- .NET
- Java
- Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadLine();

        }
    }
}
