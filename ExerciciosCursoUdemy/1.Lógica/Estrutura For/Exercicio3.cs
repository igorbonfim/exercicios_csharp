/*
    Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
    de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
    conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
    peso 5. 
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_For
{
    public class Exercicio3
    {
        public void MediaPonderada()
        {
            int casosDeTeste = int.Parse(Console.ReadLine());                        

            for (int i = 1; i <= casosDeTeste; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
                Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);
            }         
            
        }
    }
}
