using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Group
    {
        public List<Soldier> Soldiers { get; private set; }

        public Group()
        {
            Soldiers = new List<Soldier>();
        }

        public void AddNewSoldier(Soldier soldier)
        {
            Soldiers.Add(soldier);
        }
    }
}
