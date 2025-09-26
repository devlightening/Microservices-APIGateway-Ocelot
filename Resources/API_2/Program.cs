var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => " API 2 is up and running! This service is healthy and ready to handle requests.");

app.Run();