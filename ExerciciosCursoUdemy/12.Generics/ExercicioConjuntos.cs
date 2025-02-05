namespace ExerciciosCursoUdemy._12.Generics;
class ExercicioConjuntos
{
    public void Resolucao()
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
