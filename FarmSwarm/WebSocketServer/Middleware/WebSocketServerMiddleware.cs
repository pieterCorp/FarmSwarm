using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FarmSwarm.WebSocketServer.Middleware
{
    public class WebSocketServerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebSocketServerConnectionManager _manager;

        public WebSocketServerMiddleware(RequestDelegate next, IWebSocketServerConnectionManager manager)
        {
            _next = next;
            _manager = manager;
        }

        
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.WebSockets.IsWebSocketRequest)
            {                
                WebSocket webSocket = await context.WebSockets.AcceptWebSocketAsync();                
                Console.WriteLine("new webSocket Connected");

                //wait for valid id and pass

                string ConnID = _manager.AddSocket(webSocket);

                await ReceiveMessage(webSocket, async (result, buffer) =>
                {
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        Console.WriteLine("message received");
                        Console.WriteLine($"Message: {Encoding.UTF8.GetString(buffer, 0, result.Count)}");
                        return;
                    }                    
                    else if (result.MessageType == WebSocketMessageType.Close)
                    {
                        Console.WriteLine("Received close message");
                        return;
                    }
                    
                });
            }
            else
            {
                Console.WriteLine("hello from 2nd delegate");
                await _next(context);
            }
        }

        private async Task ReceiveMessage(WebSocket socket, Action<WebSocketReceiveResult, byte[]> handleMessage)
        {
            var buffer = new byte[1024 * 4];

            while (true)
            {
                var result = await socket.ReceiveAsync(buffer: new ArraySegment<byte>(buffer),
                    cancellationToken: CancellationToken.None);

                handleMessage(result, buffer);
            }
        }
    }
}
