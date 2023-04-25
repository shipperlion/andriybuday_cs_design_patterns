using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var gamingBuilder = new GamingLaptopBuilder();
            var tripBuilder = new TripLaptopBuilder();
            var laptopShop = new BuyLaptop();

            laptopShop.SetLaptopBuilder(gamingBuilder);
            laptopShop.ConstructLaptop();

            Laptop laptop = laptopShop.GetLaptop();
            Console.WriteLine(laptop.ToString());
        }
    }
}
