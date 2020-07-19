using System.Net.WebSockets;
using UnityEngine;
using UnityEngine.Networking;

namespace GraphQlClient.Core.Auth
{
    [CreateAssetMenu(fileName = "Token Bearer Auth", menuName = "GraphQlClient/AuthMiddlewares/Token Bearer Auth")]
    public class TokenBearerAuthMiddleware : RequestAuthMiddleware
    {
        public string token;

        public void SetToken(string value) => token = value;

        public override void Prepare(UnityWebRequest request)
        {
            request.SetRequestHeader("Authorization", string.Format("Bearer {0}", token));
        }

        public override void Prepare(ClientWebSocket socket)
        {
            socket.Options.SetRequestHeader("Authorization", string.Format("Bearer {0}", token));
        }
    }
}
