using System;

namespace UniFiApiDotnet.Abstraction
{
    public interface IDevices
    {
        /// <summary>
        /// Date and time the device was adopted to the controller
        /// </summary>
        DateTime? AdoptionTime { get; set; }

        /// <summary>
        /// Internal Id of the device
        /// </summary>
        string Id { get; set; }

        /// <summary>
        /// IP Address of the device
        /// </summary>
        string Ip { get; set; }

        /// <summary>
        /// MAC Address of the device
        /// </summary>
        string Mac { get; set; }

        /// <summary>
        /// Status of the Firmware (eg. upToDate, updatePending)
        /// </summary>
        string FirmwareStatus { get; set; }

        /// <summary>
        /// Is the device a console or a managed device
        /// </summary>
        bool IsConsole { get; set; }

        //todo: add documentation
        bool IsManaged { get; set; }

        /// <summary>
        /// Model of the device
        /// </summary>
        string Model { get; set; }

        /// <summary>
        /// Name of the device
        /// </summary>
        string Name { get; set; }

        //todo: add documentation
        string Note { get; set; }

        /// <summary>
        /// Application (defined by UniFi > eg. Network, Protect, Talk)
        /// </summary>
        string ProductLine { get; set; }

        /// <summary>
        /// Model name of the device (defined by UniFi > e.g. UDMPRO)
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// Date and time the device was started up
        /// Null, if the device is offline
        /// </summary>
        DateTime? StartupTime { get; set; }

        /// <summary>
        /// The device status (e.g. adopting / online / offline / updating)
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Version number from the available update for the device (e.g. 4.71.149)
        /// </summary>
        string UpdateAvailable { get; set; }

        /// <summary>
        /// Version of the firmware version on the device
        /// </summary>
        string Version { get; set; }

        /// <summary>
        /// Visual meta data of the device (eg. Icons, Images)
        /// </summary>
        IUiDb UiDb { get; set; }
    }
}
