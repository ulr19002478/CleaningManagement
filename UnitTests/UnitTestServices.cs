using CleaningManagement;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTestServices
    {
        [Fact]
        public void ServicesIssuesToStringTest()
        {
            //Arrange
            Services issuesToTests;

            //Act
            issuesToTests = new Services("Test", true);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Service Id: {issuesToTests.Id} Details: Test Date Started: {DateTime.Now} Date Ended: {DateTime.Now}", testString);
        }

        [Fact]
        public void BookingsIssuesToStringTest()
        {
            //Arrange
            Bookings issuesToTests;

            //Act
            issuesToTests = new Bookings("Test", null);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Issue Id: {issuesToTests.Id} Details: Test Time of booking: {DateTime.Now}", testString);
        }

        [Fact]
        public void PurchasesIssuesToStringTest()
        {
            //Arrange
            Purchases issuesToTests;

            //Act
            issuesToTests = new Purchases("Test","Test", 9.55, null);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Item Id: {issuesToTests.Id} Item Name: Test Item Description: Test Cost: £9.55 Date Created: {DateTime.Now}", testString);
        }
    }
}

