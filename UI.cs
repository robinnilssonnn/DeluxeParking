using System;
using System.Collections.Generic;
using System.Text;

namespace DeluxeParking
{
    internal class UI
    {
        public static void PrintLogInPage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("---------------------------- DELUXE PARKING: LOGGA IN ----------------------------");
                Console.WriteLine();
                Console.Write("\tAnvändarnamn: ");
                string username = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\tLösenord: ");
                string password = Console.ReadLine();
                if (username == "Admin" && password == "1234")
                {
                    Console.WriteLine();
                    Console.WriteLine("\tDu loggas in.");
                    Thread.Sleep(1000);
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("\tFelaktigt användarnamn eller lösenord. Tryck för att försöka igen.");
                    Console.ReadKey(true);
                }

            }
        }

        public static int PrintMenu(List<Vehicle>[] garage)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("--------------------------- DELUXE PARKING: ÖVERSIKT ---------------------------");
                Console.WriteLine();
                Console.WriteLine();
                ParkingGarage.PrintGarage(garage);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t1. Checka in fordon");
                Console.WriteLine("\t2. Checka ut fordon");
                Console.WriteLine("\t3. Logga ut");
                Console.Write("\t4. Avsluta ");
                if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= 5)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\tOgiltigt val. Tryck för att försöka igen.");
                    Console.ReadKey(true);
                }
            }
            

        }
    }
}
