using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ConservativePlayer: IObserver
    {
        public string BoxerToPutMoneyOn { get; set; }

        public void Update(ISubject subject)
        {
            var boxFight = (BoxFight)subject;
            if (boxFight.BoxerAScore < boxFight.BoxerBScore)
                BoxerToPutMoneyOn = "I'll put money on boxer B - better be safe!";
            else
                BoxerToPutMoneyOn = "I'll put money on boxer A - better be safe!";
            Console.WriteLine($"CONSERVATIVE PLAYER: {BoxerToPutMoneyOn}");
        }
    }
}
