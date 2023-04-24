using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WoodenToyFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new WoodenBear();
        }

        public Cat GetCat()
        {
            return new WoodenCat();
        }
    }
}
