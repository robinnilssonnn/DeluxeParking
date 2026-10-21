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
                Console.WriteLine("----------------------- DELUXE PARKING: LOG IN -----------------------");
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
                Console.WriteLine("----------------------- DELUXE PARKING ADMINISTRATION -----------------------");
                Console.WriteLine();
                ParkingGarage.PrintGarage(garage);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t1. Visa översikt parkering");
                Console.WriteLine("\t2. Checka in fordon");
                Console.WriteLine("\t3. Checka ut fordon");
                Console.WriteLine("\t4. Logga ut");
                Console.Write("\t5. Avsluta ");
                if (int.TryParse(Console.ReadLine(), out int input) && input >= 1 && input <= 5)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("\tOgiltig valt. Tryck för att försöka igen.");
                    Console.ReadKey(true);
                }
            }
            

        }
    }
}
