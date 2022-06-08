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
            string authority,
            bool subjectNameIssuer)
        {
            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
                .WithCertificate(CertUtils.GetCertificateFromStore(storeLocation, thumbprint))
                .Build();

            var token = clientApp.AcquireTokenForClient(scopes)
                .WithAuthority(authority)
                .WithSendX5C(subjectNameIssuer)
                .ExecuteAsync().GetAwaiter().GetResult();
            return token.AccessToken;
        }
    }
}
