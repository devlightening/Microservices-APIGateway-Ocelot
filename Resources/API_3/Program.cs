var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => " API 3 is running successfully! Everything looks good and the service is operational.");

app.Run();