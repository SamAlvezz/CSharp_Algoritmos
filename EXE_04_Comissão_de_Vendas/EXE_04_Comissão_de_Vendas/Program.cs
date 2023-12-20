using System;

namespace EXE_04_Comissão_de_Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double sal, lucro, mult, soma;

            Console.WriteLine("Você é um vendedor e ganha 15% de comissão por venda ");
            Console.WriteLine("Vendedor, digite seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Agora digite seu salário fixo:");
            sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total do valor das suas vendas feitas no mês:");
            lucro = double.Parse(Console.ReadLine());

            mult = lucro * 0.15;
            soma = mult + sal;

            Console.WriteLine("O nome do usuário é: " + nome);
            Console.WriteLine("O salário fixo é: " + sal);
            Console.WriteLine("O salário no final do mês é: " + soma);

            Console.ReadKey();
        }
    }
}
