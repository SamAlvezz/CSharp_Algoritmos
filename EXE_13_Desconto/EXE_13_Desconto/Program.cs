using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_13_Desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, sub, div, mult;

            Console.WriteLine("Insira o valor do produto");
            valor = double.Parse(Console.ReadLine());

            mult = 10 * valor;
            div = mult / 100;
            sub = valor - div;

            Console.WriteLine("O valor do produto é:R$ " + valor);
            Console.WriteLine("Com o desconto de 10%, o valor será de R$ " + sub);
            Console.WriteLine("O produto está com um desconto de R$" + div);

            Console.ReadKey();
        }
    }
}
