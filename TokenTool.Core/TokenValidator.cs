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
        public static JwtSecurityToken Validate(string token, string certSubjectNameOrThumbprint)
        {
            var metadataAddress = $"https://login.microsoftonline.com/common/v2.0/.well-known/openid-configuration";

            var tokenHandler = new JwtSecurityTokenHandler();

            var configRetriever = new OpenIdConnectConfigurationRetriever();

            var configManager = new ConfigurationManager<OpenIdConnectConfiguration>(
                metadataAddress,
                configRetriever);

            var config = configManager.GetConfigurationAsync().GetAwaiter().GetResult();

            var securityKey = CertUtils.GetSecurityKeyFromCertificateInCertStore(certSubjectNameOrThumbprint);

            var tokenValidationParameters = new TokenValidationParameters
            {
                // Support Azure AD V1 and V2 endpoints.
                ValidIssuers = ValidIssuers("common"),

                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                ValidateLifetime = false,
                TokenDecryptionKeys = new[] { securityKey },
                IssuerSigningKeys = config.SigningKeys,
            };

            _ = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);

            return (JwtSecurityToken)validatedToken;
        }

        public static string ValidateReadable(string token, string certSubjectName)
        {
            var validatedToken = Validate(token, certSubjectName);

            var tokenHeaderJson = IndentJson(validatedToken.InnerToken.Header.SerializeToJson());
            var tokenPayloadJson = IndentJson(validatedToken.InnerToken.Payload.SerializeToJson());

            var rawData = validatedToken.InnerToken.RawData;

            return $"HEADER\r\n{tokenHeaderJson}\r\nPAYLOAD\r\n{tokenPayloadJson}\r\nRAW\r\n{rawData}";
        }

        public static string ValidateRaw(string token, string certSubjectName)
        {
            var validatedToken = Validate(token, certSubjectName);

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
