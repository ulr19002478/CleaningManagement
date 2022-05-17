using CleaningManagement;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTestIssues
    {
        [Fact]
        public void CosmeticIssuesToStringTest()
        {
            //Arrange
            Cosmetic issuesToTests;

            //Act
            issuesToTests = new Cosmetic("Windows Need Cleaning");
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Issue Id: {issuesToTests.Id} Cleaning Type: Windows Need Cleaning Time: {DateTime.Now}", testString);
        }

        [Fact]
        public void MajorIssuesToStringTest()
        {
            //Arrange
            Major issuesToTests;

            //Act
            issuesToTests = new Major("Fire Damage", Enums.Severity.MEDIUM);
            var testString = issuesToTests.ToString();

            //Assert
            Assert.Equal($"Issue Id: {issuesToTests.Id} Cleaning Type: Fire Damage Time: {DateTime.Now} Severity of Issue: Severity: MEDIUM", testString);
        }
    }
}