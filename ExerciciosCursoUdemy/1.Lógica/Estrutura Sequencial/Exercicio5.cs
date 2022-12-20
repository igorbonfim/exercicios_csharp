/*
    Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
    código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Sequencial
{
    public class Exercicio5
    {
        public void Pecas()
        {
            string pecas1 = Console.ReadLine();
            string[] vetPecas1 = pecas1.Split(' ');
            int codPeca1 = int.Parse(vetPecas1[0]);
            int numPecas1 = int.Parse(vetPecas1[1]);
            double vlrUnitarioPeca1 = double.Parse(vetPecas1[2], CultureInfo.InvariantCulture);
            double totalPeca1 = numPecas1 * vlrUnitarioPeca1;

            string pecas2 = Console.ReadLine();
            string[] vetPecas2 = pecas2.Split(' ');
            int codPeca2 = int.Parse(vetPecas2[0]);
            int numPecas2 = int.Parse(vetPecas2[1]);
            double vlrUnitarioPeca2 = double.Parse(vetPecas2[2], CultureInfo.InvariantCulture);
            double totalPeca2 = numPecas2 * vlrUnitarioPeca2;

            double total = totalPeca1 + totalPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ " +total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
