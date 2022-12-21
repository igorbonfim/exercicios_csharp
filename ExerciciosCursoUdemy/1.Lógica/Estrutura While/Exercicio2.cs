/*
    Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
    cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
    menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma). 
*/

using System.Runtime.CompilerServices;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_While
{
    public class Exercicio2
    {
        public void Coordenadas()
        {
            int x = 0, y = 0;
            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {               
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }            

        }    
        

    }
}
