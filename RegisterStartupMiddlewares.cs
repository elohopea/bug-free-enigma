public static class RegisterStartupMiddleware
{
    public static WebApplication SetupMiddleware(this WebApplication app)
    {
        app.MapControllers();
        app.UseHttpLogging();
        app.MapGet("/", () => "Greetings");
        return app;
    }
}
