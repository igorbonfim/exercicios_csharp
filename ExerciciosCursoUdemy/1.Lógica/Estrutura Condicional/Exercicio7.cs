/*
    Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
    de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
    ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
    Se o ponto estiver na origem, escreva a mensagem “Origem”.
    Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
    situação. 
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Condicional
{
    public class Exercicio7
    {
        public void Quadrante()
        {
            double eixoX, eixoY;

            string[] vet = Console.ReadLine().Split(' ');
            eixoX = double.Parse(vet[0], CultureInfo.InvariantCulture);
            eixoY = double.Parse(vet[1], CultureInfo.InvariantCulture);

            if (eixoX == 0 && eixoY == 0)
                Console.WriteLine("Origem");
            else if (eixoX == 0.0)
                Console.WriteLine("Eixo X");
            else if (eixoY == 0.0)
                Console.WriteLine("Eixo Y");
            else if (eixoX < 0 && eixoY < 0)
                Console.WriteLine("Q3");
            else if (eixoX < 0 && eixoY > 0)
                Console.WriteLine("Q2");
            else if (eixoX > 0 && eixoY < 0)
                Console.WriteLine("Q4");
            else if (eixoX > 0 && eixoY > 0)
                Console.WriteLine("Q1");

        }
    }
}
