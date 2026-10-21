using System.Diagnostics.Metrics;

namespace DeluxeParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = new ParkingGarage(15); // Skapar ett parkeringsgarage som har 15 platser och tar Vehicle-objekt

            bool appRunning = true;

            while (appRunning)
            {

                //UI.PrintLogInPage();

                while (true)
                {

                    
                    int menuPick = UI.PrintMenu(parkingGarage.Vehicles); // Skriver ut menyn och levererar ett menyval i form av en int

                    switch (menuPick)
                    {

                        case 1:

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------- DELUXE PARKING: CHECK-IN ----------------------------");
                            Console.WriteLine();
                            Vehicle newVehicle = Helpers.GenerateRandomVehicle();
                            Console.WriteLine();
                            newVehicle.ArrivingCarInfo();
                            Thread.Sleep(1000);
                            Console.WriteLine();
                            ParkingGarage.CheckInVehicle(parkingGarage.Vehicles, newVehicle);
                            Console.WriteLine();
                            Console.WriteLine("\tTryck för att återgå till översikten.");
                            Console.ReadKey(true);

                            break;

                        case 2:

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------- DELUXE PARKING: CHECK-OUT ----------------------------");
                            Console.WriteLine();
                            ParkingGarage.PrintGarage(parkingGarage.Vehicles);
                            ParkingGarage.ChechOutVehicle(parkingGarage.Vehicles);

                            break;

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("\tDu loggas ut.");
                            Thread.Sleep(2000);
                            break;

                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("\tProgrammet avslutas.");
                            Thread.Sleep(2000);
                            appRunning = false;
                            break;

                    }

                    break;
                }
                
            }

        }
    }
}
