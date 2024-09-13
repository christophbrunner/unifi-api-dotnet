using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("UniFiApiDotnet.Tests")]

namespace UniFiApiDotnet.Models.Dto
{
    internal class GenericApiResponse<T> : BaseResponse
    {
        public T Data { get; set; } = default!;
    }
}
