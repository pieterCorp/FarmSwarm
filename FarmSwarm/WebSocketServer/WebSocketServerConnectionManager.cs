using System;
using System.Collections.Concurrent;
using System.Net.WebSockets;


namespace FarmSwarm.WebSocketServer
{
    public class WebSocketServerConnectionManager : IWebSocketServerConnectionManager
    {
        private ConcurrentDictionary<string, WebSocket> _sockets;

        public WebSocketServerConnectionManager()
        {
            _sockets = new ConcurrentDictionary<string, WebSocket>();
        }

        public ConcurrentDictionary<string, WebSocket> GetAllSockets()
        {
            return _sockets;
        }

        public string AddSocket(WebSocket socket)
        {
            string ConnID = Guid.NewGuid().ToString();
            _sockets.TryAdd(ConnID, socket);
            Console.WriteLine("connection added: " + ConnID);

            return ConnID;
        }
    }
}
