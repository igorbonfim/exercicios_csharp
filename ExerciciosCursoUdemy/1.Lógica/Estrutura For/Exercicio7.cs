/*
    Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
    começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
    exemplo. 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio7
    {
        public void NumeroPositivo()
        {
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i+ " " +Math.Pow(i, 2)+ " " +Math.Pow(i, 3));                
            }
        }
    }
}
