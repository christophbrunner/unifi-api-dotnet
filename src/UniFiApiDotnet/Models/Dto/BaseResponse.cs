using System.Net;

namespace UniFiApiDotnet.Models.Dto
{
    public class BaseResponse
    {
        public string Code { get; set; } = string.Empty;
        public HttpStatusCode HttpStatusCode { get; set; } = HttpStatusCode.BadRequest;
        public string Message { get; set; } = string.Empty;
        public string TraceId { get; set; } = string.Empty;
    }
}
