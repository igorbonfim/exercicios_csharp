/*
    Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
    sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
    o instante do sistema: DateTime.Now
    
    Exemplo saída:
    Enter cliente data:
    Name: Alex Green
    Email: alex@gmail.com
    Birth date (DD/MM/YYYY): 15/03/1985
    Enter order data:
    Status: Processing
    How many items to this order? 2
    Enter #1 item data:
    Product name: TV
    Product price: 1000.00
    Quantity: 1
    Enter #2 item data:
    Product name: Mouse
    Product price: 40.00
    Quantity: 2
    ORDER SUMMARY:
    Order moment: 20/04/2018 11:25:09
    Order status: Processing
    Client: Alex Green (15/03/1985) - alex@gmail.com
    Order items:
    TV, $1000.00, Quantity: 1, Subtotal: $1000.00
    Mouse, $40.00, Quantity: 2, Subtotal: $80.00
    Total price: $1080.00
*/

namespace ExerciciosCursoUdemy._6.Enums
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id +
                   ", " +
                   Moment +
                   ", " +
                   Status;
        }
        
    }
}
