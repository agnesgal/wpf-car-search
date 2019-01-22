namespace DataAccess
{
    public class DataHandlerFactory
    {
        public IDataHandler manageData(string dataPath)
        {
            if (dataPath.Equals("xml"))
            {
                return new XMLDataHandler();
            }

            else if (dataPath.Equals("csv"))
            {
               return new CSVDataHandler();
            }

            else
            {
                return new DBDataHandler();
            }
        }
    }
}
