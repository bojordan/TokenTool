using Microsoft.Identity.Client;

namespace TokenTool.Core
{
    public static class TokenRetrieverMsalS2s
    {
        public static string GetToken(string[] scopes, string clientId, string thumbprint)
        {
            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
                .WithAuthority("https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47")
                .WithCertificate(CertUtils.GetCertificateFromStore(thumbprint))
                .Build();

            var token = clientApp.AcquireTokenForClient(scopes).ExecuteAsync().GetAwaiter().GetResult();
            return token.AccessToken;
        }
    }
}
