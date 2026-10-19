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
    }
}
