namespace DeluxeParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = new ParkingGarage(15); // Skapar ett parkeringsgarage som har 15 platser och tar Vehicle-objekt

            while (true)
            {

                //UI.PrintLogInPage();
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

                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                }
            }

        }
    }
}
