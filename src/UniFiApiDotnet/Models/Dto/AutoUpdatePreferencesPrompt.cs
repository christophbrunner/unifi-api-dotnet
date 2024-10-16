using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    internal class AutoUpdatePreferencesPrompt : IAutoUpdatePreferencesPrompt
    {
        public IAutoUpdatePreferencesPromptUnifiOs UnifiOS { get; set; } = new AutoUpdatePreferencesPromptUnifiOs();
    }
}