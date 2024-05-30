using ExerciciosCursoUdemy._11._Interfaces.Entities;
using System.Globalization;

namespace ExerciciosCursoUdemy._11._Interfaces.Services;
class ContractService
{
    private IOnlinePaymentService _onlinePaymentService;

    public ContractService(IOnlinePaymentService onlinePaymentService)
    {
        _onlinePaymentService = onlinePaymentService;
    }

    public void ProcessContract(Contract contract, int months)
    {                  
        for (int i = 1; i <= months; i++)
        {
            double amountInstallment = contract.TotalValue / months;
            DateTime dueDateInstallment = contract.Date.AddMonths(i);                       

            amountInstallment = _onlinePaymentService.Interest(amountInstallment, i);
            amountInstallment = _onlinePaymentService.PaymentFee(amountInstallment);
            Installment installment = new Installment(dueDateInstallment, amountInstallment);
            contract.AddInstallment(installment);
        }
    }    
}
