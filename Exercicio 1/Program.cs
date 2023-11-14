using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Insira o preço do imóvel: ");
            double precoImovel = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Insira o número de meses a pagar: ");
            int meses = int.Parse(Console.ReadLine());

            float taxaProcesso = 0.02f;
            float taxaJuros;

            if(idade <= 25)
            {
                taxaJuros = 0.20f;
            }
            else if(idade <= 30)
            {
                taxaJuros = 0.30f;
            }
            else
            {
                taxaJuros = 0.35f;
            }

            double sum = (precoImovel + (precoImovel * taxaJuros)) + (precoImovel * taxaProcesso);
            
            double valorPorMes = Math.Round(sum / meses);

            Console.WriteLine(valorPorMes + " euros por mês");
            Console.ReadKey();
        }
    }
}
