using System.Threading.Tasks;

namespace HotelsHub.API.Application.Abstractions.ExternalCalls.HttpRequest
{
    public interface IHttpRequestService
    {
        Task<string> PostRequestAsync(object requestBody, string target);
        Task<string> GetRequestAsync(string target);
    }
}
