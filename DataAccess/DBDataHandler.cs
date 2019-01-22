using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DBDataHandler : IDataHandler
    {
        public List<Car> Search(string dataPath, string descendant, string searched)
        {
            if (descendant == "Color") return SearchColor();
            else return SearchDriver();
        }


        public List<Car> SearchColor()
        {
            using (CarDBContext ctx = new CarDBContext())
            {
                return ctx.Cars.Where(s => s.Color == "Red").ToList();
            }
        }


        public List<Car> SearchDriver()
        {
            using (CarDBContext ctx = new CarDBContext())
            {
                return ctx.Cars.Where(s => s.Driver.Contains("Janos")).ToList();
            }
        }
    }
}
