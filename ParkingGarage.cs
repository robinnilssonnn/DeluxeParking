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
            Console.WriteLine($"\t{"Parkering", -16}{"Fordonstyp", -16}{"Reg. nr", -15}{"Färg", -12}{"Ankomsttid",-20}{"Övrig info"}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i].Count == 2)
                {
                    Console.Write($"\tPlats {i + 1} ");
                    garage[i][0].ParkedCarInfo();
                    Console.Write($"\tPlats {i + 1} ");
                    garage[i][1].ParkedCarInfo();
                }
                else if (garage[i].Count > 0 && garage[i][0] is Bus )
                {
                    Console.Write($"\tPlats {i + 1}-{i + 2}");
                    garage[i][0].ParkedCarInfo();
                    i++;
                }
                else
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
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");

        }

        public static void CheckInVehicle(List<Vehicle>[] garage, Vehicle newVehicle)
        {

            bool parkingFound = false;

            if(newVehicle is Car)
            {
                for(int i = 0;i < garage.Length; i++)
                {
                    if(garage[i].Count == 0)
                    {
                        garage[i].Add(newVehicle);
                        Console.WriteLine($"\tBil med registreringsnummer {newVehicle.RegistrationNumber} tillagd på plats {i + 1} med ankomsttid {newVehicle.ArrivalTime}.");
                        parkingFound = true;
                        break;
                    }
                }
                if (!parkingFound)
                {
                    PrintParkingNotFound();
                }
            }

            if (newVehicle is Bus)
            {
                for (int i = 0; i < garage.Length - 1; i++)
                {
                    if (garage[i].Count == 0 && garage[i + 1].Count == 0)
                    {
                        garage[i].Add(newVehicle);
                        garage[i + 1].Add(newVehicle);
                        Console.WriteLine($"\tBuss med registreringsnummer {newVehicle.RegistrationNumber} tillagd på plats {i + 1} och {i + 2} med ankomsttid {newVehicle.ArrivalTime}.");
                        parkingFound = true;
                        break;
                    }
                }
                if (!parkingFound)
                {
                    PrintParkingNotFound();
                }

            }
            
            
            if (newVehicle is Motorcycle)
            {
                for (int i = 0; i < garage.Length; i++)
                {
                    if (garage[i].Count == 1 && garage[i][0] is Motorcycle)
                    {
                        
                        garage[i].Add(newVehicle);
                        Console.WriteLine($"\tMotorcykel med registreringsnummer {newVehicle.RegistrationNumber} tillagd på plats {i + 1} med ankomsttid {newVehicle.ArrivalTime}.");
                        parkingFound = true;
                        break;
                    }
                }

                if (!parkingFound)
                {
                    for (int i = 0; i < garage.Length; i++)
                    {
                        if (garage[i].Count == 0)
                        {
                            garage[i].Add(newVehicle);
                            Console.WriteLine($"\tMotorcykel med registreringsnummer {newVehicle.RegistrationNumber} tillagd på plats {i + 1} med ankomsttid {newVehicle.ArrivalTime}.");
                            parkingFound = true;
                            break;
                        }
                    }
                }

                if (!parkingFound)
                {
                    PrintParkingNotFound();
                }
            }
        }

        public static void ChechOutVehicle(List<Vehicle>[] garage)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"\tAnge registreringsnummer för att checka ut fordon: ");
            string input = Console.ReadLine();
            bool foundVehicle = false;

            for (int i = 0; i < garage.Length - 1; i++)
            {
                for (int j = 0; j < garage[i].Count; j++)
                {
                    if (garage[i][j].RegistrationNumber == input.ToUpper())
                    {
                        foundVehicle = true;

                        if (garage[i][0] is Bus)
                        {
                            garage[i].Clear();
                            garage[i + 1].Clear();
                        }
                        if (garage[i][j] is Motorcycle)
                        {
                            garage[i].RemoveAt(j);
                        }
                        else
                        {
                            garage[i].Clear();
                        }
                        Console.WriteLine();
                        Console.WriteLine($"\tFordon med registreringsnummer {input} utcheckat.");
                        Console.WriteLine();
                        Console.Write("\tTryck för att återgå till menyn.");
                        Console.ReadKey(true);
                        break;
                    }
                }
                if(foundVehicle)
                {
                    break;
                }
            }
            if(!foundVehicle)
            {
                Console.WriteLine();
                Console.Write("\tInget fordon med det registreringsnummer hittades. Tryck för att återgå till menyn.");
                Console.ReadKey(true);
            }
            
        }

        public static void PrintParkingNotFound()
        {
            Console.WriteLine();
            Console.Write("\tParkeringsplats saknades för fordonstypen. Den får tyvärr ingen plats.");
            Console.WriteLine();

        }
        
    }
}
