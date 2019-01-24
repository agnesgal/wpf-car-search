using NUnit.Framework;
using System;

namespace DataAccess.Test
{
    [TestFixture]
    public class DataHandlerFactoryTest
    {
        DataHandlerFactory dataHandlerFactory;
        XMLDataHandler xMLDataHandler;
        CSVDataHandler cSVDataHandler;
        DBDataHandler dBDataHandler;

        [OneTimeSetUp]
        public void Initialize()
        {
            dataHandlerFactory = new DataHandlerFactory();
            xMLDataHandler = new XMLDataHandler();
            cSVDataHandler = new CSVDataHandler();
            dBDataHandler = new DBDataHandler(new CarDBContext());
        }

        [Test]
        public void CreateDataHandlerByXml()
        {
            IDataHandler expectedResult = dataHandlerFactory.CreateDataHandler("xml");
            Assert.IsInstanceOf(xMLDataHandler.GetType(), expectedResult);
        }

        [Test]
        public void CreateDataHandlerByCsv()
        {
            IDataHandler expectedResult = dataHandlerFactory.CreateDataHandler("csv");
            Assert.IsInstanceOf(cSVDataHandler.GetType(), expectedResult);
        }

        [Test]
        public void CreateDataHandlerByMssql()
        {
            IDataHandler expectedResult = dataHandlerFactory.CreateDataHandler("mssql");
            Assert.IsInstanceOf(dBDataHandler.GetType(), expectedResult);
        }

        [Test]
        public void CreateDataHandlerByInvalidType()
        {
            try
            {
                dataHandlerFactory.CreateDataHandler("Invalid type");
                Assert.Fail();
            }
            catch (ArgumentException) { }
        }
    }
}
