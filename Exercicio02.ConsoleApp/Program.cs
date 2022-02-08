using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de pães franceses vendidos: ");

            string strPao_frances = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de broas vendidas: ");

            string strBroa = Console.ReadLine();

            double pao_frances = Convert.ToInt32(strPao_frances);

            double broa = Convert.ToInt32(strBroa);

            double operacao_pao = 0, operacao_broa = 0, resultado_operacao = 0, resultado_polpanca = 0;

            operacao_pao = pao_frances * 0.12;

            operacao_broa = broa * 1.50;

            resultado_operacao = operacao_pao + operacao_broa;

            resultado_polpanca = (resultado_operacao / 100) * 10;

            Console.WriteLine("Arrecadação total de pães franceses: R$" + Math.Round (operacao_pao, 2));

            Console.WriteLine("Arrecadação total de broas: R$" + Math.Round (operacao_broa, 2));

            Console.WriteLine("Arrecadação total de pães franceses e broas: R$" + Math.Round(resultado_operacao, 2));

            Console.WriteLine("Arrecadação para polpança: R$" + Math.Round(resultado_polpanca, 2));

            Console.ReadLine();
        }
    }
}
