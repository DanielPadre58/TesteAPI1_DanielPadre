using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, c;
            soma = 0;
            int i = 3;

            do
            {
                c = i * 2;
                Console.WriteLine(c);
                soma = soma + c;

                i += 10;

            } while (i < 100);

            Console.WriteLine("\n" + soma);
            Console.ReadKey();
        }
    }
}
