using System;
using System.Globalization;

namespace EXE_08_Conversão_dolar_a_real
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, mult;

            Console.WriteLine("Usuário, insira o valor em Dólar disponível");
            dolar = double.Parse(Console.ReadLine());

            mult = dolar * 5.36;
            real = mult;

            Console.WriteLine("O valor no dia 22/11/22, está equivalendo R$5,36");
            Console.WriteLine("A quantidade de dólares disponível é: " + dolar.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
            Console.WriteLine("O valor convertido para o Real é: " + real.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))); //ou CurrentCulture

            Console.ReadKey();
        }
    }
}
