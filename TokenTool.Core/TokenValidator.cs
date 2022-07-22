using Microsoft.IdentityModel.Protocols;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace TokenTool.Core
{
    public class TokenValidator
    {
        public static JwtSecurityToken Validate(string token, CertStoreLocation storeLocation, string certSubjectNameOrThumbprint)
        {
            var metadataAddress = $"https://login.microsoftonline.com/common/v2.0/.well-known/openid-configuration";

            var tokenHandler = new JwtSecurityTokenHandler();

            var configRetriever = new OpenIdConnectConfigurationRetriever();

            var configManager = new ConfigurationManager<OpenIdConnectConfiguration>(
                metadataAddress,
                configRetriever);

            var config = configManager.GetConfigurationAsync().GetAwaiter().GetResult();

            var decryptionKeys = new List<SecurityKey>();

            var securityKey = CertUtils.GetSecurityKeyFromCertificateInCertStore(storeLocation, certSubjectNameOrThumbprint);

            if (securityKey != null)
            {
                decryptionKeys.Add(securityKey);
            }

            var tokenValidationParameters = new TokenValidationParameters
            {
                // Support Azure AD V1 and V2 endpoints.
                ValidIssuers = ValidIssuers("common"),

                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                ValidateLifetime = false,
                TokenDecryptionKeys = decryptionKeys,
                IssuerSigningKeys = config.SigningKeys,
            };

            _ = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);

            return (JwtSecurityToken)validatedToken;
        }

        public static string ValidateReadable(string token, CertStoreLocation storeLocation, string certSubjectName)
        {
            var validatedToken = Validate(token, storeLocation, certSubjectName);

            var tokenToDisplay = validatedToken;
            if (validatedToken.InnerToken != null)
            {
                tokenToDisplay = validatedToken.InnerToken;
            }

            var tokenHeaderJson = IndentJson(tokenToDisplay.Header.SerializeToJson());
            var tokenPayloadJson = IndentJson(tokenToDisplay.Payload.SerializeToJson());

            var rawData = tokenToDisplay.RawData;

            return $"HEADER\r\n{tokenHeaderJson}\r\nPAYLOAD\r\n{tokenPayloadJson}\r\nRAW\r\n{rawData}";
        }

        public static string ValidateRaw(string token, CertStoreLocation storeLocation, string certSubjectName)
        {
            var validatedToken = Validate(token, storeLocation, certSubjectName);

            return validatedToken.InnerToken.RawData;
        }

        private static string IndentJson(string unindentedJson)
        {
            // Helpful, since giving JwtPayload directly to JsonSerializer.Serialize() will lose array contents in the claims dictionary.
            // For example, Roles claims will appear to be empty arrays without this.
            var dictionary = JsonSerializer.Deserialize(unindentedJson, typeof(Dictionary<string, object>));
            var formattedJson = JsonSerializer.Serialize(dictionary, new JsonSerializerOptions { WriteIndented = true });
            return formattedJson;
        }

        public static List<string> ValidIssuers(string tenantId) =>
            new List<string>()
            {
                $"https://login.microsoftonline.com/{tenantId}/",
                $"https://login.microsoftonline.com/{tenantId}/v2.0",
                $"https://login.windows.net/{tenantId}/",
                $"https://login.microsoft.com/{tenantId}/",
                $"https://sts.windows.net/{tenantId}/",
                $"https://sts.windows.net/9fc3e45f-23ea-4b8a-a661-487127f2d2ee/"
            };
    }
}
