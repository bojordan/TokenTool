using Microsoft.Identity.Client;

namespace TokenTool.Core
{
    public static class TokenRetrieverMsalObo
    {
        public static string GetToken(string[] scopes, string clientId, string thumbprint, string jwtToken, string encryptionCertName = null)
        {
            var clientApp = ConfidentialClientApplicationBuilder.Create(clientId)
                //.WithAuthority("https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47")
                .WithAuthority("https://login.microsoftonline.com/common")
                .WithCertificate(CertUtils.GetCertificateFromStore(thumbprint))
                .Build();

            if (encryptionCertName != null)
            {
                jwtToken = TokenValidator.ValidateRaw(jwtToken, encryptionCertName);
            }

            var userAssertion = new UserAssertion(jwtToken);
            var token = clientApp.AcquireTokenOnBehalfOf(scopes, userAssertion).ExecuteAsync().GetAwaiter().GetResult();
            return token.AccessToken;
        }
    }
}
