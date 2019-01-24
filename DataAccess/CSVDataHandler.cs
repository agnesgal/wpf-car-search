using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class CSVDataHandler : IDataHandler
    {
        public IEnumerable<Car> SearchAllCars()
        {
            string[] csvlines = File.ReadAllLines(Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["CsvPath"]);

            var cars = csvlines.Select(line => line.Split(';'))
                .Select(data => new Car(data[0], data[1], data[2], data[3]));

            return cars;
        }

        public List<Car> SearchByColor(string color)
        {
            return SearchAllCars().Where(data => data.Color.Contains(color)).ToList();
        }

        public List<Car> SearchByDriver(string name)
        {
            return SearchAllCars().Where(data => data.Driver.Contains(name)).ToList();
        }
    }
}
