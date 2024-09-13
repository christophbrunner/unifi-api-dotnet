using System;

namespace UniFiApiDotnet.Abstraction
{
    //todo: add documentation
    public interface IUiDb
    {
        Guid? Guid { get; set; }
        Guid? IconId { get; set; }
        Guid Id { get; set; }
        IImage Images { get; set; }
    }
}