using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary.model;

namespace TicketSystemTest.LibraryTest
{
    [TestClass()]
    public class TicketSystemLibraryTest
    {
        /// <summary>
        /// Initializing the objects outside the methods to prevent DRY
        /// </summary>
        private Car car = new();
        private Motorcycle mc = new();

        /// <summary>
        /// This unit test will ensure the type of vehicle is car
        /// </summary>
        [TestMethod()]
        public void VehicleType_Must_Be_Car_Test()
        {
            // Arrange
            string expectedValue = "Car";                   // setting the expected value

            // Act
            string actualValue = car.VehicleType();         // we expect the actual type of vehicle to be "Car"

            // Assert
            Assert.AreEqual(expectedValue, actualValue);    // checking if the value is as expected
        }

        /// <summary>
        /// This unit test will ensure the license plate of car is 7 characters long
        /// </summary>
        /// <param name="carLicensePlate"></param>
        [TestMethod()]
        [DataRow("1234567")]
        [DataRow("ABCDEFG")]
        [DataRow("DX-203F")]
        public void Car_LisencePlate_Should_Be_Seven_Characters_ExpectedSuccess_Test(string carLicensePlate)
        {
            // Arrange


            // Act
            car.LisencePlate = carLicensePlate;             // we expect the license plate to be 7 characters long

            // Assert
            Assert.IsTrue(7 == car.LisencePlate.Length);    // checking if the vehicle has a license plate with 7 characters
        }

        /// <summary>
        /// We expect this unit test to fail, therefore we do not change assert and we implement ExpectedException
        /// </summary>
        /// <param name="licensePlate"></param>
        [TestMethod()]
        [DataRow("12345678")]
        [DataRow("38472387489327")]
        [DataRow("123")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Car_LisencePlate_Should_Be_Seven_Characters_ExpectedFail_Test(string licensePlate)
        {
            // Arrange
            Car car = new Car(licensePlate);
            // Act

            // Assert
            Assert.Fail();      
        }

        [TestMethod()]
        public void Car_Ticket_Price_Should_Be_240_Test()
        {
            // Arrange
            Car car = new Car();
            double expectedValue = 240;

            // Act
            double actualValue = car.VehicleTicketPrice();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }

        [TestMethod()]
        public void Vehicle_Must_Be_Motorcycle_Test()
        {
            // Arrange
            string expectedValue = "Motorcycle";

            // Act
            string actualValue = mc.VehicleType();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);

        }

        [TestMethod()]
        public void Motorcycle_Ticket_Price_Should_Be_125_Test()
        {
            // Arrange
            Motorcycle mc = new Motorcycle();
            double expectedValue = 125;

            // Act
            double actualValue = mc.VehicleTicketPrice();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);

        }

        [TestMethod()]
        public void Motorcycle_LicensePlate_Should_Be_Seven_Characters_Test_Success()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
