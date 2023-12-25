
// Application Builder Extensions
public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app)
    {
        // Configure middleware
        // app.UseMiddleware<...>();
        return app;
    }
}
