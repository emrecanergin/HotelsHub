using Newtonsoft.Json;

namespace HotelsHub.API.Responses
{
    public class ApiResponse<T> where T : class
    {
        //FOR XML RESPONSE
        public ApiResponse()
        {

        }
        public ApiResponse(T extra)
        {
            Success = true;
            Data = extra;
            TimeStamps = DateTime.UtcNow;
        }

        public ApiResponse(string errorMessage)
        {
            Success = false;
            ErrorMessage = errorMessage;
            TimeStamps = DateTime.UtcNow;
        }
        public T Data { get; set; }

        [JsonProperty(Order = -2)]
        public bool Success { get; set; }

        [JsonProperty(Order = -4)]
        public DateTime TimeStamps { get; set; }

        [JsonProperty(Order = -3)]
        public long TotalProcessTime { get; set; }

        public string ErrorMessage { get; set; }

    }
}
