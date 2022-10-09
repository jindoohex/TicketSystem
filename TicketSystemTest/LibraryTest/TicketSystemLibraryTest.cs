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
        /// Initializing the vehicle objects to minimize DRY
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
        /// This unit test will check the license plate and expectedly fail
        /// due to parameters of license plate being outside of specified lengths
        /// and we add an ExpectedException to the method in this case
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

        /// <summary>
        /// This unit test will check if the price ticket for car is as expected: 240,-
        /// </summary>
        [TestMethod()]
        public void Car_Ticket_Price_Should_Be_240_Test()
        {
            // Arrange
            Car car = new Car();
            double expectedValue = 240;

            // Act
            double actualValue = car.VehicleTicketPrice();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);  // checking if values are correct while making sure delta only covers some decimals
        }

        /// <summary>
        /// This unit test will check if the vehicle type is of motorcycle
        /// </summary>
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

        /// <summary>
        /// This unit test will check if price ticket for motorcycle is as expected: 125,-
        /// </summary>
        [TestMethod()]
        public void Motorcycle_Ticket_Price_Should_Be_125_Test()
        {
            // Arrange

            double expectedValue = 125;

            // Act
            double actualValue = mc.VehicleTicketPrice();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);

        }

        /// <summary>
        /// This unit test will check if the license plate is the proper length and we expect it to succeed
        /// </summary>
        /// <param name="mcLicensePlate">License plate for motorcycle as string</param>
        [TestMethod()]
        [DataRow("1234567")]
        [DataRow("ABCDEFG")]
        [DataRow("DX-203F")]
        public void Motorcycle_LicensePlate_Should_Be_Seven_Characters_ExpectedSuccess_Test(string mcLicensePlate)
        {
            // Arrange


            // Act
            mc.LisencePlate = mcLicensePlate;

            // Assert
            Assert.IsTrue(7 == mc.LisencePlate.Length);

        }

        /// <summary>
        /// This unit test will check the license plate and expectedly fail
        /// due to parameters of license plate being outside of specified lengths
        /// and we add an ExpectedException to the method in this case
        /// </summary>
        /// <param name="licensePlate">License plate of the motorcycle</param>
        [TestMethod()]
        [DataRow("12345678")]
        [DataRow("38472387489327")]
        [DataRow("123")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Motorcycle_LicensePlate_Should_Be_Seven_Characters_ExpectedFail_Test(string licensePlate)
        {
            // Arrange
            Motorcycle mc = new Motorcycle(licensePlate);

            // Act


            // Assert
            Assert.Fail();

        }

        /// <summary>
        /// This unit test will check if the price is properly calculated for car with brobizz discount
        /// </summary>
        [TestMethod()]
        public void Car_Brobizz_Discount_Properly_Calculating_The_Price()
        {
            // Arrange
            double expectedValue = 228;

            // Act
            double actualValue = car.Brobizz();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }

        /// <summary>
        /// This unit test will check if the price is properly calculated for motorcycle with brobizz discount
        /// </summary>
        [TestMethod()]
        public void Motorcycle_Brobizz_Discount_Properly_Calculating_The_Price()
        {
            // Arrange
            double expectedValue = 118.75;

            // Act
            double actualValue = mc.Brobizz();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }
    }
}
