using System;
namespace FactoryPatternExample
{
    public class Pizza : IFood
    {
        public Pizza()
        {
            Name = "Pizza";
            Price = 7;
        }

        public int Price { get;   set; }
        public string Name { get; set; }
        public string Tast { get; set; }

        public void Deliver()
        {
            Console.WriteLine("Pizza is on it's way");
        }
    }
}
