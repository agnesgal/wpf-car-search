using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataHandler
    {
        List<Car> Search(string dataPath, string descendant, string searched);
    }
}
