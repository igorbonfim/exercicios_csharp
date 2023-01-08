/*

EXERCÍCIO 03:
Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema. 

*/

using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class Exercicio3
    {
        public void CalculaMedia()
        {
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.AvaliacaoFinal();                    
        }
    }
}
