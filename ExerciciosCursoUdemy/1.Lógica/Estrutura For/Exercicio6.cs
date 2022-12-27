/*
    Ler um número inteiro N e calcular todos os seus divisores. 
*/
namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio6
    {
        public void Divisores()
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
