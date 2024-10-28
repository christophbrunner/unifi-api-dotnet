using System;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IIspMetricsPeriod
    {
        IIspMetricsPeriodData Data { get; set; }
        DateTime MetricTime { get; set; }
        string Version { get; set; }
    }
}