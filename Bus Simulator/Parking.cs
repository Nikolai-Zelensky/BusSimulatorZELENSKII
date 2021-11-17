using System;
using System.Collections.Generic;
using BusSim;

namespace BusSim
{
    class Parking
    {
        List<Buses> bus = new List<Buses>();
        int parkingnumber = 0;
        public void Add(Buses b)
        {
            if(bus == null)
            {
                bus = new List<Buses>();
            }
            bus.Add(b);
        }

        public void Remove(Buses b)
        {
            if(bus == null)
            {
                Console.WriteLine("The bus has left for the route");
            }
            bus.Remove(b);
        }

        public int ParkingNumber
        {
            get { return parkingnumber; }
            set
            {
                if (value > 0 && value < 999)
                {
                    parkingnumber = value;
                }
            }
        }

        public void Show_Info()
        {
            foreach(Buses b in bus)
            {
                b.ShowBus();
            }
        }

    }
}