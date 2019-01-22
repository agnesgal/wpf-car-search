using NUnit.Framework;
using System.Collections.Generic;

namespace DataAccess.Test
{
    [TestFixture]
    public class XMLDataHandlerTest
    {
        [Test]   
        public void SearchByRedColor()
        {
            IDataHandler sut = new XMLDataHandler();
            List<Car> expectedResult = sut.SearchByRedColor();
            Assert.That(expectedResult, Has.Count.EqualTo(4));
        }
    }
}
