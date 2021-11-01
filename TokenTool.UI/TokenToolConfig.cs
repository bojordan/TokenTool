namespace TokenTool.UI
{
    public class TokenToolConfig
    {
        public ResourceOrScopeWrapper[] ResourceScopes { get; set; }

        public ClientIdWrapper[] ClientIds { get; set; }

        public CertificateWrapper[] AuthenticationCertificates { get; set; }

        public CertificateWrapper[] EncryptionCertificates { get; set; }

        public AuthorityWrapper[] Authorities { get; set; }

        public class ResourceOrScopeWrapper
        {
            public string Label { get; set; }
            public string ResourceOrScope { get; set; }
        }

        public class ClientIdWrapper
        {
            public string Label { get; set; }
            public string ClientId { get; set; }
        }

        public class CertificateWrapper
        {
            public string Label { get; set; }
            public string SubjectName { get; set; }
            public string Thumbprint { get; set; }
        }

        public class AuthorityWrapper
        {
            public string Label { get; set; }
            public string Authority { get; set; }
        }
    }
}
