using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Brain
    {
        public Ear Ear { get; private set; }
        public Eye Eye { get; private set; }
        public Face Face { get; private set; }
        public Hand Hand { get; private set; }
        public Leg Leg { get; private set; }

        public Brain()
        {
            CreateBodyParts();
        }

        public void CreateBodyParts()
        {
            Ear = new Ear(this);
            Eye = new Eye(this);
            Face = new Face(this);
            Hand = new Hand(this);
            Leg = new Leg(this);
        }

        public void SomethingHappenedToBodyPart(BodyPart bodyPart)
        {
            if(bodyPart is Ear)
            {
                string hearSounds = ((Ear)bodyPart).GetSounds();
                if (hearSounds.Contains("stupid"))
                {
                    Leg.StepForward();
                    Hand.Hit();
                    Leg.Kick();
                }
                else if (hearSounds.Contains("cool"))
                {
                    Face.Smile();
                }
            }
            else if(bodyPart is Eye)
            {
                string lookAround = ((Eye)bodyPart).TakeALook();
                if (lookAround.Contains("puppy"))
                {
                    Face.Smile();
                    Leg.StepForward();
                    Hand.Embrace();
                }
                else if(lookAround.Contains("big scary dog"))
                {
                    Face.Frown();
                    Leg.StepBack();
                }
            }
            else if(bodyPart is Hand)
            {
                var hand = (Hand)bodyPart;

                bool hurtingFeeling = hand.DoesItHurt();
                if(hurtingFeeling)
                {
                    Leg.StepBack();
                }

                bool itIsNice = hand.IsItNice();
                if (itIsNice)
                {
                    Leg.StepForward();
                    Hand.Embrace();
                }
            }
            else if(bodyPart is Leg)
            {
                // TODO: ask why two body parts needed
                var leg = (Leg)bodyPart;

                bool itIsSlippery = leg.IsItSlippery();
                if (itIsSlippery)
                {
                    Leg.StepBack();
                }
                Leg.StepForward();
            }
        }
    }
}
