using CleaningManagement;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTestProperties
    {
        [Fact]
        public void CommercialIssuesToStringTest()
        {
            //Arrange
            Commercial issuesToTests;

            //Act
            issuesToTests = new Commercial("123",5, Enums.CommercialType.OFFICE);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Property Id: {issuesToTests.Id}  Address: 123 Size of Property: 5 Type: OFFICE", testString);
        }
        [Fact]
        public void DomesticIssuesToStringTest()
        {
            //Arrange
            Domestic issuesToTests;

            //Act
            issuesToTests = new Domestic("123",5,Enums.DomesticType.COTTAGE);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Propety Id: {issuesToTests.Id}  Address: 123 Number of Rooms: 5 Type: COTTAGE", testString);
        }
    }
}