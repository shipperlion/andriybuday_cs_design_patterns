using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class GameState
    {
        public double Health { get; private set; }
        public int KilledMonsters { get; private set; }

        public GameState(double health, int killedMonsters)
        {
            Health = health;
            KilledMonsters = killedMonsters;
        }

        public override string ToString()
        {
            return $"Health: {Health}\nKilled monsters: {KilledMonsters}";
        }
    }
}
