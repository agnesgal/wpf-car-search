using System;

namespace DataAccess
{
    public class DataHandlerFactory
    {
        public IDataHandler CreateDataHandler(string dataSourceType)
        {
            if (dataSourceType.Equals("xml"))
            {
                return new XMLDataHandler();
            }

            else if (dataSourceType.Equals("csv"))
            {
               return new CSVDataHandler();
            }

            else if (dataSourceType.Equals("mssql"))
            {
                return new DBDataHandler(new CarDBContext());
            }

            else
            {
                throw new ArgumentException("Not a valid data resource.");
            }
        }
    }
}
