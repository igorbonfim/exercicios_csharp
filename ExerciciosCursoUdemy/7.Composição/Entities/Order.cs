using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosCursoUdemy._7.Composição.Entities.Enums;
using System.Globalization;

namespace ExerciciosCursoUdemy._7.Composição.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }  

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine(Client.Name.ToString() + "("+Client.BirthDate.ToString() + ")" + " - " + Client.Email.ToString());
            sb.AppendLine("Order items:");

            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name.ToString()+ ", ");
                sb.Append("$" + item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)+ ", ");
                sb.Append("Quantity: " + item.Quantity.ToString() + ", ");
                sb.AppendLine("Subtotal: $" + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }

            sb.Append("Total price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
