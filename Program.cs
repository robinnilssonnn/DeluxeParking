using System.Diagnostics.Metrics;

namespace DeluxeParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = new ParkingGarage(15); // Skapar ett parkeringsgarage som har 15 platser och tar Vehicle-objekt

            bool appRunning = true;
            bool exitApp = false;

            while(!exitApp)
            {

                UI.PrintLogInPage();
                appRunning = true;

                while(appRunning)
                {

                    char menuPick = UI.PrintMenu(parkingGarage.Vehicles); // Skriver ut översikt + meny och returnerar ett menyval i form av en int

                    switch(menuPick)
                    {

                        case '1':

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------- DELUXE PARKING: CHECK-IN ----------------------------");
                            Console.WriteLine();
                            Vehicle newVehicle = Helpers.GenerateRandomVehicle();
                            Console.WriteLine();
                            newVehicle.ArrivingCarInfo();
                            Thread.Sleep(2000);
                            Console.WriteLine();
                            ParkingGarage.CheckInVehicle(parkingGarage.Vehicles, newVehicle);
                            Console.WriteLine();
                            Console.Write("\tTryck för att återgå till menyn.");
                            Console.ReadKey(true);
                            break;

                        case '2':

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("---------------------------- DELUXE PARKING: CHECK-OUT ----------------------------");
                            Console.WriteLine();
                            ParkingGarage.PrintGarage(parkingGarage.Vehicles);
                            ParkingGarage.ChechOutVehicle(parkingGarage.Vehicles);
                            break;

                        case '3':

                            UI.LogOut();
                            appRunning = false;
                            break;

                        case '4':

                            appRunning = UI.CloseApp();
                            appRunning = false;
                            exitApp = true;
                            break;

                    }

                }
            }
        }
    }
}
