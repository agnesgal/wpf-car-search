using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class DBDataHandler : IDataHandler
    {
        private CarDBContext carDBContext { get; set; }

        public DBDataHandler(CarDBContext carDBContext) { this.carDBContext = carDBContext; }

        public List<Car> SearchByColor(string color)
        {
            {
                return carDBContext.Cars.Where(s => s.Color == color).ToList();
            }
        }

        public List<Car> SearchByDriver(string name)
        {
            {
                return carDBContext.Cars.Where(s => s.Driver.Contains(name)).ToList();
            }
        }
    }
}
