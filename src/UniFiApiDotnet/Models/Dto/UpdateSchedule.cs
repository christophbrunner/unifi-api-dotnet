using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class UpdateSchedule : IUpdateSchedule
    {
        public int Day { get; set; }
        public int Hour { get; set; }
        public string Frequency { get; set; } = string.Empty;
    }
}