using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataHandler
    {
        List<Car> SearchByRedColor();

        List<Car> SearchByJanosDriver();

    }
}
