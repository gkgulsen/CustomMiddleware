using CustomMiddleware.Middlewares;

namespace CustomMiddleware.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseBadwordHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RequestLoggingMiddleware>()
                      .UseMiddleware<JsonBodyMiddleware>()
                      .UseMiddleware<BadWordsHandlerMiddleware>();
        }
    }
}
