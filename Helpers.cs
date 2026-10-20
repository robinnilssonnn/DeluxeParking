using System;
using System.Collections.Generic;
using System.Text;

namespace DeluxeParking
{
    internal class Helpers
    {
        public static Vehicle GenerateRandomVehicle()
        {
            string color = RandomColor();
            string regNr = RandomRegNr();
            bool electric = (Random.Shared.Next(0, 2) == 0);
            int nrOfPassengers = Random.Shared.Next(1, 50);
            string mcBrand = RandomMcBrand();

            int vehicleType = Random.Shared.Next(1, 4);
            if (vehicleType == 1)
            {
                return new Car(regNr, color, electric);
            }
            else if (vehicleType == 2)
            {
                return new Bus(regNr, color, nrOfPassengers);
            }
            else
            {
                return new Motorcycle(regNr, color, mcBrand);
            }
        }

        public static string RandomColor()
        {
            string[] colors =

                {
                    "Black",
                    "White",
                    "Silver",
                    "Grey",
                    "Red",
                    "Blue",
                    "Dark Blue",
                    "Green",
                    "Yellow",
                    "Orange",
                    "Brown",
                    "Beige",
                    "Gold",
                    "Bronze",
                    "Purple",
                    "Pink"
                };


            return colors[Random.Shared.Next(0, colors.Length)];
            
        }

        public static string RandomMcBrand()
        {
            string[] motorcycleBrands =

                    {
                        "Honda",
                        "Yamaha",
                        "Kawasaki",
                        "Suzuki",
                        "BMW",
                        "KTM",
                        "Harley-Davidson",
                        "Ducati",
                        "Triumph",
                        "Husqvarna"
                    };

            return motorcycleBrands[Random.Shared.Next(0, motorcycleBrands.Length)];
        }


        public static string RandomRegNr()
        {
            List<char> randomRegNr = new List<char>();

            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                {
                    randomRegNr.Add((char)Random.Shared.Next('A', 'Z' + 1));
                }
                else
                {
                    randomRegNr.Add((char)Random.Shared.Next('0', '9' + 1));
                }
            }

            return new string(randomRegNr.ToArray());


        }


    }
}
