using System.Runtime.CompilerServices;

namespace MiddlewareDemo.Middleware
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseRequestTiming(this IApplicationBuilder app)
            => app.UseMiddleware<RequestTimingMiddleware>();

        public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder app)
            => app.UseMiddleware<GlobalExceptionMiddleware>();
    }
}
