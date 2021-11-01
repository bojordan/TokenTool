using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Cryptography.X509Certificates;

namespace TokenTool.Core
{
    public enum CertStoreLocation
    {
        CurrentUser,
        LocalMachine
    }

    public class CertUtils
    {
        public static X509Certificate2 GetCertificateFromStore(CertStoreLocation certStore, string subjectNameOrThumbprint)
        {
            StoreLocation storeLocation = (certStore == CertStoreLocation.CurrentUser) ? StoreLocation.CurrentUser : StoreLocation.LocalMachine;

            if (subjectNameOrThumbprint.Contains("."))
            {
                return GetCertificateFromStore(subjectNameOrThumbprint, X509FindType.FindBySubjectName, storeLocation);
            }
            else
            {
                return GetCertificateFromStore(subjectNameOrThumbprint, X509FindType.FindByThumbprint, storeLocation);
            }
        }

        protected static X509Certificate2 GetCertificateFromStore(string subjectNameOrThumbprint, X509FindType findType, StoreLocation storeLocation)
        {
            using var store = new X509Store(storeLocation);

            store.Open(OpenFlags.ReadOnly);

            X509Certificate2Collection certCollection = store.Certificates;

            var encryptionCert = certCollection.Find(findType, subjectNameOrThumbprint, false);
            if (encryptionCert.Count == 0)
            {
                return null;
            }

            return encryptionCert[0];
        }

        public static SecurityKey GetSecurityKeyFromCertificateInCertStore(CertStoreLocation storeLocation, string subjectNameOrThumbprint)
        {
            var cert = GetCertificateFromStore(storeLocation, subjectNameOrThumbprint);
            if (cert != null)
            {
                return new X509SecurityKey(cert);
            }
            return null;
        }

        public static SecurityKey GetSecurityKeyFromBase64EncodedCertificate(string certificate)
        {
            var privateKeyBytes = Convert.FromBase64String(certificate);
            var x509Cert = new X509Certificate2(privateKeyBytes);
            return new X509SecurityKey(x509Cert);
        }
    }
}
