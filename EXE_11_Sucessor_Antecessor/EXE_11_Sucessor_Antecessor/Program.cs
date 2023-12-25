using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_11_Sucessor_Antecessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, soma, adicao, sub;

            Console.WriteLine("Insira o número");
            num1= int.Parse(Console.ReadLine());

            soma = num1 + 1;
            sub = num1 - 1;
            adicao = soma + sub;

            Console.WriteLine("O sucessor do número é: " + soma);
            Console.WriteLine("O sucessor so número é: " + sub);
            Console.WriteLine("O valor da soma do antecessor com o sucessor é: " + adicao);

            Console.ReadKey();

        }
    }
}
