using Microsoft.AspNetCore.Authentication;

namespace MiddlewareDemo.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context) 
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled Expcetion for {Path}", context.Request.Path);
                context.Response.StatusCode = ex switch
                {
                    KeyNotFoundException => StatusCodes.Status404NotFound,
                    ArgumentException => StatusCodes.Status400BadRequest,
                    _ => StatusCodes.Status500InternalServerError
                };

                await context.Response.WriteAsJsonAsync(new
                {
                    status = context.Response.StatusCode,
                    message = context.Response.StatusCode == 500
                        ? "An unexpected error occurred."
                        : ex.Message,
                    traceId = context.TraceIdentifier
                });
            }
        }
    }
}
