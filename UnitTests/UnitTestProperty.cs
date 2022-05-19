using Xunit;
using CleaningManagement;

namespace UnitTests
{
    public class UnitTestProperty
    {
        [Fact]
        public void CommercialPropetyToStringTest()
        {
            //Arrange
            Commercial propertyToTests;

            //Act
            propertyToTests = new Commercial("123",123, Enums.CommercialType.OFFICE,null);
            var testString = propertyToTests.ToString();

            //Assert
            Assert.Equal($"Property Id: {propertyToTests.Id} Address: 123 Size of Property: 123 Type: OFFICE", testString);
        }
    }
}