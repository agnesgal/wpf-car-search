using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataHandler
    {
        List<Car> SearchColor(string dataPath);

        List<Car> SearchDriver(string dataPath);

    }
}
