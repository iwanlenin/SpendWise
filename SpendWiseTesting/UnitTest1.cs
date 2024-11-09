using SpendWise.Helpers.Services;
using System.Globalization;


namespace SpendWiseTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                // Arrange
                // Get default culture
                CultureInfo culture = CultureInfo.InvariantCulture;
            // Amusing my test environment is en-DE
            String expectedString = "To test";

                //ILocalizationService localizationService = new LocalizationService();
                // Act 
                string defaultString = LocalizationService.GetString("StringForTest");

                // Assert
                Assert.Equal(expectedString, defaultString);
            

        }
    }
}