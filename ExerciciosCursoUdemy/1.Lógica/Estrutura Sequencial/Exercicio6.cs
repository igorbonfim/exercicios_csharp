/*
    Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
    mostre:
    a) a área do triângulo retângulo que tem A por base e C por altura.
    b) a área do círculo de raio C. (pi = 3.14159)
    c) a área do trapézio que tem A e B por bases e C por altura.
    d) a área do quadrado que tem lado B.
    e) a área do retângulo que tem lados A e B. 
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Sequencial
{
    public class Exercicio6
    {
        public void Area()
        {
            float a, b, c;
            
            string[] vet = Console.ReadLine().Split(' ');
            a = float.Parse(vet[0], CultureInfo.InvariantCulture);
            b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            c = float.Parse(vet[2], CultureInfo.InvariantCulture);

            double areaTrianguloRetangulo = a * (c / 2);
            double areaCirculoRaio = 3.14159 * Math.Pow(c, 2);
            double areaTrapezio = 0.5 * c * (a + b);
            double areaQuadrado = b * b;
            double areaRetangulo = a * b;

            Console.WriteLine("TRIÂNGULO: " +areaTrianguloRetangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " +areaCirculoRaio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " +areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " +areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " +areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
