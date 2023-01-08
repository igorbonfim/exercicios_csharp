/*
 
Exercício 2 

Fazer um programa para ler os dados de um funcionário(nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário(nome e salário líquido). 
Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada(somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. 
Use a classe projetada abaixo.

Funcionario
-Nome: string
-SalarioBruto: double
-Imposto: double

+SalarioLiquido(): double
+AumentarSalario(porcentagem: double): void
 
*/


using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class Exercicio2
    {
        public void SalarioFuncionario()
        {
            Funcionario func = new Funcionario();

            func.Nome = Console.ReadLine();
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.SalarioLiquido();

            Console.WriteLine("Funcionário: " +func);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " +func);
        }
    }
}
