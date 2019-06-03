using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KioskinHjaAstu;

namespace UserTest
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void ValidUserNameTest()
        {
            //Arrange
            bool expectedValue = false, actualValue = true;

            //Act
            try
            {
                User testUser = new User("Janus", "Hannesarson", "januserBEst", "@");
            }
            catch
            {
                actualValue = false;
            }

            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod]
        public void ValidEmailTest()
        {
            //Arrange
            bool expectedValue = false, actualValue = true;

            //Act
            try
            {
                User testUser = new User("Janus", "Hannesarson", "januserest", "invalid?email@gma2?il.com");
            }
            catch
            {
                actualValue = false;
            }

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
