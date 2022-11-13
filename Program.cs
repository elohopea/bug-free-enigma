var builder = WebApplication.CreateBuilder(args);
{
    var services = builder.Services;
    services.AddControllers();
}

var app = builder.Build();
{
    app.MapControllers();
}

app.MapGet("/", () => "Greetings from Program.cs");

app.Run();
