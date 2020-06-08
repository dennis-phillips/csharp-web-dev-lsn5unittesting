using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        [TestInitialize]
        public void TestInitialGasTank()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            //Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestDriveMethod()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range

        [TestMethod]
        public void TestGasTankAfterExceedingRange()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.Drive(505);
            Assert.IsTrue(test_car.GasTankLevel <= 0);
        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverFillException()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }
    }
}
