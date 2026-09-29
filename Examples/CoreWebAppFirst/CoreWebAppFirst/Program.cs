namespace CoreWebAppFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("Middleware stopped");
            //    //await next.Invoke();
            //    //Console.WriteLine("AFTER");
            //});


            //Minimal APIs
            app.MapGet("/", () => "Welcome ASP.Net Core Web App World!");
            //app.MapGet("/Home", () => "Welcome to Home Page");
            //app.MapPost("/items", () => "Created");
            //app.MapPut("/items/{id}", (int id) => $"Updated {id}");
            //app.MapDelete("/items/{id}", (int id) => $"Deleted {id}");


            app.Run();
        }
    }
}
