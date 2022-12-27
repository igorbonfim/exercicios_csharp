/*
    Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
    Lembrando que, por definição, fatorial de 0 é 1. 
*/
namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio5
    {
        public void Fatorial()
        {
            int valor = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 0; i < valor; i++)
            {  
                fatorial = fatorial * (valor - i);                                
            }

            Console.WriteLine(fatorial);
        }
    }
}
