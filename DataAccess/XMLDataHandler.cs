using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public class XMLDataHandler : IDataHandler
    {

        public List<Car> Search(string dataPath, string descendants, string searched)
        {
            XElement xmlFile = XElement.Load(dataPath);

            var result = xmlFile.Descendants("car")
                                .Where(c => c.Descendants(descendants).FirstOrDefault().Value.Contains(searched))
                                .Select(car => new Car(car.Descendants("Type").FirstOrDefault().Value,
                                    car.Descendants("PlateNumber").FirstOrDefault().Value,
                                    car.Descendants("Color").FirstOrDefault().Value,
                                    car.Descendants("Driver").FirstOrDefault().Value));

            return result.ToList();
        } 
    }
}
