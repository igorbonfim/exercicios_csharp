/* Classe utilizada no Exercício 2 */

using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() 
        { 
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100;            
        }

        public override string ToString()
        {
            return
                Nome +
                " R$ " +
                SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
