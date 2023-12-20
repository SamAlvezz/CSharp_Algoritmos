using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_07_Conversão_de_Celsius_a_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, mult, soma, div;

            Console.WriteLine("Usuário, insira a temperatura em C° ");
            c = double.Parse(Console.ReadLine());

            mult = 9 * c;
            soma = mult + 160;
            div = soma / 5;
            f = div;

            Console.WriteLine($"A temperatura em Celsius convertida em Fahrenheit é: {f} { "F°"}");

            Console.ReadKey();
        }
    }
}
