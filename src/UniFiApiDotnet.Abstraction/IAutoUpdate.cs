namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IAutoUpdate
    {
        bool IncludeApplications { get; set; }

        IAutoUpdatePreferencesPrompt PreferencesPrompt { get; set; }

        /// <summary>
        /// Schedule for auto updates
        /// </summary>
        IUpdateSchedule Schedule { get; set; }
    }
}