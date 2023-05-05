using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class CustomerDocumentComponent: IDocumentComponent
    {
        private int CustomerIDToGatherData { get; set; }

        public CustomerDocumentComponent(int customerIDToGatherData)
        {
            CustomerIDToGatherData = customerIDToGatherData;
        }

        public string GatherData()
        {
            string customerData;
            switch(CustomerIDToGatherData)
            {
                case 42:
                    customerData = "Andriy Buday";
                    break;
                default:
                    customerData = "Someone else";
                    break;
            }
            return $"  <Customer>{customerData}</Customer>";
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            Console.WriteLine("Cannot add to leaf");
        }
    }
}
