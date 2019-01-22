using NUnit.Framework;
using System.Collections.Generic;

namespace DataAccess.Test
{
    [TestFixture]
    public class DataHandlerTest
    {
       protected IDataHandler datahandler;

       [Test]   
        public void SearchByRedColorWithXml()
        {
            datahandler = new XMLDataHandler();
            List<Car> expectedResult = datahandler.SearchByRedColor();
            Assert.That(expectedResult, Has.Count.EqualTo(4));
        }

        [Test]
        public void SearchByJanosDriveWithXml()
        {
            datahandler = new XMLDataHandler();
            List<Car> expectedResult = datahandler.SearchByJanosDriver();
            Assert.That(expectedResult, Is.Not.Null.And.Not.Empty);
        }

        [Test]
        public void SearchByRedColorWithCsv()
        {
            datahandler = new CSVDataHandler();
            Car expectedResult = datahandler.SearchByRedColor()[0];
            Assert.That(expectedResult.Color, Is.EqualTo("Red"));
        }

        [Test]
        public void SearchByJanosDriverWithCsv()
        {
            datahandler = new CSVDataHandler();
            string expectedResult = datahandler.SearchByJanosDriver()[0].Driver;
            Assert.IsTrue(expectedResult.Contains("Janos"));
        }

        [Test]
        public void SearchByRedColorWithMssql()
        {
            datahandler = new DBDataHandler();
            Car expectedResult = datahandler.SearchByRedColor()[0];
            Assert.IsTrue(expectedResult.Driver.Equals("Dominic West"));
        }

        [Test]
        public void SearchByJanosDriverWithMssql()
        {
            datahandler = new DBDataHandler();
            Car expectedResult = datahandler.SearchByJanosDriver()[5];
            Assert.That(expectedResult, Is.Not.Null);
        }
    }
}
