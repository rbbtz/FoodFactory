using System;
namespace FactoryPatternExample
{
    public interface IFood
    {
        void Deliver();
        

        int Price { get; set; }
        string Name { get; set; }
        string Tast { get; set; }
    }


}
