namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IControllerApp
    {
        string Name { get; set; }
        int Port { get; set; }
        int SwaiVersion { get; set; }
        string Type { get; set; }
        string UiCdn { get; set; }
        string UiDir { get; set; }
        string UiIndex { get; set; }
        string UiVersion { get; set; }
    }
}