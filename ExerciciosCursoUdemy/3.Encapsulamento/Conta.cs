using System.Globalization;

namespace ExerciciosCursoUdemy._3.Encapsulamento
{
    public class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }        
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }        
        public Conta(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }          

        public double getSaldoAtual()
        {
            return Saldo;
        }

        public void Deposito(double valor)
        {
            Saldo = valor + Saldo;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor - 5;
        }

        public override string ToString()
        {
            return  "Conta: " 
                    +NumeroConta
                    + ", Titular: "                    
                    +NomeTitular 
                    + ", Saldo: $ " +getSaldoAtual().ToString("F2", CultureInfo.InvariantCulture);                    
          
        }
    }
}
