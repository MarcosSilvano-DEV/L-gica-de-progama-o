using System;

namespace Lógica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA DE DADOS
            Console.WriteLine("Soma dos dois números");
            Console.WriteLine("---------------------");
            Console.Write("Digite o primeiro valor: ");
            int valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            int valorDois = int.Parse(Console.ReadLine());

            //PROCESSAMENTO
            int soma = valorUm + valorDois;

            //EXIBIR
            Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);
        }
    }
}
