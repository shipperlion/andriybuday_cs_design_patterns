using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    internal class InterpreterDemo
    {
        public static void Run()
        {
            new InterpreterDemo().RunInterpreterDemo();
        }

        public void RunInterpreterDemo()
        {
            var truckWithGoods = PrepareTruckWithGoods();
            var pricesContext = GetRecentPricesContext();
            var totalPriceForGoods = truckWithGoods.Interpret(pricesContext);
            Console.WriteLine($"Total price: {totalPriceForGoods}");
        }

        private CurrentPricesContext GetRecentPricesContext()
        {
            var pricesContext = new CurrentPricesContext();
            pricesContext.SetPrice("Bed", 400);
            pricesContext.SetPrice("Laptop", 500);
            pricesContext.SetPrice("TV", 100);
            return pricesContext;
        }

        public GoodsPackage PrepareTruckWithGoods()
        {
            var truck = new GoodsPackage() { GoodsInside = new List<Goods>() };
            var bed = new Bed();
            var doubleTriplePackedBed = new GoodsPackage()
            {
                GoodsInside = new List<Goods>() { new GoodsPackage() { GoodsInside = new List<Goods>() { bed } } }
            };
            truck.GoodsInside.Add(doubleTriplePackedBed);
            truck.GoodsInside.Add(new TV());
            truck.GoodsInside.Add(new TV());
            truck.GoodsInside.Add(new GoodsPackage()
            {
                GoodsInside = new List<Goods>()
                {
                    new Laptop(), new Laptop(), new Laptop()
                }
            });
            return truck;
        }
    }
}
