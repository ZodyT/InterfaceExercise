using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int CargoSize { get; set; } = 6;
        public string DriveTrain { get; set; } = "4x4";
        int IVehicle.NumberOfDoors { get; set; } = 4;
        string IVehicle.DriveType { get; set; } = "Automatic";
        string IVehicle.Color { get; set; } = "White";
        string IVehicle.Model { get; set; } = "Highlander";
        int IVehicle.Year { get; set; } = 2015;
        string ICompany.Name { get; set; } = "Toyota";
        double ICompany.EngineSize { get; set; } = 4.5;
    }
}
