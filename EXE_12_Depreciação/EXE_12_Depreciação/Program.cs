using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_12_Depreciação
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double valor, depre;

                Console.WriteLine("Insira o valor do produto");
                valor = double.Parse(Console.ReadLine());

                depre = valor * 0.18;

                Console.WriteLine("Com 18% de depreciação, o valor daqui um ano será de " + depre);

                Console.ReadKey();
            }
        }
    }
}