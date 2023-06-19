using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Caretaker
    {
        private readonly GameOriginator _game = new GameOriginator();
        private readonly Stack<GameMemento> _quickSaves = new Stack<GameMemento>();

        public void Shoot()
        {
            _game.Play();
        }

        public void F5()
        {
            _quickSaves.Push(_game.GameSave());
        }

        public void F9()
        {
            _game.LoadGame(_quickSaves.Peek());
        }
    }
}
