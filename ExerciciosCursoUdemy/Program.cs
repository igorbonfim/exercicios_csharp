using ExerciciosCursoUdemy._6.Enums;

namespace ExerciciosCursoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            
        }
    }
}