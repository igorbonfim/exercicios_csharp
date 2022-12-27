/*
    Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
    essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio2
    {
        public void Intervalo()
        {
            int n = int.Parse(Console.ReadLine());
            int nIn = 0, nOut = 0;

            for (int i = 1; i <= n; i++)
            {               
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <= 20)
                {
                    nIn++;
                }
                else
                {
                    nOut++;
                }
            }

            Console.WriteLine(nIn + " in");
            Console.WriteLine(nOut + " out");
        }
    }
}
