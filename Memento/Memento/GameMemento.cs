using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class GameMemento
    {
        private readonly GameState _state;

        public GameMemento(GameState state)
        {
            _state = state;
        }

        public GameState GetState()
        {
            return _state;
        }
    }
}
