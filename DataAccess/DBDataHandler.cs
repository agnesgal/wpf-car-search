using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DBDataHandler : IDataHandler
    {
     
        public List<Car> SearchByRedColor()
        {
            using (CarDBContext ctx = new CarDBContext())
            {
                return ctx.Cars.Where(s => s.Color == "Red").ToList();
            }
        }

        public List<Car> SearchByJanosDriver()
        {
            using (CarDBContext ctx = new CarDBContext())
            {
                return ctx.Cars.Where(s => s.Driver.Contains("Janos")).ToList();
            }
        }
    }
}
