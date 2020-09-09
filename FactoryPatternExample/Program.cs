using System;
using System.Collections.Generic;

namespace FactoryPatternExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var orderList = new List<IFood>();
            bool keepOrdering = true;
            do
            {
                int hungerAmount = FoodFactory.GetOrder();
                
                    
                var order = FoodFactory.GetFood(hungerAmount);
                orderList.Add(order);
                order.Deliver();
                    Console.WriteLine("Would you like to Order something else?");
                    if (Console.ReadLine().ToLower() != "yes")
                    {
                        keepOrdering = false;
                    }


            } while (keepOrdering);
            Console.WriteLine("Thanks for your business");
            FoodFactory.PrintReciept(orderList);
     
        }
    }
}
