using System.Collections.Concurrent;
using System.Net.WebSockets;

namespace FarmSwarm.WebSocketServer
{
    public interface IWebSocketServerConnectionManager
    {
        string AddSocket(WebSocket socket);
        ConcurrentDictionary<string, WebSocket> GetAllSockets();
    }
}