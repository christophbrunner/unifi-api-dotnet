namespace UniFiApiDotnet.Models.Dto
{
    public class GenericApiResponse<T> : BaseResponse
    {
        public T Data { get; set; } = default!;
    }
}
