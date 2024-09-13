using System;
using System.Linq;
using System.Threading.Tasks;
using UniFiApiDotnet.Abstraction;

namespace Sample.Calls
{
    public class DemoAppService
    {
        private readonly IUniFiApiService _uniFiApiService;

        public DemoAppService(IUniFiApiService uniFiApiService)
        {
            _uniFiApiService = uniFiApiService;
        }

        public async Task Run()
        {
            var hosts = await _uniFiApiService.GetHosts();
            Console.WriteLine($"{hosts.Count()} host(s) found");


            var sites = await _uniFiApiService.GetSites();
            Console.WriteLine($"{sites.Count()} site(s) found");

            var devices = await _uniFiApiService.GetDevices();
            Console.WriteLine($"{devices.Count()} device(s) found");


            var deviceByTime = await _uniFiApiService.GetDevices(time: DateTime.Now.AddDays(-30));
            Console.WriteLine($"{deviceByTime.Count()} filtered by Date device(s) found");

            foreach (IHost host in hosts)
            {
                var hostById = await _uniFiApiService.GetHostById(host.Id);
                Console.WriteLine($"Host with id {hostById.Id} loaded by Id");

                var deviceByHost = await _uniFiApiService.GetDevices(hostIds: new[] { host.Id });

                if (deviceByHost == null)
                {
                    Console.WriteLine($"No device(s) found for Hosts ({host.Id})");
                    continue;
                }

                foreach (IHostDeviceInfo hostDeviceInfo in deviceByHost)
                {
                    Console.WriteLine(
                        $"{hostDeviceInfo.Devices.Count()} Device(s) for {hostDeviceInfo.HostName} host found. Filtered with HostId: {host.Id}");
                }
            }
        }
    }
}