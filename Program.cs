namespace DeluxeParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingGarage parkingGarage = new ParkingGarage(15); // Skapar ett parkeringsgarage som har 15 platser och tar Vehicle-objekt
            UI.PrintLogInPage(); // Skriver ut log-in sidan och kräver rätt användarnamn/lösenord
            int menuPick = UI.PrintMenu(); // Skriver ut menyn och levererar ett menyval i form av en int

            switch(menuPick)
            {

                case 1:
                    ParkingGarage.PrintGarage(parkingGarage.Vehicles);
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
