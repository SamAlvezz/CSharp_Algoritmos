using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_09_Rendimento_Poupança
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep, mult, rend;

            Console.WriteLine("Usuário, insira o valor depositado");
            dep = double.Parse(Console.ReadLine());

            mult = dep * 0.007;
            rend = mult;

            Console.WriteLine($"O rendimento foi de: {rend} no mês");

            Console.ReadKey();
        }
    }
}
