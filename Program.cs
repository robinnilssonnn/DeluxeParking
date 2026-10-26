using System.Diagnostics.Metrics;

namespace DeluxeParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = new ParkingGarage(15); 

            // bool-variabler som hanterar inloggning samt nedstägning av applikationen
            bool appRunning = true;
            bool exitApp = false;

            while(!exitApp)
            {

                UI.PrintLogInPage();
                appRunning = true;

                while(appRunning)
                {

                    // Skriv ut översikten + menyn och returnera användarens menyval som en char
                    char menuPick = UI.PrintMenu(parkingGarage.Vehicles);
 

                    switch(menuPick)
                    {

                        case '1':

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------- DELUXE PARKING: CHECK-IN ---------------------------------------------");
                            Console.WriteLine();
                            // Slumpa fram ett ankommande fordon-objekt
                            Vehicle newVehicle = Helpers.GenerateRandomVehicle();
                            Console.WriteLine();
                            // Skriv ut vilket fordon som kommer till parkeringen
                            newVehicle.ArrivingCarInfo();
                            Thread.Sleep(2000);
                            Console.WriteLine();
                            // Checka in fordonet på passande plats beroende på fordonstyp om det finns plats och lagra ankomsttiden
                            ParkingGarage.CheckInVehicle(parkingGarage.Vehicles, newVehicle);
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("\tTryck för att återgå till menyn.");
                            Console.ReadKey(true);
                            break;

                        case '2':

                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("--------------------------------------------- DELUXE PARKING: CHECK-OUT --------------------------------------------");
                            Console.WriteLine();
                            ParkingGarage.PrintGarage(parkingGarage.Vehicles);
                            // Be användaren ange reg nr på fordonet som ska checkas ut och skriv ut kostnaden. Meddela användaren vid ogiltig/icke-existerande reg nr
                            ParkingGarage.ChechOutVehicle(parkingGarage.Vehicles);
                            break;

                        case '3':
                            continue;

                        case '4':

                            //appRunning = false hoppar ur inre loopen och tillbaka till inloggning
                            appRunning = UI.LogOut();
                            break;

                        case '5':

                            //exitApp = true och appRunning = false gör att programmet hoppar ur båda loopar och avslutas
                            exitApp = UI.CloseApp();
                            appRunning = false;
                            break;

                    }
                }
            }
        }
    }
}
