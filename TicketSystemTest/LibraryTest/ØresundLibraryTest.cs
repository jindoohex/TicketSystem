using Microsoft.VisualStudio.TestTools.UnitTesting;
using ØresundLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary.model;

namespace TicketSystemTest.LibraryTest
{
    [TestClass()]
    public class ØresundLibraryTest
    {
        /// <summary>
        /// Initializing the new objects inherited from the Vehicle class by TicketLibrary.dll
        /// </summary>
        ØresundCar øresundCar = new();
        ØresundMotorcycle øresundMotorcycle = new();

        /// <summary>
        /// This unit test will check if the VehicleType() returns the expected string of "Øresund Car"
        /// </summary>
        [TestMethod()]
        public void Renaming_VehicleType_To_ØresundCar_Properly_Test()
        {
            // Arrange
            string expectedValue = "Øresund Car";

            // Act
            string actualValue = øresundCar.VehicleType();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


        /// <summary>
        /// This unit test will check if the ticket price for car is 410
        /// </summary>
        [TestMethod()]
        public void TicketPrice_Should_Be_410_For_ØresundCar_Test()
        {
            // Arrange
            double expectedValue = 410;

            // Act
            double actualValue = øresundCar.VehicleTicketPrice();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }


        /// <summary>
        /// This unit test will check if brobizz is applied and changes the ticket price for car to 171
        /// </summary>
        [TestMethod()]
        public void Øresund_TicketPrice_With_Brobizz_Should_Be_161_For_Car_Test()
        {
            // Arrange
            double expectedValue = 161;

            // Act
            double actualValue = øresundCar.Brobizz();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }


        /// <summary>
        /// This unit test will check if the VehicleType() returns the expected string of "Øresund Motorcycle"
        /// </summary>
        [TestMethod()]
        public void Renaming_VehicleType_To_ØresundMotorcycle_Properly_Test()
        {
            // Arrange
            string expectedValue = "Øresund Motorcycle";

            // Act
            string actualValue = øresundMotorcycle.VehicleType();

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }


        /// <summary>
        /// This unit test will check if the ticket price for motorcycle is 210
        /// </summary>
        [TestMethod()]
        public void TicketPrice_Should_Be_210_For_ØresundMotorcycle_Test()
        {
            // Arrange
            double expectedValue = 210;

            // Act
            double actualValue = øresundMotorcycle.VehicleTicketPrice();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }


        /// <summary>
        /// This unit test will check if brobizz is applied and then change the ticket price for motorcycle to 73
        /// </summary>
        [TestMethod()]
        public void Øresund_TicketPrice_With_Brobizz_Should_Be_73_For_Motorcycle_Test()
        {
            // Arrange
            double expectedValue = 73;

            // Act
            double actualValue = øresundMotorcycle.Brobizz();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }
    }
}
