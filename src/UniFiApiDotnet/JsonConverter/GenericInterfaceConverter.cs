using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;
using UniFiApiDotnet.Models.Dto;

namespace UniFiApiDotnet.JsonConverter
{
    internal class DeviceConverter : GenericInterfaceConverter<IDevices, Devices>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class UiDbConverter : GenericInterfaceConverter<IUiDb, UiDb>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ImageConverter : GenericInterfaceConverter<IImage, Image>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class UserDataConverter : GenericInterfaceConverter<IUserData, UserData>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ReportedStateConverter : GenericInterfaceConverter<IReportedState, ReportedState>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class RoleAttributesConverter : GenericInterfaceConverter<IRoleAttributes, RoleAttributes>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ConsoleGroupMemberConverter : GenericInterfaceConverter<IConsoleGroupMember, ConsoleGroupMember>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ApplicationRoleAttributesConverter : GenericInterfaceConverter<IApplicationRoleAttributes,
        ApplicationRoleAttributes>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ApplicationRoleAttributeDetailsConverter : GenericInterfaceConverter<IApplicationRoleAttributeDetails
        , ApplicationRoleAttributeDetails>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class UserDataFeaturesConverter : GenericInterfaceConverter<IUserDataFeatures, UserDataFeatures>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class UserDataFeatureFloorPlanConverter : GenericInterfaceConverter<IUserDataFeatureFloorPlan,
        UserDataFeatureFloorPlan>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class
        UserDataFeatureWebrtcConverter : GenericInterfaceConverter<IUserDataFeatureWebRtc, UserDataFeatureWebRtc>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class UserDataPermissionsConverter : GenericInterfaceConverter<IUserDataPermissions, UserDataPermissions>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class AppConverter : GenericInterfaceConverter<IApp, App>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class
        ReportedStateFeaturesConverter : GenericInterfaceConverter<IReportedStateFeatures, ReportedStateFeatures>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class
        ReportedStateFeaturesCloudConverter : GenericInterfaceConverter<IReportedStateFeaturesCloud,
        ReportedStateFeaturesCloud>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ReportedStateFeaturesDeviceListConverter : GenericInterfaceConverter<IReportedStateFeaturesDeviceList
        , ReportedStateFeaturesDeviceList>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ReportedStateFeaturesInfoApisConverter : GenericInterfaceConverter<IReportedStateFeaturesInfoApis,
        ReportedStateFeaturesInfoApis>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class
        ReportedStateFirmwareUpdateConverter : GenericInterfaceConverter<IReportedStateFirmwareUpdate,
        ReportedStateFirmwareUpdate>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class
        ReportedStateHardwareConverter : GenericInterfaceConverter<IReportedStateHardware, ReportedStateHardware>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class LocationConverter : GenericInterfaceConverter<ILocation, Location>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ControllerConverter : GenericInterfaceConverter<IController, Controller>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class
        UnAdoptedDevicesAddressConverter : GenericInterfaceConverter<IUnAdoptedDevicesAddress, UnAdoptedDevicesAddress>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class UnAdoptedDeviceConverter : GenericInterfaceConverter<IUnAdoptedDevice, UnAdoptedDevice>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class ControllerFeaturesConverter : GenericInterfaceConverter<IControllerFeatures, ControllerFeatures>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }  
    
    internal class ControllerAppConverter : GenericInterfaceConverter<IControllerApp, ControllerApp>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }  
    
    internal class InternetIssuesPeriodConverter : GenericInterfaceConverter<IInternetIssuesPeriod, InternetIssuesPeriod>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class InternetIssuesConverter : GenericInterfaceConverter<IInternetIssues, InternetIssues>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    } 
    
    internal class ReportedStateUiConverter : GenericInterfaceConverter<IReportedStateUi, ReportedStateUi>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }  
    
    internal class SiteStatisticsConverter : GenericInterfaceConverter<ISiteStatistics, SiteStatistics>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    } 
    
    internal class SiteStatisticsCountsConverter : GenericInterfaceConverter<ISiteStatisticsCounts, SiteStatisticsCounts>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }   
    
    internal class SiteMetaConverter : GenericInterfaceConverter<ISiteMeta, SiteMeta>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }   
    
    internal class SiteStatisticsIspInfoConverter : GenericInterfaceConverter<ISiteStatisticsIspInfo, SiteStatisticsIspInfo>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal class SiteStatisticsPercentagesConverter : GenericInterfaceConverter<ISiteStatisticsPercentages, SiteStatisticsPercentages>
    {
        protected override JsonTokenType TokenType => JsonTokenType.StartObject;
    }

    internal abstract class GenericInterfaceConverter<TInterface, TInstance> : JsonConverter<TInterface>
        where TInstance : TInterface, new() where TInterface : class
    {
        protected abstract JsonTokenType TokenType { get; }

        public override TInterface? Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options)
        {
            if (reader.TokenType == TokenType)
            {

                return JsonSerializer.Deserialize<TInstance>(ref reader, options) as TInterface;
            }

            return new TInstance();
        }

        public override void Write(Utf8JsonWriter writer, TInterface value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}