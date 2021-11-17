using System;

namespace BusSim
{
    class Buses
    {
        int number_bus;
        string last_initi;
        int number_road;

        public int Number_bus
        {
            get { return number_bus; }
            set
            {
                if (value > 0 && value < 999)
                {
                    number_bus = value;
                }
            }
        }
        
        public int Number_road
        {
            get { return number_road; }
            set
            {
                if (value > 0 && value < 999)
                {
                    number_road = value;
                }
            }
        }
        
        public string Last_init
        {
            get
            {
                return last_initi;
            }
            set
            {
                if (value != null)
                {
                    last_initi = value;
                }
                else
                {
                    Console.WriteLine("This driver has already been recorded");
                }
            }
        }

        public void ShowBus()
        {
            Console.WriteLine();
            Console.WriteLine($"Bus number: {number_bus} ");
            Console.WriteLine($"Driver's full name: {last_initi} ");
            Console.WriteLine($"Route number: {number_road} ");
        }
    }
}