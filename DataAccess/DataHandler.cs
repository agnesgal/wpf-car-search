using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess
{
    public interface DataHandler
    {
        List<Car> SearchColor(string dataPath);

        List<Car> SearchDriver(string dataPath);

    }
}
