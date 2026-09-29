using MiddlewareDemo.Middleware;

namespace MiddlewareDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.Use(async (context, next) =>
            {
                Console.WriteLine("Inner Middleware Before Next");
                await next(context);
                Console.WriteLine("Inner Middleware After Next");
            });

            app.UseGlobalExceptionHandler();
            app.UseRequestTiming();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
