using CleaningManagement;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTestPeople
    {
        [Fact]
        public void CustomerIssuesToStringTest()
        {
            //Arrange
            Customer issuesToTests;

            //Act
            issuesToTests = new Customer("Oli","Oli","123");
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Customer Id: {issuesToTests.Id} First Name: Oli Surname: Oli Contact Number: 123", testString);
        }

        [Fact]
        public void TeamMemberIssuesToStringTest()
        {
            //Arrange
            TeamMember issuesToTests;

            //Act
            issuesToTests = new TeamMember("Oli", "Oli", "123","UOli","123", Enums.StaffType.CLEANING_STAFF);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Staff Id: {issuesToTests.Id} First Name: Oli Surname: Oli Contact Number: 123 Username: UOli Password: 123 Position: CLEANING_STAFF", testString);
        }
    }
}