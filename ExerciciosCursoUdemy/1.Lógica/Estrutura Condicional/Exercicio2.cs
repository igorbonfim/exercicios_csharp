/*
    Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar. 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Condicional
{
    public class Exercicio2
    {
        public void ParOuImpar()
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}
