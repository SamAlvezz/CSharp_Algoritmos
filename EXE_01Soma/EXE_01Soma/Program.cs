using System;


namespace EXE_01Soma
{
        internal class Program
        {
            static void Main(string[] args)
            {

                int num1, num2, soma;
                string nome;

                Console.WriteLine("Bem vindo usuário!!, diga seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Agora digite um número:");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Agora digite um segundo número:");
                num2 = int.Parse(Console.ReadLine());

                soma = num2 + num1;

                Console.WriteLine("Seu nome é: " + nome);
                Console.WriteLine("O resultado da soma de seus números é: " + soma);

                Console.ReadKey();
            }
        }
    }
