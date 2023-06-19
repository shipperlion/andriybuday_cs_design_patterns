using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class RiskyPlayer: IObserver
    {
        public string BoxerToPutMoneyOn { get; set; }

        public void Update(ISubject subject)
        {
            var boxFight = (BoxFight)subject;
            if (boxFight.BoxerAScore > boxFight.BoxerBScore)
                BoxerToPutMoneyOn = "I'll put money on boxer B: i'll get more if he wins!";
            else
                BoxerToPutMoneyOn = "I'll put money on boxer A: i'll get more if he wins!";
            Console.WriteLine($"RISKY PLAYER: {BoxerToPutMoneyOn}");
        }
    }
}
