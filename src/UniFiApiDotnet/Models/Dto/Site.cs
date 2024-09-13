using System;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class Site : ISite
    {
        public string HostId { get; set; } = string.Empty;
        public bool IsOwner { get; set; }
        public ISiteMeta Meta { get; set; } = new SiteMeta();
        public string Permission { get; set; } = string.Empty;
        public string SiteId { get; set; } = string.Empty;
        public ISiteStatistics Statistics { get; set; } = new SiteStatistics();
        public DateTime SubscriptionEndTime { get; set; }
    }
}
