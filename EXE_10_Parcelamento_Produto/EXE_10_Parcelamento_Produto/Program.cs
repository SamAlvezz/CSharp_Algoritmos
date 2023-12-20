using System;
using System.Globalization;

namespace EXE_10_Parcelamento_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            double prest, vprest, valor;

            Console.WriteLine("Digite o valor do produto:");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite em quantas parcelas vai ser:");
            prest = double.Parse(Console.ReadLine());

            vprest = valor / prest;

            Console.WriteLine("O valor das prestações será de: " + vprest.ToString("C2", CultureInfo.GetCultureInfo("pt-BR")));

            Console.ReadKey();


        }
    }
}
