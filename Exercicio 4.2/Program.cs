using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma, c;
            soma = 0;
            int i = 3;

            while(i < 100)
            {
                c = i * 2;
                Console.WriteLine(c);
                soma = soma + c;

                i += 10;
            }

            Console.WriteLine("\n" + soma);
            Console.ReadKey();
        }
    }
}
