using ExerciciosCursoUdemy._7.Composição.Entities.Enums;
using System.Globalization;

namespace ExerciciosCursoUdemy._7.Composição
{
    class ExemploEnumComposicao
    {
        public void ExercicioExemplo()
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/Mid/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(deptName);
            Worker worker = new Worker(workerName, level, baseSalary, department);

            Console.Write("How many contracts to this worker?: ");
            int numberContracts = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= numberContracts; i++)
            {
                Console.WriteLine($"Enter #{i}: contract data");
                Console.Write("Date(DD//MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income: (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year =  int.Parse(monthAndYear.Substring(3));

            worker.Income(month, year);
            Console.WriteLine("Name: " +worker.Name);
            Console.WriteLine("Department: " +worker.Department.Name);
            Console.WriteLine("Income for "+monthAndYear+": " +worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
