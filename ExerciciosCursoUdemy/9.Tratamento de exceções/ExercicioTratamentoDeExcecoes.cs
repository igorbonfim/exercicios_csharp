using ExerciciosCursoUdemy._9.Tratamento_de_exceções.Domain;
using ExerciciosCursoUdemy._9.Tratamento_de_exceções.Entities;
using System.Globalization;

namespace ExerciciosCursoUdemy._9.Tratamento_de_exceções;
class ExercicioTratamentoDeExcecoes
{
    public void TratamentoDeExcecoes()
    {
        try
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);           

            Console.WriteLine();
            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.WithDraw(amount);

            Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
        catch (DomainException e)
        {
            Console.Write("Withdraw error: " + e.Message);
        }       
        catch (FormatException e)
        {
            Console.Write("Format error: " + e.Message);
        }
    }
}
