using System;
using System.Collections.Generic;

namespace FactoryPatternExample
{
    public static class FoodFactory
    {
        static FoodFactory()
        {
        }

        public static void PrintReciept(List<IFood> foods)
        {
            int total = 0;
            foreach(var food in foods)
            {
                Console.WriteLine($"item {food.Name}: ${food.Price}");
                total += food.Price;
            }

            Console.WriteLine($"Your total is ${total}");
        }

        public static int GetOrder()
        {
            int hungerAmount = 0;
            bool input = true;
            while(input == true)
            {

            Console.WriteLine("What is your hunger degree?");
            input = int.TryParse(Console.ReadLine(), out hungerAmount);

            bool keepOrdering = true;
                return hungerAmount;
            }
            return hungerAmount;

        }
        public static IFood GetFood(int hungerDegree)
        {
            if(hungerDegree >= 10)
            {
                return new Burger();
            }
            else if(hungerDegree >= 5)
            {
                return new Pizza();
            }
            else
            {
                return new Salad();
            }
        }
    }
}
