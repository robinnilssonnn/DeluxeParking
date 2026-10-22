using System;
using System.Collections.Generic;
using System.Text;

namespace DeluxeParking
{
    internal class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }

        public Vehicle(string registrationNumber, string color)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
        }

        public virtual void ArrivingCarInfo()
        {
            Console.WriteLine("\tEtt fordon av okänd typ ankommer.");
        }

        public virtual void ParkedCarInfo()
        {
            Console.WriteLine($"\tBil\t{RegistrationNumber}\t{Color}\t");
        }
    }

    internal class Car : Vehicle
    {
        public bool Electric { get; set; }

        public Car(string registrationNumber, string color, bool electric) : base(registrationNumber, color)
        {
            Electric = electric;
        }

        public override void ArrivingCarInfo()
        {
            Console.WriteLine($"\tEn bil med registreringsnummer {RegistrationNumber} ankommer till parkeringen. ");
        }

        public override void ParkedCarInfo()
        {
            Console.WriteLine($"\tBil\t\t{RegistrationNumber, -15}{Color, -15}{(Electric ? "Elbil" : "Bensinbil"), -15}");
        }
    }

    internal class Motorcycle : Vehicle
    {
        public string Brand { get; set; }

        public Motorcycle(string registrationNumber, string color, string brand) : base(registrationNumber, color)
        {
            Brand = brand;
        }

        public override void ArrivingCarInfo()
        {
            Console.WriteLine($"\tEn motorcyckel med registreringsnummer {RegistrationNumber} ankommer till parkeringen. ");
        }

        public override void ParkedCarInfo()
        {
            Console.WriteLine($"\tMC\t\t{RegistrationNumber, -15}{Color, -15}" +
                $"{Brand}");
        }
    }

    internal class Bus : Vehicle
    {
        public int NrOfPassengers { get; set; }

        public Bus(string registrationNumber, string color, int nrOfPassengers) : base(registrationNumber, color)
        {
            NrOfPassengers = nrOfPassengers;
        }

        public override void ArrivingCarInfo()
        {
            Console.WriteLine($"\tEn buss med registreringsnummer {RegistrationNumber} ankommer till parkeringen. ");
        }
    

    public override void ParkedCarInfo()
        {
            Console.WriteLine($"\tBuss\t\t{RegistrationNumber, -15}{Color, -15}{NrOfPassengers} Passagerare");
        }
    }
}
