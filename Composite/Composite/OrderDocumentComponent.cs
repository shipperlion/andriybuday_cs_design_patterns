namespace Composite
{
    internal class OrderDocumentComponent: IDocumentComponent
    {
        public string Name { get; private set; }
        public int Number { get; private set; }

        public List<IDocumentComponent> DocumentOrders { get; private set; }

        public OrderDocumentComponent(int number)
        {
            Number = number;
            Name = "Orders";
            DocumentOrders = new List<IDocumentComponent>();
        }

        public string GatherData()
        {
            string customerOrder;
            switch (Number)
            {
                case 0:
                    customerOrder = "Kindle;Book1;Book2";
                    break;
                case 1:
                    customerOrder = "Phone;Cable;Headset";
                    break;
                default:
                    customerOrder = "Book1;Book2;Notepad";
                    break;
            }
            return $"   <Order>{customerOrder}</Order>";
        }

        public void AddComponent(IDocumentComponent documentComponent)
        {
            DocumentOrders.Add(documentComponent);
        }
    }
}
