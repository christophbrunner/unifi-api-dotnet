namespace UniFiApiDotnet.Abstraction
{
    public interface ILocation
    {
        /// <summary>
        /// Latitude ot the location
        /// </summary>
        double Lat { get; set; }
        /// <summary>
        /// Longitude of the location
        /// </summary>
        double Long { get; set; }
        /// <summary>
        /// Radius of the location (in meters)
        /// </summary>
        int Radius { get; set; }
        /// <summary>
        /// Textual description of the location (e.g. "Inwil, Lucerne, Switzerland")
        /// </summary>
        string Text { get; set; }
    }
}