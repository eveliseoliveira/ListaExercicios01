using System;

namespace Exercicio04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em graus Celcius: ");

            string strTemperatura_celcius = Console.ReadLine();

            double temperatura_celcius = Convert.ToInt32(strTemperatura_celcius);

            double resultado_operacao = 0;

            resultado_operacao = (temperatura_celcius * 9 / 5) + 32;

            Console.WriteLine("Temperatura em Fahrenheit: " + resultado_operacao + "°F");

            Console.ReadLine();
        }
    }
}
