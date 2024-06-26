/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: support@akeyless.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// CertificateInfo
    /// </summary>
    [DataContract(Name = "CertificateInfo")]
    public partial class CertificateInfo : IEquatable<CertificateInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateInfo" /> class.
        /// </summary>
        /// <param name="extKeyUsage">extKeyUsage.</param>
        /// <param name="keyUsage">KeyUsage represents the set of actions that are valid for a given key. It&#39;s a bitmap of the KeyUsage* constants..</param>
        /// <param name="crlDistributionPoints">crlDistributionPoints.</param>
        /// <param name="dnsNames">dnsNames.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        /// <param name="extensions">extensions.</param>
        /// <param name="ipAddresses">ipAddresses.</param>
        /// <param name="isCa">isCa.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="issuingCertificateUrl">issuingCertificateUrl.</param>
        /// <param name="keySize">keySize.</param>
        /// <param name="notAfter">notAfter.</param>
        /// <param name="notBefore">notBefore.</param>
        /// <param name="ocspServer">ocspServer.</param>
        /// <param name="publicKeyAlgorithmName">publicKeyAlgorithmName.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="sha1Fingerprint">sha1Fingerprint.</param>
        /// <param name="sha256Fingerprint">sha256Fingerprint.</param>
        /// <param name="signature">signature.</param>
        /// <param name="signatureAlgorithmName">signatureAlgorithmName.</param>
        /// <param name="subject">subject.</param>
        /// <param name="subjectPublicKey">subjectPublicKey.</param>
        /// <param name="uris">uris.</param>
        /// <param name="version">version.</param>
        public CertificateInfo(List<long> extKeyUsage = default(List<long>), long keyUsage = default(long), List<string> crlDistributionPoints = default(List<string>), List<string> dnsNames = default(List<string>), List<string> emailAddresses = default(List<string>), List<Extension> extensions = default(List<Extension>), List<string> ipAddresses = default(List<string>), bool isCa = default(bool), Name issuer = default(Name), List<string> issuingCertificateUrl = default(List<string>), long keySize = default(long), DateTime notAfter = default(DateTime), DateTime notBefore = default(DateTime), List<string> ocspServer = default(List<string>), string publicKeyAlgorithmName = default(string), string serialNumber = default(string), string sha1Fingerprint = default(string), string sha256Fingerprint = default(string), string signature = default(string), string signatureAlgorithmName = default(string), Name subject = default(Name), string subjectPublicKey = default(string), List<string> uris = default(List<string>), long version = default(long))
        {
            this.ExtKeyUsage = extKeyUsage;
            this.KeyUsage = keyUsage;
            this.CrlDistributionPoints = crlDistributionPoints;
            this.DnsNames = dnsNames;
            this.EmailAddresses = emailAddresses;
            this.Extensions = extensions;
            this.IpAddresses = ipAddresses;
            this.IsCa = isCa;
            this.Issuer = issuer;
            this.IssuingCertificateUrl = issuingCertificateUrl;
            this.KeySize = keySize;
            this.NotAfter = notAfter;
            this.NotBefore = notBefore;
            this.OcspServer = ocspServer;
            this.PublicKeyAlgorithmName = publicKeyAlgorithmName;
            this.SerialNumber = serialNumber;
            this.Sha1Fingerprint = sha1Fingerprint;
            this.Sha256Fingerprint = sha256Fingerprint;
            this.Signature = signature;
            this.SignatureAlgorithmName = signatureAlgorithmName;
            this.Subject = subject;
            this.SubjectPublicKey = subjectPublicKey;
            this.Uris = uris;
            this._Version = version;
        }

        /// <summary>
        /// Gets or Sets ExtKeyUsage
        /// </summary>
        [DataMember(Name = "ExtKeyUsage", EmitDefaultValue = false)]
        public List<long> ExtKeyUsage { get; set; }

        /// <summary>
        /// KeyUsage represents the set of actions that are valid for a given key. It&#39;s a bitmap of the KeyUsage* constants.
        /// </summary>
        /// <value>KeyUsage represents the set of actions that are valid for a given key. It&#39;s a bitmap of the KeyUsage* constants.</value>
        [DataMember(Name = "KeyUsage", EmitDefaultValue = false)]
        public long KeyUsage { get; set; }

        /// <summary>
        /// Gets or Sets CrlDistributionPoints
        /// </summary>
        [DataMember(Name = "crl_distribution_points", EmitDefaultValue = false)]
        public List<string> CrlDistributionPoints { get; set; }

        /// <summary>
        /// Gets or Sets DnsNames
        /// </summary>
        [DataMember(Name = "dns_names", EmitDefaultValue = false)]
        public List<string> DnsNames { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name = "email_addresses", EmitDefaultValue = false)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Extensions
        /// </summary>
        [DataMember(Name = "extensions", EmitDefaultValue = false)]
        public List<Extension> Extensions { get; set; }

        /// <summary>
        /// Gets or Sets IpAddresses
        /// </summary>
        [DataMember(Name = "ip_addresses", EmitDefaultValue = false)]
        public List<string> IpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets IsCa
        /// </summary>
        [DataMember(Name = "is_ca", EmitDefaultValue = true)]
        public bool IsCa { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public Name Issuer { get; set; }

        /// <summary>
        /// Gets or Sets IssuingCertificateUrl
        /// </summary>
        [DataMember(Name = "issuing_certificate_url", EmitDefaultValue = false)]
        public List<string> IssuingCertificateUrl { get; set; }

        /// <summary>
        /// Gets or Sets KeySize
        /// </summary>
        [DataMember(Name = "key_size", EmitDefaultValue = false)]
        public long KeySize { get; set; }

        /// <summary>
        /// Gets or Sets NotAfter
        /// </summary>
        [DataMember(Name = "not_after", EmitDefaultValue = false)]
        public DateTime NotAfter { get; set; }

        /// <summary>
        /// Gets or Sets NotBefore
        /// </summary>
        [DataMember(Name = "not_before", EmitDefaultValue = false)]
        public DateTime NotBefore { get; set; }

        /// <summary>
        /// Gets or Sets OcspServer
        /// </summary>
        [DataMember(Name = "ocsp_server", EmitDefaultValue = false)]
        public List<string> OcspServer { get; set; }

        /// <summary>
        /// Gets or Sets PublicKeyAlgorithmName
        /// </summary>
        [DataMember(Name = "public_key_algorithm_name", EmitDefaultValue = false)]
        public string PublicKeyAlgorithmName { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name = "serial_number", EmitDefaultValue = false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets Sha1Fingerprint
        /// </summary>
        [DataMember(Name = "sha_1_fingerprint", EmitDefaultValue = false)]
        public string Sha1Fingerprint { get; set; }

        /// <summary>
        /// Gets or Sets Sha256Fingerprint
        /// </summary>
        [DataMember(Name = "sha_256_fingerprint", EmitDefaultValue = false)]
        public string Sha256Fingerprint { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets SignatureAlgorithmName
        /// </summary>
        [DataMember(Name = "signature_algorithm_name", EmitDefaultValue = false)]
        public string SignatureAlgorithmName { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public Name Subject { get; set; }

        /// <summary>
        /// Gets or Sets SubjectPublicKey
        /// </summary>
        [DataMember(Name = "subject_public_key", EmitDefaultValue = false)]
        public string SubjectPublicKey { get; set; }

        /// <summary>
        /// Gets or Sets Uris
        /// </summary>
        [DataMember(Name = "uris", EmitDefaultValue = false)]
        public List<string> Uris { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public long _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CertificateInfo {\n");
            sb.Append("  ExtKeyUsage: ").Append(ExtKeyUsage).Append("\n");
            sb.Append("  KeyUsage: ").Append(KeyUsage).Append("\n");
            sb.Append("  CrlDistributionPoints: ").Append(CrlDistributionPoints).Append("\n");
            sb.Append("  DnsNames: ").Append(DnsNames).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  IpAddresses: ").Append(IpAddresses).Append("\n");
            sb.Append("  IsCa: ").Append(IsCa).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  IssuingCertificateUrl: ").Append(IssuingCertificateUrl).Append("\n");
            sb.Append("  KeySize: ").Append(KeySize).Append("\n");
            sb.Append("  NotAfter: ").Append(NotAfter).Append("\n");
            sb.Append("  NotBefore: ").Append(NotBefore).Append("\n");
            sb.Append("  OcspServer: ").Append(OcspServer).Append("\n");
            sb.Append("  PublicKeyAlgorithmName: ").Append(PublicKeyAlgorithmName).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Sha1Fingerprint: ").Append(Sha1Fingerprint).Append("\n");
            sb.Append("  Sha256Fingerprint: ").Append(Sha256Fingerprint).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  SignatureAlgorithmName: ").Append(SignatureAlgorithmName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SubjectPublicKey: ").Append(SubjectPublicKey).Append("\n");
            sb.Append("  Uris: ").Append(Uris).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertificateInfo);
        }

        /// <summary>
        /// Returns true if CertificateInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtKeyUsage == input.ExtKeyUsage ||
                    this.ExtKeyUsage != null &&
                    input.ExtKeyUsage != null &&
                    this.ExtKeyUsage.SequenceEqual(input.ExtKeyUsage)
                ) && 
                (
                    this.KeyUsage == input.KeyUsage ||
                    this.KeyUsage.Equals(input.KeyUsage)
                ) && 
                (
                    this.CrlDistributionPoints == input.CrlDistributionPoints ||
                    this.CrlDistributionPoints != null &&
                    input.CrlDistributionPoints != null &&
                    this.CrlDistributionPoints.SequenceEqual(input.CrlDistributionPoints)
                ) && 
                (
                    this.DnsNames == input.DnsNames ||
                    this.DnsNames != null &&
                    input.DnsNames != null &&
                    this.DnsNames.SequenceEqual(input.DnsNames)
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    input.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
                ) && 
                (
                    this.IpAddresses == input.IpAddresses ||
                    this.IpAddresses != null &&
                    input.IpAddresses != null &&
                    this.IpAddresses.SequenceEqual(input.IpAddresses)
                ) && 
                (
                    this.IsCa == input.IsCa ||
                    this.IsCa.Equals(input.IsCa)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.IssuingCertificateUrl == input.IssuingCertificateUrl ||
                    this.IssuingCertificateUrl != null &&
                    input.IssuingCertificateUrl != null &&
                    this.IssuingCertificateUrl.SequenceEqual(input.IssuingCertificateUrl)
                ) && 
                (
                    this.KeySize == input.KeySize ||
                    this.KeySize.Equals(input.KeySize)
                ) && 
                (
                    this.NotAfter == input.NotAfter ||
                    (this.NotAfter != null &&
                    this.NotAfter.Equals(input.NotAfter))
                ) && 
                (
                    this.NotBefore == input.NotBefore ||
                    (this.NotBefore != null &&
                    this.NotBefore.Equals(input.NotBefore))
                ) && 
                (
                    this.OcspServer == input.OcspServer ||
                    this.OcspServer != null &&
                    input.OcspServer != null &&
                    this.OcspServer.SequenceEqual(input.OcspServer)
                ) && 
                (
                    this.PublicKeyAlgorithmName == input.PublicKeyAlgorithmName ||
                    (this.PublicKeyAlgorithmName != null &&
                    this.PublicKeyAlgorithmName.Equals(input.PublicKeyAlgorithmName))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.Sha1Fingerprint == input.Sha1Fingerprint ||
                    (this.Sha1Fingerprint != null &&
                    this.Sha1Fingerprint.Equals(input.Sha1Fingerprint))
                ) && 
                (
                    this.Sha256Fingerprint == input.Sha256Fingerprint ||
                    (this.Sha256Fingerprint != null &&
                    this.Sha256Fingerprint.Equals(input.Sha256Fingerprint))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.SignatureAlgorithmName == input.SignatureAlgorithmName ||
                    (this.SignatureAlgorithmName != null &&
                    this.SignatureAlgorithmName.Equals(input.SignatureAlgorithmName))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.SubjectPublicKey == input.SubjectPublicKey ||
                    (this.SubjectPublicKey != null &&
                    this.SubjectPublicKey.Equals(input.SubjectPublicKey))
                ) && 
                (
                    this.Uris == input.Uris ||
                    this.Uris != null &&
                    input.Uris != null &&
                    this.Uris.SequenceEqual(input.Uris)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ExtKeyUsage != null)
                {
                    hashCode = (hashCode * 59) + this.ExtKeyUsage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeyUsage.GetHashCode();
                if (this.CrlDistributionPoints != null)
                {
                    hashCode = (hashCode * 59) + this.CrlDistributionPoints.GetHashCode();
                }
                if (this.DnsNames != null)
                {
                    hashCode = (hashCode * 59) + this.DnsNames.GetHashCode();
                }
                if (this.EmailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddresses.GetHashCode();
                }
                if (this.Extensions != null)
                {
                    hashCode = (hashCode * 59) + this.Extensions.GetHashCode();
                }
                if (this.IpAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.IpAddresses.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCa.GetHashCode();
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.IssuingCertificateUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IssuingCertificateUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.KeySize.GetHashCode();
                if (this.NotAfter != null)
                {
                    hashCode = (hashCode * 59) + this.NotAfter.GetHashCode();
                }
                if (this.NotBefore != null)
                {
                    hashCode = (hashCode * 59) + this.NotBefore.GetHashCode();
                }
                if (this.OcspServer != null)
                {
                    hashCode = (hashCode * 59) + this.OcspServer.GetHashCode();
                }
                if (this.PublicKeyAlgorithmName != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKeyAlgorithmName.GetHashCode();
                }
                if (this.SerialNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNumber.GetHashCode();
                }
                if (this.Sha1Fingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.Sha1Fingerprint.GetHashCode();
                }
                if (this.Sha256Fingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.Sha256Fingerprint.GetHashCode();
                }
                if (this.Signature != null)
                {
                    hashCode = (hashCode * 59) + this.Signature.GetHashCode();
                }
                if (this.SignatureAlgorithmName != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureAlgorithmName.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.SubjectPublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectPublicKey.GetHashCode();
                }
                if (this.Uris != null)
                {
                    hashCode = (hashCode * 59) + this.Uris.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
