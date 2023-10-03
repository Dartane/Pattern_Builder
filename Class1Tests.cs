using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeChecker.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void CheckPrice0ReturnFalse()
        {
            //Arrange
            int price = 0;
            bool expect = false;
            //Act
            bool act = SomeChecker.Class1.ValidatePrice(price);
            //Assert 

            Assert.AreEqual(expect, act);
        }

        [TestMethod()]
        public void CheckPriceNegReturnFalse()
        {
            //Arrange
            int price = -1;
            bool expect = false;
            //Act
            bool act = SomeChecker.Class1.ValidatePrice(price);
            //Assert 

            Assert.AreEqual(expect, act);
        }

        [TestMethod()]
        public void CheckPriceReturnTrue()
        {
            //Arrange
            int price = 5;
            bool expect = true;
            //Act
            bool act = SomeChecker.Class1.ValidatePrice(price);
            //Assert 

            Assert.AreEqual(expect, act);
        }
    }
}
