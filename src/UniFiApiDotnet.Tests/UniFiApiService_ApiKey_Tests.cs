using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceApiKeyTests : BaseTest
{
    [Fact]
    public async void GetData_WithoutApiKey()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService();
        uniFiApiService.ClearApiKey();

        // Act
        Task act() => uniFiApiService.GetHosts();

        // Assert
        Exception exception = await Assert.ThrowsAsync<Exception>(act);
        Assert.Equal("No API key set", exception.Message);
    }

    [Fact]
    public async void ClearApiKey()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService("myKey");

        // Act
        uniFiApiService.ClearApiKey();
        Task act() => uniFiApiService.GetHosts();

        // Assert
        Exception exception = await Assert.ThrowsAsync<Exception>(act);
        Assert.Equal("No API key set", exception.Message);
    }

    [Fact]
    public void SetApiKey_ValidKey()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService();
        uniFiApiService.ClearApiKey();

        // Act
        uniFiApiService.SetApiKey("myKey");

        // Assert
        Assert.True(uniFiApiService.HasApiKey());
    }

    [Fact]
    public void SetApiKey_SetEmpty()
    {
        // Arrange
        var uniFiApiService = new UniFiApiService();
        uniFiApiService.ClearApiKey();

        // Act
        void act() => uniFiApiService.SetApiKey(string.Empty);

        // Assert
        ArgumentException exception = Assert.Throws<ArgumentException>((Action)act);
        Assert.Equal("apiKey (Parameter 'Value can't be empty')", exception.Message);
    }
}