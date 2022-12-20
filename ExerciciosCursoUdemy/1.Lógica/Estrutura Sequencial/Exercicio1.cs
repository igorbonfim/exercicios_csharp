/*
    Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
    mensagem explicativa, conforme exemplos. 
*/

namespace ExerciciosCursoUdemy._1___Lógica.Estrutura_Sequencial
{
    public class Exercicio1
    {
        public void Soma()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;

            Console.WriteLine("SOMA = " +soma);
        }
    }
}
