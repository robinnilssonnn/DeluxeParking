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
    }

    internal class Car : Vehicle
    {
        public bool Electric { get; set; }

        public Car(string registrationNumber, string color, bool electric) : base(registrationNumber, color)
        {
            Electric = electric;
        }
    }

    internal class Motorcycle : Vehicle
    {
        public string Brand { get; set; }

        public Motorcycle(string registrationNumber, string color, string brand) : base(registrationNumber, color)
        {
            Brand = brand;
        }
    }

    internal class Bus : Vehicle
    {
        public int NrOfPassengers { get; set; }

        public Bus(string registrationNumber, string color, int nrOfPassengers) : base(registrationNumber, color)
        {
            NrOfPassengers = nrOfPassengers;
        }
    }
}
