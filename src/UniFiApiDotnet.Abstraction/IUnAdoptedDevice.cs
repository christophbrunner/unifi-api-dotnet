using System;
using System.Collections.Generic;

namespace UniFiApiDotnet.Abstraction
{

    public interface IUnAdoptedDevice
    {
        /// <summary>
        /// List of addresses (IP and MAC) of the unadopted devices
        /// </summary>
        IEnumerable<IUnAdoptedDevicesAddress> Addresses { get; set; }

        /// <summary>
        /// Icon Id of the unadopted device
        /// </summary>
        Guid IconId { get; set; }

        /// <summary>
        /// Model of the unadopted device (e.g. G5 Flex)
        /// </summary>
        string Model { get; set; }

        /// <summary>
        /// Name of the unadopted device (e.g. Camera G5 Flex)
        /// </summary>
        string Name { get; set; }

        //todo: add documentation
        int TotalCount { get; set; }
    }
}