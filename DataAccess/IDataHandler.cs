using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataHandler
    {
        List<Car> SearchByColor(string color);

        List<Car> SearchByDriver(string name);
    }
}
