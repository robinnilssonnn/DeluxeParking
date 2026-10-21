using System;
using System.Collections.Generic;
using System.Text;

namespace DeluxeParking
{
    internal class ParkingGarage
    {
        public int NrOfParkingSpots { get; set; }
        public List<Vehicle>[] Vehicles { get; set; }

        public ParkingGarage(int nrOfParkingSports)
        {
            NrOfParkingSpots = nrOfParkingSports;
            Vehicles = new List<Vehicle>[nrOfParkingSports];

            for (int i = 0; i < nrOfParkingSports; i++)
            {
                Vehicles[i] = new List<Vehicle>();
            }
        }


        public static void PrintGarage(List<Vehicle>[] garage)
        {
            Console.Clear();
            Console.WriteLine("----------------------- DELUXE PARKING ÖVERSIKT -----------------------");
            Console.WriteLine();

            for (int i = 0; i < garage.Length; i++)
            {
                Console.Write($"\tPlats {i + 1} ");

                if (garage[i].Count == 0)
                {
                    Console.WriteLine("\tLedigt");
                }
            }
        }
    }
}
