namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IImage
    {
        string Default { get; set; }
        string NoPadding { get; set; }
        string Topology { get; set; }
    }
}