using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace TokenTool.Core
{
    public static class TokenRetrieverAdalS2s
    {
        public static async Task<string> GetAccessTokenAsync(
            string resource,
            string clientId,
            CertStoreLocation storeLocation,
            string thumbprint,
            string authority)
        {
            var certificate = CertUtils.GetCertificateFromStore(storeLocation, thumbprint);
            var clientAssertionCertificate = new ClientAssertionCertificate(clientId, certificate);
            var authContext = new AuthenticationContext(authority: authority, validateAuthority: true);

            // Acquire the token via the client credential grant flow
            var result = await authContext.AcquireTokenAsync(resource, clientAssertionCertificate).ConfigureAwait(false);

            return result.AccessToken;
        }
    }
}
