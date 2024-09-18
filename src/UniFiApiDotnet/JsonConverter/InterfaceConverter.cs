using UniFiApiDotnet.Abstraction;
using UniFiApiDotnet.Models.Dto;

namespace UniFiApiDotnet.JsonConverter
{
    internal class DeviceConverter : GenericInterfaceConverter<IDevices, Devices>
    {
    }

    internal class UiDbConverter : GenericInterfaceConverter<IUiDb, UiDb>
    {
    }

    internal class ImageConverter : GenericInterfaceConverter<IImage, Image>
    {
    }

    internal class UserDataConverter : GenericInterfaceConverter<IUserData, UserData>
    {
    }

    internal class ReportedStateConverter : GenericInterfaceConverter<IReportedState, ReportedState>
    {
    }

    internal class RoleAttributesConverter : GenericInterfaceConverter<IRoleAttributes, RoleAttributes>
    {
    }

    internal class ConsoleGroupMemberConverter : GenericInterfaceConverter<IConsoleGroupMember, ConsoleGroupMember>
    {
    }

    internal class ApplicationRoleAttributesConverter : GenericInterfaceConverter<IApplicationRoleAttributes,
        ApplicationRoleAttributes>
    {
    }

    internal class ApplicationRoleAttributeDetailsConverter : GenericInterfaceConverter<IApplicationRoleAttributeDetails
        , ApplicationRoleAttributeDetails>
    {
    }

    internal class UserDataFeaturesConverter : GenericInterfaceConverter<IUserDataFeatures, UserDataFeatures>
    {
    }

    internal class UserDataFeatureFloorPlanConverter : GenericInterfaceConverter<IUserDataFeatureFloorPlan,
        UserDataFeatureFloorPlan>
    {
    }

    internal class
        UserDataFeatureWebrtcConverter : GenericInterfaceConverter<IUserDataFeatureWebRtc, UserDataFeatureWebRtc>
    {
    }

    internal class UserDataPermissionsConverter : GenericInterfaceConverter<IUserDataPermissions, UserDataPermissions>
    {
    }

    internal class AppConverter : GenericInterfaceConverter<IApp, App>
    {
    }

    internal class
        ReportedStateFeaturesConverter : GenericInterfaceConverter<IReportedStateFeatures, ReportedStateFeatures>
    {
    }

    internal class
        ReportedStateFeaturesCloudConverter : GenericInterfaceConverter<IReportedStateFeaturesCloud,
        ReportedStateFeaturesCloud>
    {
    }

    internal class ReportedStateFeaturesDeviceListConverter : GenericInterfaceConverter<IReportedStateFeaturesDeviceList
        , ReportedStateFeaturesDeviceList>
    {
    }

    internal class ReportedStateFeaturesInfoApisConverter : GenericInterfaceConverter<IReportedStateFeaturesInfoApis,
        ReportedStateFeaturesInfoApis>
    {
    }

    internal class
        ReportedStateFirmwareUpdateConverter : GenericInterfaceConverter<IReportedStateFirmwareUpdate,
        ReportedStateFirmwareUpdate>
    {
    }

    internal class
        ReportedStateHardwareConverter : GenericInterfaceConverter<IReportedStateHardware, ReportedStateHardware>
    {
    }

    internal class LocationConverter : GenericInterfaceConverter<ILocation, Location>
    {
    }

    internal class ControllerConverter : GenericInterfaceConverter<IController, Controller>
    {
    }

    internal class
        UnAdoptedDevicesAddressConverter : GenericInterfaceConverter<IUnAdoptedDevicesAddress, UnAdoptedDevicesAddress>
    {
    }

    internal class UnAdoptedDeviceConverter : GenericInterfaceConverter<IUnAdoptedDevice, UnAdoptedDevice>
    {
    }

    internal class ControllerFeaturesConverter : GenericInterfaceConverter<IControllerFeatures, ControllerFeatures>
    {
    }  
    
    internal class ControllerAppConverter : GenericInterfaceConverter<IControllerApp, ControllerApp>
    {
    }  
    
    internal class SiteInternetIssuesPeriodConverter : GenericInterfaceConverter<ISiteInternetIssuesPeriod, SiteInternetIssuesPeriod>
    {
    }   
    
    internal class HostInternetIssuesPeriodConverter : GenericInterfaceConverter<IHostInternetIssuesPeriod, HostInternetIssuesPeriod>
    {
    }

    internal class InternetIssuesConverter : GenericInterfaceConverter<IInternetIssues, InternetIssues>
    {
    } 
    
    internal class ReportedStateUiConverter : GenericInterfaceConverter<IReportedStateUi, ReportedStateUi>
    {
    }  
    
    internal class SiteStatisticsConverter : GenericInterfaceConverter<ISiteStatistics, SiteStatistics>
    {
    } 
    
    internal class SiteStatisticsCountsConverter : GenericInterfaceConverter<ISiteStatisticsCounts, SiteStatisticsCounts>
    {
    }   
    
    internal class SiteMetaConverter : GenericInterfaceConverter<ISiteMeta, SiteMeta>
    {
    }   
    
    internal class SiteStatisticsIspInfoConverter : GenericInterfaceConverter<ISiteStatisticsIspInfo, SiteStatisticsIspInfo>
    {
    }

    internal class SiteStatisticsPercentagesConverter : GenericInterfaceConverter<ISiteStatisticsPercentages, SiteStatisticsPercentages>
    {
    }
}