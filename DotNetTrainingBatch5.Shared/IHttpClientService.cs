
namespace DotNetTrainingBatch5.Shared
{
    public interface IHttpClientService
    {
        Task<T> SendAsync<T>(string url, EnumHttpMethod method, object? data = null);
    }
}