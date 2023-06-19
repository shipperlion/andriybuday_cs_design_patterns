using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    internal class Food
    {
        public string Name { get; set; }

        public List<string> Ingredients { get; set; }

        public Food(string name, List<string> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
