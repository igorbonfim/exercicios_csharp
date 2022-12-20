/*
    Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
    Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
    ordem crescente ou decrescente. 
*/
namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Condicional
{
    public class Exercicio3
    {
        public void Multiplos()
        {
            int n1, n2;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2= int.Parse(vet[1]);
            

            if ((n1 % n2 == 0) || (n2 % n1 == 0))            
                Console.WriteLine("MÚLTIPLOS");            
            else
                Console.WriteLine("NAO SÃO MÚLTIPLOS");

            
        }
    }
}
