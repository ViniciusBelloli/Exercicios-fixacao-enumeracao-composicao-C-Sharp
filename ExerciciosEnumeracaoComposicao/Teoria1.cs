using System;
using Teoria1.Entities;
using Teoria1.Entities.Enums;

namespace ExerciciosEnumeracaoComposicao
{
   class Teoria1
   {
      static void Main(string[] args)
      {
         Order o = new Order
         {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
         };

         Console.WriteLine(o);

         string txt = OrderStatus.PendingPayment.ToString();
         Console.WriteLine(txt);

         OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
         Console.WriteLine(os);
      }
   }
}