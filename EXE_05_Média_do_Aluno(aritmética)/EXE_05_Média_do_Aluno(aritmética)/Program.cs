using System;


namespace EXE_05_Média_do_Aluno_aritmética_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, n3, soma, div;

            Console.WriteLine("Usúario, digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.WriteLine("Agora digite a primeira nota:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            soma = n1 + n2 + n3;
            div = soma / 3;

            Console.WriteLine($"O nome do aluno é: {nome}"); //interpolado
            Console.WriteLine("A média final do aluno é: " + div.ToString("F1"));

            Console.ReadKey();
        }
    }
}
