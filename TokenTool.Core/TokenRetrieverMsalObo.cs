using Microsoft.Identity.Client;

namespace TokenTool.Core
{
    public static class TokenRetrieverMsalObo
    {
        public static string GetToken(
            string[] scopes,
            string clientId,
            CertStoreLocation storeLocation,
            string thumbprint,
            string jwtToken,
            string authority,
            string encryptionCertName = null)
        {
            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
                .WithAuthority(authority)
                .WithCertificate(CertUtils.GetCertificateFromStore(storeLocation, thumbprint))
                .Build();

            if (encryptionCertName != null)
            {
                jwtToken = TokenValidator.ValidateRaw(jwtToken, storeLocation, encryptionCertName);
            }

            var userAssertion = new UserAssertion(jwtToken);
            var token = clientApp.AcquireTokenOnBehalfOf(scopes, userAssertion).ExecuteAsync().GetAwaiter().GetResult();
            return token.AccessToken;
        }
    }
}
