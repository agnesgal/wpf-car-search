using NUnit.Framework;
using System.Collections.Generic;

namespace DataAccess.Test
{
    [TestFixture]
    public class DataHandlerTest
    {

        [Test]   
        public void SearchByColorByXml()
        {
            IDataHandler datahandler = new XMLDataHandler();
            List<Car> expectedResult = datahandler.SearchByColor("Red");
            Assert.That(expectedResult, Has.Count.EqualTo(4));
        }

        [Test]
        public void SearchByDriverByXml()
        {
            IDataHandler datahandler = new XMLDataHandler();
            List<Car> expectedResult = datahandler.SearchByDriver("Janos");
            Assert.That(expectedResult, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void SearchByColorByCsv()
        {
            IDataHandler datahandler = new CSVDataHandler();
            Car expectedResult = datahandler.SearchByColor("Red")[0];
            Assert.That(expectedResult.Color, !Is.EqualTo("Blue"));
        }

        [Test]
        public void SearchByDriverByCsv()
        {
            IDataHandler datahandler = new CSVDataHandler();
            string expectedResult = datahandler.SearchByDriver("Janos")[0].Driver;
            Assert.IsTrue(expectedResult.Contains("Janos"));
        }

        [Test]
        public void SearchByColorByMssql()
        {
            IDataHandler datahandler = new DBDataHandler(new CarDBContext());
            Car expectedResult = datahandler.SearchByColor("Red")[0];
            Assert.IsTrue(expectedResult.Driver.Equals("Dominic West"));
        }

        [Test]
        public void SearchByDriverByMssql()
        {
            IDataHandler datahandler = new DBDataHandler(new CarDBContext());
            Car expectedResult = datahandler.SearchByDriver("Janos")[5];
            Assert.That(expectedResult, Is.Not.Null);
        }
    }
}
