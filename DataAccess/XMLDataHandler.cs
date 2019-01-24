using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DataAccess
{
    public class XMLDataHandler : IDataHandler
    {
        public List<Car> SearchAllCars()
        {
            XElement xmlFile = XElement.Load(Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["XmlPath"]);

            var cars = xmlFile.Descendants("car")
                                .Select(car => new Car(car.Descendants("Type").FirstOrDefault().Value,
                                    car.Descendants("PlateNumber").FirstOrDefault().Value,
                                    car.Descendants("Color").FirstOrDefault().Value,
                                    car.Descendants("Driver").FirstOrDefault().Value));

            return cars.ToList();
        }

        public List<Car> SearchByColor(string color)
        {
            return SearchAllCars().Where(c => c.Color == color).ToList();

        }

        public List<Car> SearchByDriver(string name)
        {
            return SearchAllCars().Where(c => c.Driver.Contains(name)).ToList();
        }
    }
}
