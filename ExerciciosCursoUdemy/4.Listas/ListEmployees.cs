/*
    Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
    N funcionários. Não deve haver repetição de id.
    Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
    Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
    mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
    conforme exemplos.
    Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
    ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
    aumento por porcentagem dada. 
*/
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ExerciciosCursoUdemy._4.Listas
{
    public class ListEmployees
    {
        public void ListEmployeesSalary()
        {
            List<Employee> list = new List<Employee>();
            
            int id = 0;
            string name;
            double salary = 0;            

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());            
            
            for (int i = 1; i <= n; i++)
            {                
                Console.WriteLine($"Employee #{i}");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));                                
                Console.WriteLine();
            }

            Console.Write("Enter the ID that will have salary increase: ");
            int idEmployee = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == idEmployee);

            if (emp != null)
            {                
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This ID does not exist!");
            }
            
            Console.WriteLine();

            Console.WriteLine("Updated list of employees:");
            
            foreach (Employee employee in list )
            {
                Console.WriteLine(employee);
            }            
        }
    }
}
