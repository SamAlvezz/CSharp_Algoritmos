using System;


namespace EXE_CSharp_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, soma, subtração, multiplicação, divisão;

            Console.WriteLine("Bem vindo usuário!! digite o primeiro número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo número");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;
            subtração = num1 - num2;
            multiplicação = num1 * num2;
            divisão = num1 / num2;

            Console.WriteLine("O resultado da soma é: " + soma);
            Console.WriteLine("O resultado da subtração é: " + subtração);
            Console.WriteLine("O resultado da multiplicação é: " + multiplicação);
            Console.WriteLine("O resultado da divisão é: " + divisão);

            Console.ReadKey();
        }
    }
}
