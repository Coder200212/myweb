var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => "Hello from Jonz GT!");

app.Run();
