using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorebæltLibrary.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketLibrary.model;

namespace TicketSystemTest.LibraryTest
{
    [TestClass()]
    public class StorebæltLibraryTest
    {
        /// <summary>
        /// Initializing the vehicle objects from DLL + WeekendDiscount object
        /// </summary>
        private Car car = new();
        private Motorcycle mc = new();
        private WeekendDiscount weekendDiscount = new();


        /// <summary>
        /// This unit test will check if the discount propery deducts 20% off the ticket price for car
        /// </summary>
        [TestMethod()]
        public void Storebælt_Should_Discount_20Percent_From_Ticket_On_Weekends()
        {
            // Arrange
            double expectedValue = 192;

            // Act
            double actualValue = weekendDiscount.CarStorebæltWeekendDiscount();

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }


        /// <summary>
        /// This unit test will check if discount deducts before brobizz and they both successfully deducts
        /// </summary>
        [TestMethod()]
        public void Storebælt_WeekendDiscount_And_Brobizz()
        {
            // Arrange
            double expectedValue = 182.4;

            // Act
            double actualValue = weekendDiscount.CarStorebæltWeekendDiscount() * 0.95;

            // Assert
            Assert.AreEqual(expectedValue, actualValue, 0.01);
        }
    }
}
