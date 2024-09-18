using System.Text.Json.Serialization;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class HostInternetIssuesPeriod : IHostInternetIssuesPeriod
    {
        public int Index { get; set; }

        [JsonPropertyName("not_reported")]
        public bool? NotReported { get; set; }
    }
}