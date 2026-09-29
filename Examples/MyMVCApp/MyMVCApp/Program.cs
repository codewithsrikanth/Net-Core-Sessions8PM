namespace MyMVCApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            //builder.Services.AddControllers();  //Web API Core
            //builder.Services.AddRazorPages(); // Razor Pages

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //Middleware

            if (!app.Environment.IsDevelopment()) 
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();  
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
