using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace THA.Search.Mocks
{
    public sealed class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;
        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                try
                {
                    Console.WriteLine($"Exception occured: {exception.Message}");
                }
                catch (Exception innerException)
                {
                    _logger.LogError(0, innerException, "Ошибка обработки исключения");
                }
                throw;
            }
        }
    }
}