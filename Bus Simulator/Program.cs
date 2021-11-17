using System;
using System.Collections.Generic;

namespace BusSim
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parking> park = new List<Parking>();
            List<Parking> roads = new List<Parking>();
            int num;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1. Add a bus");
                Console.WriteLine("2. Output information");
                Console.WriteLine("3. The bus leaves on the route");
                Console.WriteLine("4. The bus pulls into the parking lot");
                Console.WriteLine("5. Exit.");
                Console.WriteLine();
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (num)
                {
                    case 1:
                        Parking p = new Parking();
                        Buses b = new Buses();
                        Console.Write("Enter the bus number: ");
                        b.Number_bus = int.Parse(Console.ReadLine());
                        p.ParkingNumber = b.Number_bus;
                        Console.WriteLine("The number of the bus that stopped at the parking lot: " + b.Number_bus);
                        park.Add(p);

                        foreach (var g in park)
                        {
                            if (g.ParkingNumber == b.Number_bus)
                            {
                                Console.Write("Enter the driver's last name and initials: ");
                                b.Last_init = Console.ReadLine();
                                Console.Write("Enter the route number: ");
                                b.Number_road = int.Parse(Console.ReadLine());
                                g.Add(b);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Select the location of the bus\n 1 - in the parking\n 2 - on the route");
                        int m = int.Parse(Console.ReadLine());
                        if (m == 1)
                        {
                            foreach (var g in park)
                            {
                                Console.WriteLine("Information about buses in the parking lot:");
                                g.Show_Info();
                                Console.WriteLine();
                            }
                        }
                        if (m == 2)
                        {
                            foreach (var g in roads)
                            {
                                Console.WriteLine("Information about buses on the route:");
                                g.Show_Info();
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        Buses c3 = new Buses();
                        Parking p1 = new Parking();
                        Console.Write("Enter the bus number: ");
                        c3.Number_bus = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < park.Count; i++)
                        {
                            if (park[i].ParkingNumber == c3.Number_bus)
                            {
                                p1.Add(c3);
                                roads.Add(p1);
                                park.RemoveAt(i);
                                break;
                            }
                        }
                        Console.WriteLine("The number of the bus that left for the route: " + c3.Number_bus);
                        break;
                    case 4:
                        Buses c = new Buses();
                        Parking p2 = new Parking();
                        Console.Write("Enter the bus number: ");
                        c.Number_bus = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < roads.Count; i++)
                        {
                            if (roads[i].ParkingNumber == c.Number_bus)
                            {
                                p2.Add(c);
                                park.Add(p2);
                                roads.RemoveAt(i);
                                break;
                            }
                        }
                        Console.WriteLine("The number of the bus that left the parking lot: " + c.Number_bus);
                        break;
                }
            } while (num != 5); 
        }

        public static void BusAdd(List<Parking> park) 
        {
            Parking p = new Parking();
            Buses b = new Buses();
            Console.Write("Enter the bus number: ");
            b.Number_bus = int.Parse(Console.ReadLine());
            p.ParkingNumber = b.Number_bus;
            Console.WriteLine("The number of the bus that stopped at the parking lot: " + b.Number_bus);
            park.Add(p);

            foreach (var g in park)
            {
                if (g.ParkingNumber == b.Number_bus)
                {
                    Console.Write("Enter the driver's last name and initials: ");
                    b.Last_init = Console.ReadLine();
                    Console.Write("Enter the route number: ");
                    b.Number_road = int.Parse(Console.ReadLine());
                    g.Add(b);
                }
            }
        }

        public static void Show(List<Parking> park)
        {
            foreach (var g in park)
            {
                Console.WriteLine("Information about buses in the parking lot:");
                g.Show_Info();
                Console.WriteLine();
            }
        }

        public static void RemoveBus(List<Parking> park, List<Parking> roads)
        {
            Buses c3 = new Buses();
            Console.Write("Enter the bus number: ");
            c3.Number_bus = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < park.Count; i++)
            {
                if (park[i].ParkingNumber == c3.Number_bus)
                {
                    roads.AddRange(park.ToArray());
                    park.RemoveAt(i);
                    break;
                }
            }
        }
    }
}