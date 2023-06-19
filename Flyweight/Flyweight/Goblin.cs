﻿namespace Flyweight
{
    internal class Goblin: Unit
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 8;
            Picture = UnitImagesFactory.CreateGoblinImage();
        }
    }
}
