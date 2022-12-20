/*
    Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
    seguir, calcule e mostre o valor da conta a pagar.

    1 - Cachorro Quente R$ 4.00
    2 - X-Salada        R$ 4.50
    3 - X-Bacon         R$ 5.00
    4 - Torrada Simples R$ 2.00
    5 - Refrigerante    R$ 1.50
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Condicional
{
    public class Exercicio5
    {
        public void CalculaTotalItens()
        {
            int codigoItem, qtdItem;
            double valorItem = 0, totalItem;

            string[] vet = Console.ReadLine().Split(' ');
            codigoItem = int.Parse(vet[0]);
            qtdItem = int.Parse(vet[1]);

            if (codigoItem == 1)
                valorItem = 4.00;
            else if (codigoItem == 2)
                valorItem = 4.50;
            else if (codigoItem == 3)
                valorItem = 5.00;
            else if (codigoItem == 4)
                valorItem = 2.00;
            else if (codigoItem == 5)
                valorItem = 1.50;
            else
                Console.WriteLine("Item não encontrado");

            totalItem = qtdItem * valorItem;

            Console.WriteLine("TOTAL: R$ " +totalItem.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
