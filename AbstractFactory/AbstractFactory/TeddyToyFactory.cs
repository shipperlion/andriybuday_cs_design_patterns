using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class TeddyToyFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new TeddyBear();
        }

        public Cat GetCat()
        {
            return new TeddyCat();
        }
    }
}
