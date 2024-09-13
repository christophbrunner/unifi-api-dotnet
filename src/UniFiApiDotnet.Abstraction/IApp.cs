namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IApp
    {
        string ControllerStatus { get; set; }

        /// <summary>
        /// Name ot the application (e.g. "users")
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Port the application is running on
        /// </summary>
        int Port { get; set; }

        int SwaiVersion { get; set; }
        string Type { get; set; }
        string Version { get; set; }
    }
}