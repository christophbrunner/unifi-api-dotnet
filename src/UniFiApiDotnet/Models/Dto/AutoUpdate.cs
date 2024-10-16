using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class AutoUpdate : IAutoUpdate
    {
        public bool IncludeApplications { get; set; }
        public IAutoUpdatePreferencesPrompt PreferencesPrompt { get; set; } = new AutoUpdatePreferencesPrompt();
        public IUpdateSchedule Schedule { get; set; } = new UpdateSchedule();
    }
}
