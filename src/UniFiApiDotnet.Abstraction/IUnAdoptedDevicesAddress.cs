namespace UniFiApiDotnet.Abstraction
{
    public interface IUnAdoptedDevicesAddress
    {
        /// <summary>
        /// IP Address of the device
        /// </summary>
        string Ip { get; set; }

        /// <summary>
        /// MAC Address of the device
        /// </summary>
        string Mac { get; set; }
    }
}