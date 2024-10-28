using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class IspMetrics : IIspMetrics
    {
        public string MetricType { get; set; } = string.Empty;
        public IEnumerable<IIspMetricsPeriod> Periods { get; set; } = Array.Empty<IIspMetricsPeriod>();
        public string HostId { get; set; } = string.Empty;
        public string SiteId { get; set; } = string.Empty;
    }

    internal class IspQueryMetrics : IIspQueryMetrics
    {
        public IEnumerable<IIspMetrics> Metrics { get; set; } = Array.Empty<IIspMetrics>();
    }

    internal class IspMetricsPeriod : IIspMetricsPeriod
    {
        public IIspMetricsPeriodData Data { get; set; } = new IspMetricsPeriodData();
        public DateTime MetricTime { get; set; }
        public string Version { get; set; } = string.Empty;
    }

    internal class IspMetricsPeriodData : IIspMetricsPeriodData
    {
        public IIspMetricsPeriodDataWan Wan { get; set; } = new IspMetricsPeriodDataWan();
    }

    internal class IspMetricsPeriodDataWan : IIspMetricsPeriodDataWan
    {
        public int AvgLatency { get; set; }
        [JsonPropertyName("download_kbps")]
        public int DownloadKbps { get; set; }
        public int Downtime { get; set; }
        public int MaxLatency { get; set; }
        public int PacketLoss { get; set; }
        [JsonPropertyName("upload_kbps")]
        public int UploadKbps { get; set; }
        public int Uptime { get; set; }
        public string IspAsn { get; set; } = string.Empty;
        public string IspName { get; set; } = string.Empty;
    }
}
