var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => "Hello from ASP.NET Core!");

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files from wwwroot
app.UseStaticFiles();

// Route root ("/") to index.html
app.MapFallbackToFile("index.html");

app.Run();
