using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class CSVDataHandler : IDataHandler
    {
        public List<Car> SearchColor(string dataPath)
        {
            string[] csvlines = File.ReadAllLines(dataPath);

            var redCars = csvlines.Select(line => line.Split(';'))
                .Select(data => new Car(data[0], data[1], data[2], data[3]))
                .Where(c => c.Color == "Red").ToList();

            return redCars;
        }


        public List<Car> SearchDriver(string dataPath)
        {
            string[] csvlines = File.ReadAllLines(dataPath);

            var driverCars = csvlines.Select(line => line.Split(';'))
                .Select(data => new Car(data[0], data[1], data[2], data[3]))
                .Where(c => c.Driver.Contains("Janos")).ToList();

            return driverCars;
        }
    }
}
