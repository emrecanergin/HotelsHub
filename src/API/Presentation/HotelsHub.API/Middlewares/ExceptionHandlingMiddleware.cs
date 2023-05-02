using HotelsHub.API.Application.Abstractions.RabbitMqClient;
using HotelsHub.API.Responses;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;

namespace HotelsHub.API.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IPublisherService _publisherService;

        public ExceptionHandlingMiddleware(RequestDelegate next, IPublisherService publisherService)
        {
            _next = next;
            _publisherService = publisherService;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            try
            {
                await _next(httpContext);
            }
            catch (Exception error)
            {
                var response = httpContext.Response;
                response.ContentType = "application/json";

                switch (error)
                {
                    case ValidationException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                var result = JsonSerializer.Serialize(new ApiResponse<object> { ErrorMessage = error?.Message });
                _publisherService.SendData<string>("errorLog", result);
                await response.WriteAsync(result);
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
