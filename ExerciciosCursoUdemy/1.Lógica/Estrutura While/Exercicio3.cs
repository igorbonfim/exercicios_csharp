/*
    Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
    um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
    4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
    que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
    mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
    exemplo. 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_While
{
    public class Exercicio3
    {
        public void Combustivel()
        {
            int combustivel = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (combustivel != 4)
            {              
                if (combustivel >= 1 && combustivel <= 3)
                {
                    if (combustivel == 1)
                        alcool++;
                    else if (combustivel == 2)
                        gasolina++;
                    else
                        diesel++;
                }

                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " +alcool);
            Console.WriteLine("Gasolina: " +gasolina);
            Console.WriteLine("Diesel: " +diesel);
        }
    }
}
