using System;

namespace Exercicio01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor referente ao comprimento: ");

            string strLado = Console.ReadLine();

            Console.WriteLine("Insira o valor referente a largura: ");

            double resultado_operacao = 0;

            string strComprimento = Console.ReadLine();

            double largura = Convert.ToInt32(strLado);

            double comprimento = Convert.ToInt32(strComprimento);

            resultado_operacao = comprimento * largura;

            Console.WriteLine("Área do terreno: " + resultado_operacao + " m²");

            Console.ReadLine();
        }
    }
}
