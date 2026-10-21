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
            Console.WriteLine();
            Console.WriteLine($"\t\t\t{"Fordonstyp", -15}{"Reg. nr", -15}{"Färg", -15}{"Övrig info", -15}");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 0; i < garage.Length; i++)
            {
                Console.Write($"\tPlats {i + 1} ");

                if (garage[i].Count == 0)
                {
                    Console.WriteLine("\tLedigt");
                }
                else 
                {
                    garage[i][0].ParkedCarInfo();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------");

        }

        public static void CheckInVehicle(List<Vehicle>[] garage, Vehicle newVehicle)
        {
            if(newVehicle is Car)
            {
                for(int i = 0;i < garage.Length - 1; i++)
                {
                    if(garage[i].Count == 0)
                    {
                        garage[i].Add(newVehicle);
                        Console.WriteLine($"\tBil med registreringsnummer {newVehicle.RegistrationNumber} tillagd på plats {i + 1}.");
                        break;
                    }
                }
            }
            if (newVehicle is Bus)
            {
                for (int i = 0; i < garage.Length; i++)
                {
                    if (garage[i].Count == 0 && garage[i + 1].Count == 0)
                    {
                        garage[i].Add(newVehicle);
                        garage[i + 1].Add(newVehicle);
                        Console.WriteLine($"\tBuss med registreringsnummer {newVehicle.RegistrationNumber} tillagd på plats {i + 1} och {i + 2}.");
                        break;
                    }
                }
            }
            if (newVehicle is Motorcycle)
            {

            }
        }

    }
}
