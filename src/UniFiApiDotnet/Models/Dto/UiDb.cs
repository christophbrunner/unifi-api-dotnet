using System;
using UniFiApiDotnet.Abstraction;

namespace UniFiApiDotnet.Models.Dto
{
    public class UiDb : IUiDb
    {
        public Guid? Guid { get; set; } = null;
        public Guid? IconId { get; set; }
        public Guid Id { get; set; } = System.Guid.Empty;
        public IImage Images { get; set; } = new Image();
    }
}