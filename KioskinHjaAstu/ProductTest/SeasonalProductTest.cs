using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KioskinHjaAstu;

namespace ProductTest
{
    [TestClass]
    public class SeasonalProductTest
    {
        [TestMethod]
        public void TestToString()
        {
            //Arrange
            SeasonalProduct unitTest = new SeasonalProduct("AAU Lan Party Ticket", 200, true, true, new DateTime(2019, 6, 20, 0, 0, 0));

            //Act
            string expectedValue = "SeasonalProduct: #1 - AAU Lan Party Ticket, 200kr. - Expiration date: 20-06-2019 00:00:00";
            string calculatedValue = unitTest.ToString();

            //Assert
            Assert.AreEqual(expectedValue, calculatedValue);
        }
    }
}
