using System;

namespace Exercicio03.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");

            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");

            string strIdade = Console.ReadLine();

            int idade = Convert.ToInt32(strIdade);

            int resultado_operacao = 0, ano = 365;

            resultado_operacao = idade * ano;

            Console.WriteLine();

            Console.WriteLine(nome + ", você está viva a " + resultado_operacao + " dias");

            Console.ReadLine();
        }
    }
}
