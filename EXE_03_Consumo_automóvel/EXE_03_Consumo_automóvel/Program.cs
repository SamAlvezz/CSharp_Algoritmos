using System;

namespace EXE_03_Consumo_automóvel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo usuário, digite a distância que você percorreu com seu carro:");
            double dist = double.Parse(Console.ReadLine());

            Console.WriteLine("Usuário, digite a quantidade de litros gastos:");
            double litros = double.Parse(Console.ReadLine());

            double consumoMedio = dist / litros;

            Console.WriteLine($"A distância foi de: {dist} km");
            Console.WriteLine($"Os litros gastos foram de: {litros} {(litros <= 1 ? "litro" : "litros")}");
            Console.WriteLine($"O consumo médio foi de: {consumoMedio} litro{(litros <= 1 ? "" : "s")} por distância percorrida");

            Console.ReadKey();
        }
    }
}
