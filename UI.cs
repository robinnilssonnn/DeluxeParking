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
                Console.WriteLine();
                Console.Write("\tAnvändarnamn: ");
                string username = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\tLösenord: ");
                string password = Console.ReadLine();
                if (username == "Admin" && password == "1234")
                {
                    Console.WriteLine();
                    Console.Write("\tDu loggas in.");
                    Thread.Sleep(1500);
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

        public static char PrintMenu(List<Vehicle>[] garage)
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
                ConsoleKeyInfo key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1 || key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2 || 
                   key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3 || key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4) // D1 = digit 1
                {
                    return key.KeyChar; // Gör om till en char
                }
            }
        }

        public static void LogOut()
        {
            Console.WriteLine();
            Console.Write("\tDu loggas ut.");
            Thread.Sleep(2000);
        }


        public static bool CloseApp()
        {
            Console.WriteLine();
            Console.Write("\tProgrammet avslutas.");
            Thread.Sleep(2000);
            return false;
        }
    }
}
