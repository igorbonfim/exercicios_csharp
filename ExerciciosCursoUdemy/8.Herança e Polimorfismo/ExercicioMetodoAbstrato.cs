using ExerciciosCursoUdemy._8.Herança_e_Polimorfismo.Entities;
using System.Globalization;

namespace ExerciciosCursoUdemy._8.Herança_e_Polimorfismo;
class ExercicioMetodoAbstrato
{
    public void ExercicioResolucao()
    {
        List<TaxPayer> list = new List<TaxPayer>();

        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax Payer #{i} data");
            Console.Write("Individual or company: (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual Income: ");
            double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'i')
            {
                Console.Write("Health Expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else
            {
                Console.Write("Number of employees: ");
                int numberOfEmployees = int.Parse(Console.ReadLine());
                list.Add(new Company(name, anualIncome, numberOfEmployees));
            }
        }

        Console.WriteLine();
        Console.WriteLine("TAXES PAID:");
        double totalTaxes = 0;

        foreach (var item in list)
        {
            Console.Write(item.Name + ": $" + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            totalTaxes += item.Tax();
        }

        Console.WriteLine();
        Console.Write("TOTAL TAXES: ");
        Console.Write("$ " +totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
    }
}
