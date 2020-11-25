using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int BedSize { get; set; } = 14;
        public string EngineType { get; set; } = "Diesel";
        int IVehicle.NumberOfDoors { get; set; } = 2;
        string IVehicle.DriveType { get; set; } = "Manual";
        string IVehicle.Color { get; set; } = "Red";
        string IVehicle.Model { get; set; } = "Silverado";
        int IVehicle.Year { get; set; } = 1995;
        string ICompany.Name { get; set; } = "Chevrolet";
        double ICompany.EngineSize { get; set; } = 7.5;
    }
}
