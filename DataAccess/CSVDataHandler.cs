using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess
{
    public class CSVDataHandler : IDataHandler
    {
        public IEnumerable<Car> SearchAllCars()
        {
            string[] csvlines = File.ReadAllLines(@"C:\Users\Codecool\source\repos\WpfApp1\DataAccess\Resources\CSVFile.csv");

            var cars = csvlines.Select(line => line.Split(';'))
                .Select(data => new Car(data[0], data[1], data[2], data[3]));

            return cars;
        }

        public List<Car> SearchByRedColor()
        {
            return SearchAllCars().Where(data => data.Color.Contains("Red")).ToList();
        }

        public List<Car> SearchByJanosDriver()
        {
            return SearchAllCars().Where(data => data.Driver.Contains("Janos")).ToList();
        }
    }
}
