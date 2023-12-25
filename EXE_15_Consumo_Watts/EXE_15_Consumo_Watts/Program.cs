using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_15_Consumo_Watts
{
    class Program
    {
        static void Main(string[] args)
        {
            double pot, tempo, preco, mult, div, mult2;

            Console.WriteLine("Insira a potência do dispositivo");
            pot = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o tempo de uso");
            tempo = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço por hora");
            preco = double.Parse(Console.ReadLine());

            div = pot / 1000;
            mult = div * tempo;

            Console.WriteLine("Foi consumido em Watts exatamente " + mult);

            mult2 = tempo * preco;

            Console.WriteLine("O preço gasto em reais foi de R$ " + mult2);

            Console.ReadKey();
        }
    }
}
