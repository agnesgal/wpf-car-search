using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class CSVDataHandler : IDataHandler
    {
        public List<Car> Search(string dataPath, string descendants, string searched)
        {
            string[] csvlines = File.ReadAllLines(dataPath);

            var cars = csvlines.Select(line => line.Split(';'))
                .Select(data => new Car(data[0], data[1], data[2], data[3]));

            if (descendants == "Color") return SearchColor(cars);
            else return SearchDriver(cars);
        }

        public List<Car> SearchColor(IEnumerable<Car> cars)
        {
            return cars.Where(data => data.Color.Contains("Red")).ToList();
        }

        public List<Car> SearchDriver(IEnumerable<Car> cars)
        {
            return cars.Where(data => data.Driver.Contains("Janos")).ToList();
        }
    }
}
