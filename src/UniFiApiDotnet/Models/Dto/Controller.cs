using System;
using System.Collections.Generic;
using System.Diagnostics;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    [DebuggerDisplay("{Name,nq} - {InstallState,nq}")]
    internal class Controller : IController
    {
        public bool Abridged { get; set; }
        public string ControllerStatus { get; set; } = string.Empty;
        public bool InitialDeviceListSynced { get; set; }
        public string InstallState { get; set; } = string.Empty;
        public bool Installable { get; set; }
        public bool IsConfigured { get; set; }
        public bool IsInstalled { get; set; }
        public bool IsRunning { get; set; }
        public string Name { get; set; } = string.Empty;     
        public int Port { get; set; }
        public string ReleaseChannel { get; set; } = string.Empty;
        public bool Required { get; set; }
        public string State { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string StatusMessage { get; set; } = string.Empty;
        public int SwaiVersion { get; set; }
        public string Type { get; set; } = string.Empty;
        public string UiVersion { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public bool Updatable { get; set; }
        public string UpdateAvailable { get; set; } = string.Empty;
        public int UpdateProgress { get; set; }
        public IUpdateSchedule? UpdateSchedule { get; set; }
        public int RestorePercentage { get; set; }
        public bool IsGeofencingEnabled { get; set; }
        public IEnumerable<IUnAdoptedDevice> UnAdoptedDevices { get; set; } = Array.Empty<IUnAdoptedDevice>();
        public IControllerFeatures? Features { get; set; } = null;
        public IEnumerable<IControllerApp> Apps { get; set; } = Array.Empty<IControllerApp>();
    }
}
