namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IAutoUpdatePreferencesPromptUnifiOs
    {
        bool Applications { get; set; }

        /// <summary>
        /// Auto update firmware
        /// </summary>
        bool Firmware { get; set; }

        /// <summary>
        /// Default schedule for auto updates
        /// </summary>
        IUpdateSchedule DefaultSchedule { get; set; }

    }
}