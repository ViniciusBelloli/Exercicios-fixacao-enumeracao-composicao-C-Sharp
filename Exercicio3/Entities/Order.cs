using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio3.Entities.Enums;
using System.Text;

namespace Exercicio3.Entities
{
   class Order
   {
      public DateTime Moment { get; set; }
      public OrderStatus Status { get; set; }
      public Client Client { get; set; }
      public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

      public Order()
      {
      }

      public Order(DateTime moment, OrderStatus status, Client client)
      {
         Moment = moment;
         Status = status;
         Client = client;
      }

      public void AddItem(OrderItem orderitems)
      {
         OrderItems.Add(orderitems);
      }

      public void RemoveItem(OrderItem orderitems)
      {
         OrderItems.Add(orderitems);
      }

      public override string ToString()
      {
         StringBuilder sb = new StringBuilder();
         sb.AppendLine("ORDER SUMARY:");
         sb.Append("Order moment: " );
         sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
         sb.Append("Order status: ");
         sb.AppendLine(Status.ToString());
         sb.Append("Client: ");
         sb.AppendLine(Client.ToString());
         sb.AppendLine("Order items:");

         double soma = 0;

         foreach (OrderItem c in OrderItems)
         {
            sb.AppendLine(c.ToString());
            soma += c.SubTotal();
         }

         sb.Append("Total price: $");
         sb.AppendLine(soma.ToString("F2", CultureInfo.InvariantCulture));

         return sb.ToString();
      }
   }
}