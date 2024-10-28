using System;
using System.Collections.Generic;
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

            foreach (var site in sites)
            {
                var siteIspMetrics = await _uniFiApiService.QueryIspMetrics(IspMetricType.Predefined1H,
                    new List<QueryIspMetricsFilter>()
                    {
                        new QueryIspMetricsFilter(site.HostId, site.SiteId)
                        {
                            BeginTimestamp = new DateTime(2024, 10, 8),
                            EndTimestamp = new DateTime(2024, 10, 18),
                        }
                    });

                Console.WriteLine($"{siteIspMetrics.Metrics.Count()} ISP Metrics found (1h > date range) {siteIspMetrics.Metrics.SelectMany(x => x.Periods).Count()} periods");


                siteIspMetrics = await _uniFiApiService.QueryIspMetrics(IspMetricType.Predefined1H,
                    new List<QueryIspMetricsFilter>()
                    {
                        new QueryIspMetricsFilter(site.HostId, site.SiteId)
                    });

                Console.WriteLine($"{siteIspMetrics.Metrics.Count()} ISP Metrics found (1h) {siteIspMetrics.Metrics.SelectMany(x => x.Periods).Count()} periods");
            }

            var devices = await _uniFiApiService.GetDevices();
            Console.WriteLine($"{devices.Count()} device(s) found");


            var deviceByTime = await _uniFiApiService.GetDevices(time: DateTime.Now.AddDays(-30));
            Console.WriteLine($"{deviceByTime.Count()} filtered by Date device(s) found");

            var ispMetrics = await _uniFiApiService.GetIspMetrics(IspMetricType.Predefined5M);

            Console.WriteLine($"{ispMetrics.Count()} ISP Metrics found (5m) {ispMetrics.SelectMany(x=>x.Periods).Count()} periods");

            ispMetrics = await _uniFiApiService.GetIspMetrics(IspMetricType.Predefined1H);

            Console.WriteLine($"{ispMetrics.Count()} ISP Metrics found (1h) {ispMetrics.SelectMany(x => x.Periods).Count()} periods");

            ispMetrics = await _uniFiApiService.GetIspMetrics(IspMetricType.Predefined1H, Duration.Predefined7D);

            Console.WriteLine($"{ispMetrics.Count()} ISP Metrics found (1h > 7d) {ispMetrics.SelectMany(x => x.Periods).Count()} periods");

            ispMetrics = await _uniFiApiService.GetIspMetrics(IspMetricType.Predefined1H, new DateTime(2024,10,8), new DateTime(2024,10,18));

            Console.WriteLine($"{ispMetrics.Count()} ISP Metrics found (1h > date range) {ispMetrics.SelectMany(x => x.Periods).Count()} periods");


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