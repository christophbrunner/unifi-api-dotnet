using System;
using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IReportedState
    {
        Guid AnonId { get; set; }
        IEnumerable<IApp> Apps { get; set; }
        string[] AvailableChannels { get; set; }
        string[] ConsolesOnSameLocalNetwork { get; set; }
        string ControllerUuid { get; set; }
        IEnumerable<IController> Controllers { get; set; }


        /// <summary>
        /// Code of the country the device is located in (ISO-3166). see https://en.wikipedia.org/wiki/ISO_3166-1
        /// </summary>
        int Country { get; set; }

        //todo: add mapping / add documentation
        // object DeviceErrorCode { get; set; }

        /// <summary>
        /// State of the device (e.g. "setup")
        /// </summary>
        string DeviceState { get; set; }
        DateTime? DeviceStateLastChanged { get; set; }
        string DirectConnectDomain { get; set; }
        IReportedStateFeatures Features { get; set; }
        IReportedStateFirmwareUpdate FirmwareUpdate { get; set; }
        IReportedStateHardware Hardware { get; set; }
        int HostType { get; set; }
        string HostName { get; set; }
        string Ip { get; set; }
        IEnumerable<string> IpAddrs { get; set; }
        bool IsStacked { get; set; }
        bool IsUbiOsMigration { get; set; }
        ILocation Location { get; set; }

        /// <summary>
        /// MAC address of the device
        /// </summary>
        string Mac { get; set; }
        int ManagementPort { get; set; }

        /// <summary>
        /// Name of the Device (customizable by the user)
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Selected release channel (e.g. "beta")
        /// </summary>
        string ReleaseChannel { get; set; }

        //todo: add documentation / identify possible values
        /// <summary>
        /// connected
        /// </summary>
        string State { get; set; }

        /// <summary>
        /// Timezone of the device (e.g. "Europe/Berlin")
        /// </summary>
        string Timezone { get; set; }

        //todo: add mapping / add documentation / identify possible values
        // object UcareState { get; set; }

        /// <summary>
        /// Visual meta data of the device (eg. Icons, Images)
        /// </summary>
        IUiDb UiDb { get; set; }

        //todo: add mapping / add documentation > ask for type
        // object[] UnadoptedUnifiOSDevices { get; set; }

        IInternetIssues InternetIssues5min { get; set; }
        
        string Version { get; set; }

        bool OverrideInformHost { get; set; }

        IReportedStateUi? Ui { get; set; }
    }
}