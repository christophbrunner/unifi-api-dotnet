using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class AutoUpdatePreferencesPromptUnifiOs : IAutoUpdatePreferencesPromptUnifiOs
    {
        public bool Applications { get; set; }
        public bool Firmware { get; set; }
        public IUpdateSchedule DefaultSchedule { get; set; } = new UpdateSchedule();
    }
}