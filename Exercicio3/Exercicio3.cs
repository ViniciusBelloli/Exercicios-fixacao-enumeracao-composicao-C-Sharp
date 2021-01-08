using System;
using System.Globalization;
using Exercicio3.Entities;
using Exercicio3.Entities.Enums;

namespace Exercicio3
{
   class Exercicio3
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Enter cliente data:");
         Console.Write("Name: ");
         string name = Console.ReadLine();
         Console.Write("Email: ");
         string email = Console.ReadLine();
         Console.Write("Birth date (DD/MM/YYYY): ");
         DateTime bdate = DateTime.Parse(Console.ReadLine());

         Console.WriteLine("Enter order data:");
         Console.Write("Status: ");
         OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

         Client client = new Client(name, email, bdate);
         Order os = new Order(DateTime.Now, status, client);

         Console.Write("How many items to this order? ");
         int nitems = int.Parse(Console.ReadLine());

         for (int i = 1; i <= nitems; i++)
         {
            Console.WriteLine($"Enter {i} item data:");
            Console.Write("Product name: ");
            string pname = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());
            Product product = new Product(pname, price);

            OrderItem order = new OrderItem(product, quantity, price);
            os.AddItem(order);
         }

         Console.WriteLine("\n" + os);
      }
   }
}