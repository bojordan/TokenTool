using Microsoft.Identity.Client;

namespace TokenTool.Core
{
    public static class TokenRetrieverMsalS2s
    {
        public static string GetToken(
            string[] scopes,
            string clientId,
            CertStoreLocation storeLocation,
            string thumbprint,
            string authority)
        {
            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
                .WithAuthority(authority)
                .WithCertificate(CertUtils.GetCertificateFromStore(storeLocation, thumbprint))
                .Build();

            var token = clientApp.AcquireTokenForClient(scopes).ExecuteAsync().GetAwaiter().GetResult();
            return token.AccessToken;
        }
    }
}
