﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {                    
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
