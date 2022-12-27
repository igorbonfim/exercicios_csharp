/*
    Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
    X, se for o caso. 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio1
    {
        public void NumerosImpares()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
