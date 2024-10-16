using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IController
    {
        bool Abridged { get; set; }
        string ControllerStatus { get; set; }
        IControllerFeatures? Features { get; set; }

        bool InitialDeviceListSynced { get; set; }

        /// <summary>
        /// State of the installation (e.g. installed, uninstalled, downloaded, updateFailed)
        /// </summary>
        string InstallState { get; set; }

        /// <summary>
        /// Shows if the controller is to be installed on the host
        /// </summary>
        bool Installable { get; set; }

        /// <summary>
        /// Shows if the controller is configured on the host
        /// </summary>
        bool IsConfigured { get; set; }

        bool IsGeofencingEnabled { get; set; }

        /// <summary>
        /// Shows if the controller is installed on the host
        /// </summary>
        bool IsInstalled { get; set; }

        /// <summary>
        /// Shows if the controller is currently running on the host
        /// </summary>
        bool IsRunning { get; set; }

        /// <summary>
        /// Name of the controller (e.g. network, protect, access, talk)
        /// </summary>
        string Name { get; set; }
        int Port { get; set; }
        string ReleaseChannel { get; set; }
        bool Required { get; set; }
        string State { get; set; }
        string Status { get; set; }
        string StatusMessage { get; set; }
        int SwaiVersion { get; set; }
        string Type { get; set; }
        string UiVersion { get; set; }

        string Version { get; set; }
        bool Updatable { get; set; }

        /// <summary>
        /// Version number from the available update for the controller (e.g. 4.71.149)
        /// </summary>
        string UpdateAvailable { get; set; }

        /// <summary>
        /// Progress of the update (0-100)
        /// </summary>
        int UpdateProgress { get; set; }

        IUpdateSchedule? UpdateSchedule { get; set; }

        int RestorePercentage { get; set; }


        /// <summary>
        /// List of all unadopted devices for this controller
        /// </summary>
        IEnumerable<IUnAdoptedDevice> UnAdoptedDevices { get; set; }


        IEnumerable<IControllerApp> Apps { get; set; }
    }
}