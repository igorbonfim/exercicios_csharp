/* Classe utilizada no Exercício 3 */

using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class Aluno
    {
        public string NomeAluno;        
        public float Nota1;
        public float Nota2;
        public float Nota3;
        public double NotaFinal;

        public void AvaliacaoFinal()
        {
            NotaFinal = Nota1 + Nota2 + Nota3;           

            Console.WriteLine("NOTA FINAL: " + NotaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if (NotaFinal >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                double diferenca = 60 - NotaFinal;
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + diferenca.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }            
        }           
    }
}
