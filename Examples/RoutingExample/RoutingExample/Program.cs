var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Routing is automatically enabled
//No need for app.UseRouting() anymore
//app.MapGet("/", () => "Hello World!");

//app.Map("map1", async (context) =>
//{
//    await context.Response.WriteAsync("In Map 1");
//});

//app.Map("map2", async (context) =>
//{
//    await context.Response.WriteAsync("In Map 2");
//});

//app.MapPost("map3", async (context) =>
//{
//    await context.Response.WriteAsync("In Map 3 Post Request");
//});

app.Map("files/{filename}.{extension}", async context =>
{
    string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
    string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
    await context.Response.WriteAsync($"In Files - {filename} - {extension}");
});
//Default Route Parameter
//app.Map("employee/profile/{EmployeeName=Srikanth}", async context =>
//{
//    string? empName = Convert.ToString(context.Request.RouteValues["EmployeeName"]);
//    await context.Response.WriteAsync("Employee Name is: " + empName);
//});

app.Map("employee/profile/{EmployeeName:length(3,7):maxlength(7)=Srikanth}", async context =>
{
    string? empName = Convert.ToString(context.Request.RouteValues["EmployeeName"]);
    await context.Response.WriteAsync("Employee Name is: " + empName);
});

//Optional Route Parameter
app.Map("products/details/{id:int?}", async context =>
{
    if (context.Request.RouteValues.ContainsKey("id"))
    {
        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"Product Details -  {id}");
    }
    else
    {
        await context.Response.WriteAsync($"Product Details -  ID is not supplied");
    }
   
});

app.MapFallback(async (context) =>
{
    await context.Response.WriteAsync($"Request Recived at {context.Request.Path}");
});

app.Run();
