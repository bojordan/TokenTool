﻿using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace TokenTool.Core
{
    public static class TokenRetrieverAdalS2s
    {
        public static async Task<string> GetAccessTokenAsync(string resource, string clientId, string thumbprint)
        {
            var certificate = CertUtils.GetCertificateFromStore(thumbprint);
            var clientAssertionCertificate = new ClientAssertionCertificate(clientId, certificate);
            var authority = "https://login.microsoftonline.com/common";
            var authContext = new AuthenticationContext(authority: authority, validateAuthority: true);

            // Acquire the token via the client credential grant flow
            var result = await authContext.AcquireTokenAsync(resource, clientAssertionCertificate).ConfigureAwait(false);

            return result.AccessToken;
        }
    }
}
