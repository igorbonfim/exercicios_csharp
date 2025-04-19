/*
    Fazer um programa para ler os dados (nome, email e salário)
    de funcionários a partir de um arquivo em formato .txt.
    Em seguida mostrar, em ordem alfabética, o email dos
    funcionários cujo salário seja superior a um dado valor
    fornecido pelo usuário.
    Mostrar também a soma dos salários dos funcionários cujo
    nome começa com a letra 'M'.

    obs: copiar em um arquivo de texto os seguintes dados:
    Maria,maria@gmail.com,3200.00
    Alex,alex@gmail.com,1900.00
    Marco,marco@gmail.com,1700.00
    Bob,bob@gmail.com,3500.00
    Anna,anna@gmail.com,2800.00
*/


using System.Globalization;

namespace ExerciciosCursoUdemy._13.Expressões_lambda__delegates__linq;
public class ExercicioLinq
{
    public void ResolucaoExercicioLinq()
    {
        Console.Write("Enter the full file path: ");
        string path = Console.ReadLine();

        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        List<Employee> list = new List<Employee>();

        using (StreamReader reader = File.OpenText(path))
        {
            while (!reader.EndOfStream)
            {
                string[] fields = reader.ReadLine().Split(",");
                string name = fields[0];
                string email = fields[1];
                double salary2 = double.Parse(fields[2], CultureInfo.InvariantCulture);
                list.Add(new Employee(name, email, salary2));
            }
        }        

        var emails = list.Where(e => e.Salary > 2000).Select(e => e.Email);
        Console.WriteLine("Emails of people whose salary is more than 2000.0:");
        foreach(string email in emails)
        {
            Console.WriteLine(email);
        }

        var sum = list.Where(e => e.Name.StartsWith("M")).Select(e => e.Salary).Sum();
        Console.Write("Sum of salary of people whose name starts with 'M': " +sum.ToString("F2", CultureInfo.InvariantCulture));        
    }        
}
