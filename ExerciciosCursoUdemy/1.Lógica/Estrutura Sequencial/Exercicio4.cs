/*
    Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
    hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
    decimais.
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Sequencial
{
    public class Exercicio4
    {
        public void CalculaHorasTrabalhadas()
        {
            int numeroFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER: " +numeroFuncionario);
            Console.WriteLine("SALARY: $ " +salario.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
