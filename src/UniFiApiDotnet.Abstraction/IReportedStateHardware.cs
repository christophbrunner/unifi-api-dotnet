using System;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IReportedStateHardware
    {
        string Bom { get; set; }

        /// <summary>
        /// Identifier of CPU of the device
        /// </summary>
        string CpuId { get; set; }

        /// <summary>
        /// Release codename of the Debian version
        /// </summary>
        string DebianCodename { get; set; }

        /// <summary>
        /// UniFi OS Version
        /// </summary>
        string FirmwareVersion { get; set; }

        int HwRev { get; set; }

        /// <summary>
        /// MAC address of the device
        /// </summary>
        string Mac { get; set; }

        bool IsUbiOs { get; set; }

        /// <summary>
        /// Name of the device (defined by UniFi > e.g. "UniFi Network Video Recorder")
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Model name of the device (defined by UniFi > e.g. UDMPRO)
        /// </summary>
        string ShortName { get; set; }

        /// <summary>
        /// QR code ID of the device
        /// </summary>
        string QrId { get; set; }

        string Reboot { get; set; }

        /// <summary>
        /// Serial number of the device
        /// </summary>
        string SerialNo { get; set; }
        string Subtype { get; set; }
        int SysId { get; set; }
        string Upgrade { get; set; }
        Guid Uuid { get; set; }
    }
}