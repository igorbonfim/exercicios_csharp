/*
  Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro. Cada instrutor do portal 
  pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser. Assim, o número total de alunos de 
  um instrutor não é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haveralunos repetidos em mais de um curso.

  O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.Seu programa deve ler os alunos 
  dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele, conforme exemplo.
*/

namespace ExerciciosCursoUdemy._12.Generics;
class ExercicioConjuntos
{
    public void ResolucaoConjuntos()
    {
        HashSet<int> set = new HashSet<int>();

        char[] course;
        course = new char[3] { 'A', 'B', 'C' };

        foreach(char s in course)
        {
            Console.Write($"How many students for course {s}? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                set.Add(code);
            }
        }
        Console.WriteLine("Total students: " +set.Count);
    }
}
