var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "CI/CD working! App is running.");

app.Run();