/* Classe utilizada no exercício 4 */

using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class ConversorDeMoeda
    {
        public static int valorPorcentagemIof = 6;

        public static double CalculaTotalDolar(double valorDolar, double totalComprado)
        {
            double total = valorDolar * totalComprado;
            double valorImposto = (total * valorPorcentagemIof) / 100;
            return total + valorImposto;
        }
    }
}
