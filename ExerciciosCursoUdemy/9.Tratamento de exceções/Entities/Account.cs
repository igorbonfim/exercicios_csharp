using ExerciciosCursoUdemy._9.Tratamento_de_exceções.Domain;

namespace ExerciciosCursoUdemy._9.Tratamento_de_exceções.Entities;
class Account
{
    public int Number { get; set; }
    public string Holder { get; set; }
    public double Balance { get; set; }
    public double WithdrawLimit { get; set; }

    public Account() { }

    public Account(int number, string holder, double balance, double withDrawLimit)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
        WithdrawLimit = withDrawLimit;
    }

    public void Deposit(double amount)
    {
        Balance = Balance + amount;
    }

    public void WithDraw(double amount) 
    {
        if (amount > Balance)
        {
            throw new DomainException("Not enough balance");
        }

        if (amount > WithdrawLimit)
        {
            throw new DomainException("The amount exceeds witdraw limit");
        }

        Balance = Balance - amount;
    }
}
