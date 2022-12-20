/*
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    casas decimais conforme exemplos.

    Fórmula da área: area = π . raio2
    Considere o valor de π = 3.14159
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Sequencial
{
    public class Exercicio2
    {
        public void CalculaAreaCirculo()
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double areaCirculo = pi * Math.Pow(raio, 2);

            Console.WriteLine("ÁREA = " +areaCirculo.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
