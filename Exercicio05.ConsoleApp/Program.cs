using System;

namespace Exercicio05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o sálario: ");

            string strSalario = Console.ReadLine();

            double salario = Convert.ToInt32(strSalario);

            double resultado_aumento = 0, resultado_imposto = 0;

            resultado_aumento = ((salario / 100) * 15) + salario;

            resultado_imposto = resultado_aumento - (resultado_aumento * 8 / 100);

            Console.WriteLine();

            Console.WriteLine("Salário: R$" + Math.Round(salario, 2));

            Console.WriteLine("Salário com aumento: R$" + Math.Round(resultado_aumento, 2));

            Console.WriteLine("Salário com imposto: R$" + Math.Round(resultado_imposto), 2);

            Console.ReadLine();
        }
    }
}
