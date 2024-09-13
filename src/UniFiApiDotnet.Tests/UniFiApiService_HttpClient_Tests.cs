using System.Net;
using System.Text.Json;
using UniFiApiDotnet.Models.Dto;
using Xunit;

namespace UniFiApiDotnet.Tests;

public class UniFiApiServiceHttpClientTests : BaseTest
{
    [Fact]
    public async void GetHosts_BadRequest_InvalidResponse_Message()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService(string.Empty, HttpStatusCode.BadRequest);

        // Act
        Task act() => uniFiApiService.GetHosts();

        // Assert
        UnifiApiException exception = await Assert.ThrowsAsync<UnifiApiException>(act);
        Assert.Equal(
            "API Error | 400 (BadRequest) | Unknown - Error stream deserialization failed | Error stream deserialization failed | TraceId: Unknown",
            exception.Message);
    }

    [Fact]
    public async void UniFiApiService_Dispose()
    {
        // Arrange
        var httpClient = new HttpClient();
        var uniFiApiService = new UniFiApiService(httpClient);

        // Act
        uniFiApiService.Dispose();

        // Assert
        await Assert.ThrowsAsync<ObjectDisposedException>(() => uniFiApiService.GetHosts());
    }

    [Fact]
    public async void GetHosts_BadRequest_Response_Message()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Errors/Unauthorized.json", HttpStatusCode.BadRequest);

        // Act
        Task act() => uniFiApiService.GetHosts();

        // Assert
        UnifiApiException exception = await Assert.ThrowsAsync<UnifiApiException>(act);
        Assert.Equal(
            "API Error | 401 (Unauthorized) | unauthorized | unauthorized | TraceId: a7dc15e0eb4527142d7823515b15f87d",
            exception.Message);
    }

    [Fact]
    public async void GetHosts_BadRequest_Response_Data()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Errors/Unauthorized.json", HttpStatusCode.BadRequest);

        // Act
        Task act() => uniFiApiService.GetHosts();

        // Assert
        UnifiApiException exception = await Assert.ThrowsAsync<UnifiApiException>(act);
        Assert.Single(exception.Data);
        Assert.NotNull(exception.Data["Error"]);
        Assert.IsType<BaseResponse>(exception.Data["Error"]);

        var errorObj = exception.Data["Error"];

        Assert.IsType<BaseResponse>(errorObj);

        var error = errorObj as BaseResponse;

        Assert.NotNull(error);
        Assert.Equal("unauthorized", error.Code);
        Assert.Equal(HttpStatusCode.Unauthorized, error.HttpStatusCode);
        Assert.Equal("unauthorized", error.Message);
        Assert.Equal("a7dc15e0eb4527142d7823515b15f87d", error.TraceId);
    }

    [Fact]
    public async void GetData_NoValidJsonResponse()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService("Errors/Invalid.json");

        // Act
        Task act() => uniFiApiService.GetHosts();

        // Assert
        JsonException exception = await Assert.ThrowsAsync<JsonException>(act);
    }

    [Fact]
    public async void GetData_BadRequest_InvalidResponse_InnerException()
    {
        // Arrange
        var uniFiApiService = GetUniFiApiService(string.Empty, HttpStatusCode.BadRequest);

        // Act
        Task act() => uniFiApiService.GetHosts();

        // Assert
        UnifiApiException exception = await Assert.ThrowsAsync<UnifiApiException>(act);

        Assert.NotNull(exception.InnerException);
        Assert.IsType<HttpRequestException>(exception.InnerException);
    }
}