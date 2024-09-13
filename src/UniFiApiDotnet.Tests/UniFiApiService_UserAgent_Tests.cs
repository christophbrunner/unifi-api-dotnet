using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceUserAgentTests : BaseTest
{
    [Fact]
    public void SetUserAgent_ValidValue()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService();

        // Act
        uniFiApiService.SetUserAgent("myAgent");
    }

    [Fact]
    public void SetUserAgent_EmptyValue()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService();

        // Act
        void act() => uniFiApiService.SetUserAgent(string.Empty);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>((Action)act);
        Assert.Equal("userAgent (Parameter 'Value can't be empty')", exception.Message);
    }

    [Fact]
    public void SetUserAgent_InvalidValue()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService();

        // Act
        void act() => uniFiApiService.SetUserAgent("a/a/");

        // Assert
        FormatException exception = Assert.Throws<FormatException>((Action)act);
        Assert.Equal("The format of value 'a/a/' is invalid.", exception.Message);
    }
}