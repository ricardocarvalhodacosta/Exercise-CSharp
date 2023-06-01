using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercicio_11.Entities.Enums;

namespace Exercicio_11.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item) 
        {  
            OrderItens.Remove(item); 
        }

        public double Total(double price)
        {
            return price++;
        }

        Client client = new Client();
        Product product = new Product();
        OrderItem item = new OrderItem();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.Append(DateTime.Now);
            sb.AppendLine("Order status: ");
            sb.Append(Status);
            sb.AppendLine("Client: ");
            sb.Append(client.Name + "(" + client.BirthDate + ") - " + client.Email);
            sb.AppendLine("Order items: ");
            sb.AppendLine(product.Name + ", $" + product.Price + ", Quantity: " + item.Quantity + ", Subtotal: " + item.SubTotal());
            sb.AppendLine("Total price: ");
            sb.Append(Total);

            return sb.ToString();
        }
    }
}
