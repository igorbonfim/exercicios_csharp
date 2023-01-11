/*

    Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
    uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
    que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
    para ser responsável pelos cálculos. 
 
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class Exercicio4
    {
        public void ConversaoDolarReal()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double totalDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);           

            double valorPago = ConversorDeMoeda.CalculaTotalDolar(cotacaoDolar, totalDolares);
            Console.Write("Valor a ser pago em reais: " +valorPago.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
