/*
    Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
    segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio4
    {
        public void DivisaoPares()
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                int n1 = int.Parse(numeros[0]);
                int n2 = int.Parse(numeros[1]);

                if (n2 == 0)
                    Console.WriteLine("Divisão impossível");
                else
                {
                    float divisao = (float) n1 / n2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
