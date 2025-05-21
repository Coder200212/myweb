var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => "Hello from ASP.NET Core!");

app.Run();

