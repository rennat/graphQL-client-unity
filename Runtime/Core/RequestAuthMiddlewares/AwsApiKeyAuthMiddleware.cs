using System.Net.WebSockets;
using UnityEngine;
using UnityEngine.Networking;

namespace GraphQlClient.Core.Auth
{
    [CreateAssetMenu(fileName = "AWS API Key Auth", menuName = "GraphQlClient/AuthMiddlewares/AWS API Key Auth")]
    public class AwsApiKeyAuthMiddleware : RequestAuthMiddleware
    {
        public string apiKey;

        public override void Prepare(UnityWebRequest request)
        {
            request.SetRequestHeader("x-api-key", apiKey);
        }

        public override void Prepare(ClientWebSocket socket)
        {
            socket.Options.SetRequestHeader("x-api-key", apiKey);
        }
    }
}