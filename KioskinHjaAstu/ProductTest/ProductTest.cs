﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KioskinHjaAstu;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestToString()
        {
            //Arrange
            Product unitTest = new Product("0.5l Pepsi Max", 18.5, true, false); 

            //Act
            string expectedValue = "Product: #1 - 0.5l Pepsi Max, 18,5kr.";
            string calculatedValue = unitTest.ToString();

            //Assert
            Assert.AreEqual(expectedValue, calculatedValue);
        }
    }
}
