using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public string DriveType { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
