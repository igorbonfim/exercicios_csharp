namespace ExerciciosCursoUdemy._11._Interfaces.Services;
class PayPalService : IOnlinePaymentService
{    public double Interest(double amount, int months)
    {
        amount = amount + (amount * 0.01 * months);
        return amount;
    }

    public double PaymentFee(double amount)
    {
        amount = amount + (amount * 0.02);
        return amount;
    }
}
