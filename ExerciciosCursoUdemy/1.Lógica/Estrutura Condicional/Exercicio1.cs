/*
    Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não. 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Condicional
{
    public class Exercicio1
    {
        public void NumeroNegativo()
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                Console.WriteLine("NEGATIVO");
            else
                Console.WriteLine("NÃO NEGATIVO");
        }
    }
}
