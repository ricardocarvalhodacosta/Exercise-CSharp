using System;
using System.Globalization;
using Exercicio_11.Entities;
using Exercicio_11.Entities.Enums;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem orderItem = new OrderItem();
            Client client = new Client();
            Product product = new Product();

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int itemQuantity = int.Parse(Console.ReadLine());
            }

            Order order = new Order();

            Console.WriteLine(order);
        }
    }
}