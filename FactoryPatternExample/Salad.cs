using System;
namespace FactoryPatternExample
{
    public class Salad : IFood
    {
        public Salad()
        {
            Name = "Salad";
            Price = 4;
        }

        public int Price {   get; set; }
        public string Name { get; set; }
        public string Tast { get; set; }

        public void Deliver()
        {
            Console.WriteLine("Delivering your Salad");
        }
    }
}
