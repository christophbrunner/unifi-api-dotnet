namespace UniFiApiDotnet.Abstraction
{
    /// <summary>
    /// Interface representing user data features related to FloorPlan.
    /// </summary>
    public interface IUserDataFeatureFloorPlan
    {
        /// <summary>
        /// Indicates when the user (based on API token) can edit the FloorPlan.
        /// </summary>
        bool CanEdit { get; set; }

        /// <summary>
        /// Indicates when the user (based on API token) can see the FloorPlan.
        /// </summary>
        bool CanView { get; set; }
    }
}