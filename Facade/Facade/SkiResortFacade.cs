﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class SkiResortFacade
    {
        private SkiRent _skiRent = new SkiRent();
        private SkiResortTicketSystem _skiResortTicketSystem = new SkiResortTicketSystem();
        private HotelBookingSystem _hotelBookingSystem = new HotelBookingSystem();

        public int HaveGoodRest(int height, int weight, int feetSize, int skierLevel, int roomQuality)
        {
            int skiPrice = _skiRent.RentSki(weight, skierLevel);
            int skiBootsPrice = _skiRent.RentBoots(feetSize, skierLevel);
            int polePrice = _skiRent.RentPole(height);
            int oneDayTicketPrice = _skiResortTicketSystem.BuyOneDayTicket();
            int hotelPrice = _hotelBookingSystem.BookRoom(roomQuality);

            return skiPrice + skiBootsPrice + polePrice + oneDayTicketPrice + hotelPrice;
        }

        public int HaveRestWithOwnSkis()
        {
            int oneDayTicketPrice = _skiResortTicketSystem.BuyOneDayTicket();
            return oneDayTicketPrice;
        }
    }
}
