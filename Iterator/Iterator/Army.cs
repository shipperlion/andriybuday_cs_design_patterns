using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Army
    {
        public Hero ArmyHero { get; private set; }
        public List<Group> ArmyGroups { get; private set; }
        public Army(Hero hero)
        {
            ArmyHero = hero;
            ArmyGroups = new List<Group>();
        }

        public void AddArmyGroup(Group group)
        {
            ArmyGroups.Add(group);
        }
    }
}
