var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.MapGet("/", () => "Project is under construction.");
app.Run();