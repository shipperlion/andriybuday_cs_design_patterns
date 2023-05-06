using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class RobotBombDefuser
    {
        private Random _random = new Random();
        private int _robotConfigureWaveLength = 42;
        private bool _isConnected = false;

        public void ConnectWireless(int communicationWaveLength)
        {
            if(communicationWaveLength == _robotConfigureWaveLength)
            {
                _isConnected = IsConnectedImmitatingConnectivityIssues();
            }
        }

        public bool IsConnected()
        {
            _isConnected = IsConnectedImmitatingConnectivityIssues();
            return _isConnected;
        }

        public bool IsConnectedImmitatingConnectivityIssues()
        {
            return _random.Next(0, 10) < 4;
        }

        public virtual void WalkStraightForward(int steps)
        {
            Console.WriteLine($"Did {steps} steps forward");
        }

        public virtual void TurnRight()
        {
            Console.WriteLine("Turned right...");
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("Turned left...");
        }

        public virtual void DefuseBomb()
        {
            Console.WriteLine("Cut red or green or blue wire...");

        }
    }
}
