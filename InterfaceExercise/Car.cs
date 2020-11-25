using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public int TrunkSize { get; set; } = 6;
        public string FuelType { get; set; } = "Gas";
        int IVehicle.NumberOfDoors { get; set; } = 4;
        string IVehicle.DriveType { get; set; } = "Automatic";
        string IVehicle.Color { get; set; } = "Black";
        string IVehicle.Model { get; set; } = "Altima";
        int IVehicle.Year { get; set; } = 2020;
        string ICompany.Name { get; set; } = "Nissan";
        double ICompany.EngineSize { get; set; } = 2.5;
    }
}
