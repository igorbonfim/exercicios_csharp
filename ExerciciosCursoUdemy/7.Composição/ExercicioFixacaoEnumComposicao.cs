/*
    Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
    sumário do pedido conforme exemplo. Nota: o instante do pedido deve ser
    o instante do sistema: DateTime.Now
*/

using System;
using System.Collections.Generic;
using ExerciciosCursoUdemy._7.Composição.Entities;
using ExerciciosCursoUdemy._7.Composição.Entities.Enums ;
using System.Globalization;

namespace ExerciciosCursoUdemy._7.Composição
{
    class ExercicioFixacaoEnumComposicao
    {
        public void ExercicioEnumComposicao()
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (dd/MM/yyyy): ");
            DateOnly birthDate = DateOnly.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qtdProduct = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);
                OrderItem orderItem = new OrderItem(qtdProduct, priceProduct, product);
                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
