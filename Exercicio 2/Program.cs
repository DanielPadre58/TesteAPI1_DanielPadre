using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            string textNum = num.ToString();

            for(int i = 0; i < textNum.Length; i++)
            {
                sum += int.Parse(textNum[i].ToString());
            }

            if (sum == 0 || num%sum == 0)
            {
                Console.WriteLine("O número insirido é um número de Harshad.");
            }
            else
            {
                Console.WriteLine("O número insirido não é um número de Harshad");
            }
           
            Console.ReadKey();
        }
    }
}
