using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Test
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void TestSumaCincoMasDos()
        {
            //Patron AAA

            //Arrange
            ApplicationCore.Services.Sum sum = new ApplicationCore.Services.Sum();
            int num1 = 5;
            int num2 = 2;

            //Act
            var result = sum.SumValues(num1, num2);

            //Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Patron AAA

            //Arrange
            ApplicationCore.Services.Sum sum = new ApplicationCore.Services.Sum();
            int num1 = 5;
            int num2 = 2;

            //Act
            var result = sum.SumValues(num1, num2);

            //Assert
            Assert.AreEqual(7, result);
        }
    }
}
