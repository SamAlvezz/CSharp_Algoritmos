using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_06_Troca_de_Valores
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;

            Console.WriteLine("Usuário, insira um valor para: a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um valor para: b");
            b = int.Parse(Console.ReadLine());

            //C e D são usadas temporariamente
            c = a;
            d = b;
            a = d;
            b = c;

            Console.WriteLine("Agora a variável 'a' vale: " + a);
            Console.WriteLine("Agora a variável 'b' vale: " + b);

            Console.ReadKey();

        }
    }
}
