using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using HotelHubApp.Common.Infrastructure.HttpRequests.Helper;
using HotelsHub.API.Application.Abstractions.ExternalCalls.HttpRequest;

namespace HotelsHub.API.Infrastructure.ExternalCalls.Hotelbeds.HttpRequest
{
    public class HotelbedsHttpRequestService : IHttpRequestService
    {
        private readonly HttpClient _httpClient;
        public HotelbedsHttpRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            _httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "*");
            _httpClient.DefaultRequestHeaders.Add("Api-key", "*");
            _httpClient.DefaultRequestHeaders.Add("X-Signature", Signature.CreateSignature());
        }

        public async Task<string> PostRequestAsync(object requestBody, string target)
        {
            HttpContent resJson = new StringContent(JsonSerializer.Serialize(requestBody),
                                      Encoding.UTF8, "application/json");
            HttpResponseMessage httpResponse = await _httpClient.PostAsync($"{target}", resJson);


            httpResponse.EnsureSuccessStatusCode();

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString |
                JsonNumberHandling.WriteAsString,
            };

            var data = await httpResponse.Content.ReadAsStringAsync();

            return data;
        }

        public async Task<string> GetRequestAsync(string target)
        {
            HttpResponseMessage httpResponse = await _httpClient.GetAsync($"{target}");

            //returns httpResponseMessage
            httpResponse.EnsureSuccessStatusCode();

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString |
                JsonNumberHandling.WriteAsString,
            };

            var data = await httpResponse.Content.ReadAsStringAsync();

            return data;
        }
    }
}
