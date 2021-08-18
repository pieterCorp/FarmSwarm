using Microsoft.AspNetCore.Builder;


namespace FarmSwarm.WebSocketServer.Middleware
{
    public static class WebSocketServerMiddlewareExtentions
    {
        public static IApplicationBuilder UseWebSocketServer(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<WebSocketServerMiddleware>();
        }
    }
}
