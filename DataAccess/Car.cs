using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Car
    {
        public string Type;
        public string PlateNumber;
        public string Color;
        public string Driver;

        public Car(string type, string plateNumber, string color, string driver)
        {
            Type = type;
            PlateNumber = plateNumber;
            Color = color;
            Driver = driver;
        }
    }
}
