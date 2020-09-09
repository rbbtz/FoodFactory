using System;
namespace FactoryPatternExample
{
    public class Burger : IFood
    {
        public Burger()
        {
            Name = "Burger";
            Price = 15;
        }

        public int Price { get; set; }
        public string Name { get; set; }
        public string Tast { get; set; }

        public void Deliver()
        {
            Console.WriteLine("Burger is on it's way");
        }
    }
}
