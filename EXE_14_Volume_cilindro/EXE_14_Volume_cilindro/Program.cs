using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_14_Volume_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, mult, mult2;

            Console.WriteLine("Insira o raio do cilindro");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro");
            altura = double.Parse(Console.ReadLine());

            mult = raio * raio;
            mult2 = 3.14 * mult * altura;

            Console.WriteLine("O volume do cilindro é " + mult2);

            Console.ReadKey();
        }
    }
}
