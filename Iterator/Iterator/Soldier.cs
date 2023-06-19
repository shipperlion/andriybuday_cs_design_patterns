using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Soldier
    {
        public string Name { get; set; }
        public int Health { get; set; }
        private readonly int HealthPoints = 100;

        protected virtual int MaxHealthPoints { get { return HealthPoints; } }

        public Soldier(string name)
        {
            Name = name;
        }

        public void Treat()
        {
            Health = MaxHealthPoints;
            Console.WriteLine(Name);
        }
    }
}
