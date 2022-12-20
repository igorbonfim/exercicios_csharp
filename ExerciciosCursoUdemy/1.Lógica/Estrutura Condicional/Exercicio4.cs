/*
    Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
    começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. 
*/

namespace ExerciciosCursoUdemy._1.Lógica.Estrutura_Condicional
{
    public class Exercicio4
    {
        public void CalculaHoraJogo()
        {
            int horaInicial, horaFinal, duracao;

            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal= int.Parse(vet[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
                duracao = 24 - (horaInicial - horaFinal);            
            
            Console.WriteLine("O JOGO DUROU " + duracao + " HORAS");                      
            
        }
    }
}
