using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;

namespace DataAccess
{
    public class XMLDataHandler : IDataHandler
    {
        public List<Car> SearchAllCars()
        {
            XElement xmlFile = XElement.Load(@"C:\Users\Codecool\source\repos\WpfApp1\DataAccess\Resources\XMLFile1.xml");

            var cars = xmlFile.Descendants("car")
                                .Select(car => new Car(car.Descendants("Type").FirstOrDefault().Value,
                                    car.Descendants("PlateNumber").FirstOrDefault().Value,
                                    car.Descendants("Color").FirstOrDefault().Value,
                                    car.Descendants("Driver").FirstOrDefault().Value));

            return cars.ToList();
        }

        public List<Car> SearchByRedColor()
        {
            return SearchAllCars().Where(c => c.Color == "Red").ToList();

        }

        public List<Car> SearchByJanosDriver()
        {
            return SearchAllCars().Where(c => c.Driver.Contains("Janos")).ToList();
        }
    }
}
