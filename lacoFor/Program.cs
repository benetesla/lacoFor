using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros inteiros voce ira digitar:");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Valor : #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine("soma =" + soma);
        }
    }
}