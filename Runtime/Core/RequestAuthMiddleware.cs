using System.Net.WebSockets;
using UnityEngine;
using UnityEngine.Networking;

namespace GraphQlClient.Core
{
    public abstract class RequestAuthMiddleware : ScriptableObject
    {
        public abstract void Prepare(UnityWebRequest request);
        public abstract void Prepare(ClientWebSocket socket);
    }
}
