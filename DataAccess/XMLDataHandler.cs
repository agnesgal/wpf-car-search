using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class XMLDataHandler : DataHandler
    {

        public List<Car> SearchColor(string dataPath)
        {
            XElement xmlFile = XElement.Load(dataPath);

            var result = xmlFile.Descendants("car")
                                .Where(c => c.Descendants("Color").FirstOrDefault().Value == "red")
                                .Select(car => new Car(car.Descendants("Type").FirstOrDefault().Value, car.Descendants("PlateNumber").FirstOrDefault().Value, car.Descendants("Color").FirstOrDefault().Value, car.Descendants("Driver").FirstOrDefault().Value));

            return result.ToList();
        }

        public List<Car> SearchDriver(string dataPath)
        {
            XElement xmlFile = XElement.Load(dataPath);

            var result = xmlFile.Descendants("car")
                                .Where(c => c.Descendants("Driver").FirstOrDefault().Value.Contains("Janos"))
                                .Select(car => new Car(car.Descendants("Type").FirstOrDefault().Value, car.Descendants("PlateNumber").FirstOrDefault().Value, car.Descendants("Color").FirstOrDefault().Value, car.Descendants("Driver").FirstOrDefault().Value));
            
            return result.ToList();
        }
    }
}
