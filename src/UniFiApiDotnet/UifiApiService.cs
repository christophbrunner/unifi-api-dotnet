using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using UniFiApiDotnet.Abstraction;
using UniFiApiDotnet.JsonConverter;
using UniFiApiDotnet.Models.Dto;
using Host = UniFiApiDotnet.Models.Dto.Host;
using UniFiApiDotnet.Models;

namespace UniFiApiDotnet
{
    public class UniFiApiService : IUniFiApiService
    {
        internal static string UserAgent =
            $"UniFiApiDotnet/{System.Reflection.Assembly.GetAssembly(typeof(UniFiApiService)).GetName().Version}";

        internal static string ApiKey = string.Empty;
        internal static string ConfigSectionName = "UniFiApi";
        internal static string HttpClientFactoryClientName = Options.DefaultName;
        private readonly ILogger? _logger;

        public const string BaseAddress = "https://api.ui.com/";

        private const string HttpHeaderApiKeyName = "X-API-KEY";

        private readonly JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters =
            {
                new NullableDateTimeConverter(),
                new GenericInterfaceConverter<IDevices, Devices>(),
                new GenericInterfaceConverter<IUiDb, UiDb>(),
                new GenericInterfaceConverter<IImage, Image>(),
                new GenericInterfaceConverter<IUserData, UserData>(),
                new GenericInterfaceConverter<IReportedState, ReportedState>(),
                new GenericInterfaceConverter<IRoleAttributes, RoleAttributes>(),
                new GenericInterfaceConverter<IConsoleGroupMember, ConsoleGroupMember>(),
                new GenericInterfaceConverter<IApplicationRoleAttributes,
                    ApplicationRoleAttributes>(),
                new GenericInterfaceConverter<IApplicationRoleAttributeDetails
                    , ApplicationRoleAttributeDetails>(),
                new GenericInterfaceConverter<IUserDataFeatures, UserDataFeatures>(),
                new GenericInterfaceConverter<IUserDataFeatureFloorPlan,
                    UserDataFeatureFloorPlan>(),
                new GenericInterfaceConverter<IUserDataFeatureWebRtc, UserDataFeatureWebRtc>(),
                new GenericInterfaceConverter<IUserDataPermissions, UserDataPermissions>(),
                new GenericInterfaceConverter<IApp, App>(),
                new GenericInterfaceConverter<IReportedStateFeatures, ReportedStateFeatures>(),
                new GenericInterfaceConverter<IReportedStateFeaturesCloud,
                    ReportedStateFeaturesCloud>(),
                new GenericInterfaceConverter<IReportedStateFeaturesDeviceList
                    , ReportedStateFeaturesDeviceList>(),
                new GenericInterfaceConverter<IReportedStateFeaturesInfoApis,
                    ReportedStateFeaturesInfoApis>(),
                new GenericInterfaceConverter<IReportedStateFirmwareUpdate,
                    ReportedStateFirmwareUpdate>(),
                new GenericInterfaceConverter<IReportedStateHardware, ReportedStateHardware>(),
                new GenericInterfaceConverter<ILocation, Location>(),
                new GenericInterfaceConverter<IController, Controller>(),
                new GenericInterfaceConverter<IUnAdoptedDevicesAddress, UnAdoptedDevicesAddress>(),
                new GenericInterfaceConverter<IUnAdoptedDevice, UnAdoptedDevice>(),
                new GenericInterfaceConverter<IControllerFeatures, ControllerFeatures>(),
                new GenericInterfaceConverter<IControllerApp, ControllerApp>(),
                new GenericInterfaceConverter<IInternetIssues, InternetIssues>(),
                new GenericInterfaceConverter<ISiteInternetIssuesPeriod, SiteInternetIssuesPeriod>(),
                new GenericInterfaceConverter<IHostInternetIssuesPeriod, HostInternetIssuesPeriod>(),
                new GenericInterfaceConverter<IReportedStateUi, ReportedStateUi>(),
                new GenericInterfaceConverter<ISiteStatistics, SiteStatistics>(),
                new GenericInterfaceConverter<ISiteStatisticsCounts, SiteStatisticsCounts>(),
                new GenericInterfaceConverter<ISiteMeta, SiteMeta>(),
                new GenericInterfaceConverter<ISiteStatisticsIspInfo, SiteStatisticsIspInfo>(),
                new GenericInterfaceConverter<ISiteStatisticsPercentages, SiteStatisticsPercentages>(),
                new GenericInterfaceConverter<IReportedStateFeatureUpdates, ReportedStateFeatureUpdates>(),
                new GenericInterfaceConverter<IAutoUpdate, AutoUpdate>(),
                new GenericInterfaceConverter<IUpdateSchedule, UpdateSchedule>(),
                new GenericInterfaceConverter<IAutoUpdatePreferencesPromptUnifiOs, AutoUpdatePreferencesPromptUnifiOs>()
            }
        };

        private readonly HttpClient? _httpClient;

        #region Constructor

        public UniFiApiService()
        {
            _httpClient = new HttpClient();
        }

        public UniFiApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public UniFiApiService(string apiKey)
        {
            _httpClient = new HttpClient();
            SetApiKey(apiKey);
        }

        public UniFiApiService(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            SetApiKey(apiKey);
        }

        public UniFiApiService(IServiceProvider serviceProvider, ILogger<UniFiApiService> logger,
            IConfiguration configuration)
        {
            _logger = logger;

            var config = configuration.GetSection(ConfigSectionName).Get<UniFiApiConfiguration>();

            if (config != null)
            {
                //Set the api key from the configuration
                if (!string.IsNullOrEmpty(config.ApiKey) //check, if the config has a api key
                    && string.IsNullOrEmpty(ApiKey)) //check, if the api key is not already set
                {
                    SetApiKey(config.ApiKey);
                }

                //Set the user agent from the configuration
                if (!string.IsNullOrEmpty(config.UserAgent))
                {
                    UserAgent = config.UserAgent;
                }

                //Set the HttpClientFactoryClientName from the configuration
                if (!string.IsNullOrEmpty(config.HttpClientFactoryClientName))
                {
                    HttpClientFactoryClientName = config.HttpClientFactoryClientName;
                }
            }

            _httpClient = serviceProvider.GetService<IHttpClientFactory>()?.CreateClient(HttpClientFactoryClientName);

            if (_httpClient == null)
            {
                _logger.LogInformation("Create new HttpClient");
                _httpClient = new HttpClient();
            }
        }

        #endregion

        #region HttpClient

        private HttpClient GetHttpClient()
        {
            if (_httpClient == null)
            {
                throw new Exception("HttpClient is null");
            }

            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = new Uri(BaseAddress);
            }

            if (!_httpClient.DefaultRequestHeaders.Accept.Any())
            {
                _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }

            if (!_httpClient.DefaultRequestHeaders.UserAgent.Any())
            {
                _httpClient.DefaultRequestHeaders.Add("User-Agent", UserAgent);
            }

            if (!_httpClient.DefaultRequestHeaders.Contains(HttpHeaderApiKeyName))
            {
                _httpClient.DefaultRequestHeaders.Add(HttpHeaderApiKeyName, GetApiKey());
            }

            return _httpClient;
        }

        #endregion

        #region ApiKey

        public void SetApiKey(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
            {
                throw new ArgumentException(nameof(apiKey), "Value can't be empty");
            }

            _logger?.LogDebug("UniFiApi API key set");
            _httpClient?.DefaultRequestHeaders.Remove(HttpHeaderApiKeyName);
            ApiKey = apiKey;
        }

        public bool HasApiKey()
        {
            return !string.IsNullOrEmpty(ApiKey);
        }

        public void ClearApiKey()
        {
            _logger?.LogDebug("UniFiApi API key cleared");
            _httpClient?.DefaultRequestHeaders.Remove(HttpHeaderApiKeyName);
            ApiKey = string.Empty;
        }

        private string GetApiKey()
        {
            if (string.IsNullOrEmpty(ApiKey))
            {
                throw new Exception("No API key set");
            }

            return ApiKey;
        }

        #endregion

        #region UserAgent

        public void SetUserAgent(string userAgent)
        {
            if(string.IsNullOrWhiteSpace(userAgent))
            {
                throw new ArgumentException(nameof(userAgent), "Value can't be empty");
            }

            _httpClient?.DefaultRequestHeaders.UserAgent.Clear();
            _httpClient?.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
            UserAgent = userAgent;
        }

        #endregion

        #region GetHosts

        public async Task<IEnumerable<IHost>> GetHosts()
        {
            return await GetHosts(CancellationToken.None);
        }

        public async Task<IEnumerable<IHost>> GetHosts(CancellationToken cancellationToken)
        {
            return await GetData<IEnumerable<Host>>("ea/hosts", cancellationToken);
        }

        #endregion

        #region GetHostById

        public async Task<IHost> GetHostById(string id)
        {
            return await GetHostById(id, CancellationToken.None);
        }

        public async Task<IHost> GetHostById(string id, CancellationToken cancellationToken)
        {
            return await GetData<Host>($"ea/hosts/{id}", cancellationToken);
        }

        #endregion

        #region GetSites

        public async Task<IEnumerable<ISite>> GetSites()
        {
            return await GetSites(CancellationToken.None);
        }

        public async Task<IEnumerable<ISite>> GetSites(CancellationToken cancellationToken)
        {
            return await GetData<IEnumerable<Site>>("ea/sites", cancellationToken);
        }

        #endregion

        #region GetDevices

        public async Task<IEnumerable<IHostDeviceInfo>> GetDevices(string[]? hostIds = null, DateTime? time = null)
        {
            return await GetDevices(CancellationToken.None, hostIds, time);
        }

        public async Task<IEnumerable<IHostDeviceInfo>> GetDevices(CancellationToken cancellationToken,
            string[]? hostIds = null, DateTime? time = null)
        {
            string endpoint = "ea/devices?";

            if (hostIds != null && hostIds.Any())
            {
                endpoint += $"hostIds[]={string.Join(",", hostIds)}&";
            }

            if (time != null)
            {
                endpoint += $"time={time.Value:yyyy-MM-ddTHH:mm:ssZ}";
            }

            return await GetData<IEnumerable<HostDeviceInfo>>(endpoint, cancellationToken);
        }

        #endregion

        private async Task<T> GetData<T>(string endpoint, CancellationToken cancellationToken)
        {
            HttpResponseMessage? response = null;
            try
            {
                _logger?.LogDebug($"Requesting {endpoint}");

                response = await GetHttpClient().GetAsync(endpoint, cancellationToken);
                _logger?.LogDebug($"Response status code: {response.StatusCode}");
                response.EnsureSuccessStatusCode();
                var responseStream = await response.Content.ReadAsStreamAsync();

                if (responseStream == null)
                {
                    throw new Exception("GenericApiResponse stream is null");
                }

                var result = await JsonSerializer.DeserializeAsync<GenericApiResponse<T>>(responseStream,
                    _jsonSerializerOptions, cancellationToken);

                if (result == null)
                {
                    throw new Exception("Deserialization failed");
                }

                return result.Data;
            }
            catch (HttpRequestException ex)
            {
                var error = await ReadError(response);

                UnifiApiException apiException = new UnifiApiException(
                    $"API Error | {(int)error.HttpStatusCode} ({error.HttpStatusCode}) | {error.Code} | {error.Message} | TraceId: {error.TraceId}",
                    ex);

                apiException.Data.Add("Error", error);

                _logger?.LogError(apiException, "Error on UnifiApi");

                throw apiException;
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "Error on {Caller}", nameof(GetData));
                throw;
            }
        }

        private async Task<BaseResponse> ReadError(HttpResponseMessage? response)
        {
            if (response == null)
            {
                return new BaseResponse()
                {
                    Code = "Unknown - No response",
                    HttpStatusCode = HttpStatusCode.BadRequest,
                    Message = "No response data",
                    TraceId = "Unknown"
                };
            }

            var errorStream = await response.Content.ReadAsStreamAsync();
            if (errorStream == null)
            {
                return new BaseResponse()
                {
                    Code = "Unknown - No error stream",
                    HttpStatusCode = response.StatusCode,
                    Message = "No error stream",
                    TraceId = "Unknown"
                };
            }
            else
            {
                BaseResponse? error = null;
                try
                {
                    error = await JsonSerializer.DeserializeAsync<BaseResponse?>(errorStream,
                        _jsonSerializerOptions);
                }
                catch
                {
                    //other Error
                }

                if (error == null)
                {
                    return new BaseResponse()
                    {
                        Code = "Unknown - Error stream deserialization failed",
                        HttpStatusCode = response.StatusCode,
                        Message = "Error stream deserialization failed",
                        TraceId = "Unknown"
                    };
                }
                else
                {
                    return error;
                }
            }
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}