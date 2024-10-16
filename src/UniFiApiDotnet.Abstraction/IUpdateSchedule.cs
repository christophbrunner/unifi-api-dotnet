namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Information about the schedule for auto updates
    /// </summary>
    public interface IUpdateSchedule
    {
        /// <summary>
        /// Day of the week to run the update (only used if Frequency is weekly)
        /// </summary>
        int Day { get; set; }

        /// <summary>
        /// Hour of the day to run the update
        /// </summary>
        int Hour { get; set; }

        /// <summary>
        /// Frequency of the schedule (daily or weekly)
        /// </summary>
        string Frequency { get; set; }
    }
}