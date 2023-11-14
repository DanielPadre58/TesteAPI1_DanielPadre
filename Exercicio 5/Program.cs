using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int expoente;
            bool invalido;

            do
            {
                Console.Clear();
                invalido = false;

                Console.Write("Insira o número que será usado como expoente, este número deve pertencer ao intervalo de 1 a 5: ");
                expoente = int.Parse(Console.ReadLine());

                if (expoente > 5 || expoente < 1)
                {
                    Console.WriteLine("Valor inválido. Prima qualquer tecla para continuar");
                    invalido = true;
                    Console.ReadKey();
                }

            }while (invalido);

            Console.Clear();
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n" + "A potência de " + i + " elevado a " + expoente + " é " + Math.Pow(i, expoente));
            }

            Console.ReadKey();
        }
    }
}
