namespace Flyweight
{
    internal class Dragon: Unit
    {
        public Dragon()
        {
            Name = "Dragon";
            Health = 50;
            Picture = UnitImagesFactory.CreateDragonImage();
        }
    }
}
