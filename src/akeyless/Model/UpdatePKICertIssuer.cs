/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 3.0
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
    /// UpdatePKICertIssuer
    /// </summary>
    [DataContract(Name = "UpdatePKICertIssuer")]
    public partial class UpdatePKICertIssuer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePKICertIssuer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdatePKICertIssuer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePKICertIssuer" /> class.
        /// </summary>
        /// <param name="addTag">List of the new tags that will be attached to this item.</param>
        /// <param name="allowAnyName">If set, clients can request certificates for any CN.</param>
        /// <param name="allowCopyExtFromCsr">If set, will allow copying the extra extensions from the csr file (if given).</param>
        /// <param name="allowSubdomains">If set, clients can request certificates for subdomains of the allowed domains.</param>
        /// <param name="allowedDomains">A list of the allowed domains that clients can request to be included in the certificate (in a comma-delimited list).</param>
        /// <param name="allowedExtraExtensions">A json string containing the allowed extra extensions for the pki cert issuer.</param>
        /// <param name="allowedIpSans">A list of the allowed CIDRs for ips that clients can request to be included in the certificate as part of the IP Subject Alternative Names (in a comma-delimited list).</param>
        /// <param name="allowedUriSans">A list of the allowed URIs that clients can request to be included in the certificate as part of the URI Subject Alternative Names (in a comma-delimited list).</param>
        /// <param name="autoRenew">Automatically renew certificates before expiration.</param>
        /// <param name="clientFlag">If set, certificates will be flagged for client auth use.</param>
        /// <param name="codeSigningFlag">If set, certificates will be flagged for code signing use.</param>
        /// <param name="country">A comma-separated list of countries that will be set in the issued certificate.</param>
        /// <param name="createPrivateCrl">Set this to allow the issuer will expose a CRL endpoint in the Gateway.</param>
        /// <param name="createPublicCrl">Set this to allow the cert issuer will expose a public CRL endpoint.</param>
        /// <param name="criticalKeyUsage">Mark key usage as critical [true/false] (default to &quot;true&quot;).</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="destinationPath">A path in which to save generated certificates.</param>
        /// <param name="disableWildcards">If set, generation of wildcard certificates will be disabled..</param>
        /// <param name="enableAcme">If set, the cert issuer will support the acme protocol.</param>
        /// <param name="expirationEventIn">How many days before the expiration of the certificate would you like to be notified..</param>
        /// <param name="gwClusterUrl">The GW cluster URL to issue the certificate from. Required in Public CA mode, to allow CRLs on private CA, or to enable ACME.</param>
        /// <param name="isCa">If set, the basic constraints extension will be added to certificate.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keyUsage">key-usage (default to &quot;DigitalSignature,KeyAgreement,KeyEncipherment&quot;).</param>
        /// <param name="locality">A comma-separated list of localities that will be set in the issued certificate.</param>
        /// <param name="maxPathLen">The maximum path length for the generated certificate. -1, means unlimited (default to -1).</param>
        /// <param name="metadata">Deprecated - use description.</param>
        /// <param name="name">PKI certificate issuer name (required).</param>
        /// <param name="newName">New item name.</param>
        /// <param name="notEnforceHostnames">If set, any names are allowed for CN and SANs in the certificate and not only a valid host name.</param>
        /// <param name="notRequireCn">If set, clients can request certificates without a CN.</param>
        /// <param name="organizationalUnits">A comma-separated list of organizational units (OU) that will be set in the issued certificate.</param>
        /// <param name="organizations">A comma-separated list of organizations (O) that will be set in the issued certificate.</param>
        /// <param name="postalCode">A comma-separated list of postal codes that will be set in the issued certificate.</param>
        /// <param name="protectCertificates">Whether to protect generated certificates from deletion.</param>
        /// <param name="province">A comma-separated list of provinces that will be set in the issued certificate.</param>
        /// <param name="rmTag">List of the existent tags that will be removed from this item.</param>
        /// <param name="scheduledRenew">Number of days before expiration to renew certificates.</param>
        /// <param name="serverFlag">If set, certificates will be flagged for server auth use.</param>
        /// <param name="signerKeyName">A key to sign the certificate with, required in Private CA mode.</param>
        /// <param name="streetAddress">A comma-separated list of street addresses that will be set in the issued certificate.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="ttl">The maximum requested Time To Live for issued certificates, in seconds. In case of Public CA, this is based on the CA target&#39;s supported maximum TTLs (required).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public UpdatePKICertIssuer(List<string> addTag = default(List<string>), bool allowAnyName = default(bool), bool allowCopyExtFromCsr = default(bool), bool allowSubdomains = default(bool), string allowedDomains = default(string), string allowedExtraExtensions = default(string), string allowedIpSans = default(string), string allowedUriSans = default(string), bool autoRenew = default(bool), bool clientFlag = default(bool), bool codeSigningFlag = default(bool), string country = default(string), bool createPrivateCrl = default(bool), bool createPublicCrl = default(bool), string criticalKeyUsage = @"true", string deleteProtection = default(string), string description = default(string), string destinationPath = default(string), bool disableWildcards = default(bool), bool enableAcme = default(bool), List<string> expirationEventIn = default(List<string>), string gwClusterUrl = default(string), bool isCa = default(bool), bool json = false, string keyUsage = @"DigitalSignature,KeyAgreement,KeyEncipherment", string locality = default(string), long maxPathLen = -1, string metadata = default(string), string name = default(string), string newName = default(string), bool notEnforceHostnames = default(bool), bool notRequireCn = default(bool), string organizationalUnits = default(string), string organizations = default(string), string postalCode = default(string), bool protectCertificates = default(bool), string province = default(string), List<string> rmTag = default(List<string>), long scheduledRenew = default(long), bool serverFlag = default(bool), string signerKeyName = default(string), string streetAddress = default(string), string token = default(string), string ttl = default(string), string uidToken = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdatePKICertIssuer and cannot be null");
            }
            this.Name = name;
            // to ensure "ttl" is required (not null)
            if (ttl == null)
            {
                throw new ArgumentNullException("ttl is a required property for UpdatePKICertIssuer and cannot be null");
            }
            this.Ttl = ttl;
            this.AddTag = addTag;
            this.AllowAnyName = allowAnyName;
            this.AllowCopyExtFromCsr = allowCopyExtFromCsr;
            this.AllowSubdomains = allowSubdomains;
            this.AllowedDomains = allowedDomains;
            this.AllowedExtraExtensions = allowedExtraExtensions;
            this.AllowedIpSans = allowedIpSans;
            this.AllowedUriSans = allowedUriSans;
            this.AutoRenew = autoRenew;
            this.ClientFlag = clientFlag;
            this.CodeSigningFlag = codeSigningFlag;
            this.Country = country;
            this.CreatePrivateCrl = createPrivateCrl;
            this.CreatePublicCrl = createPublicCrl;
            // use default value if no "criticalKeyUsage" provided
            this.CriticalKeyUsage = criticalKeyUsage ?? @"true";
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.DestinationPath = destinationPath;
            this.DisableWildcards = disableWildcards;
            this.EnableAcme = enableAcme;
            this.ExpirationEventIn = expirationEventIn;
            this.GwClusterUrl = gwClusterUrl;
            this.IsCa = isCa;
            this.Json = json;
            // use default value if no "keyUsage" provided
            this.KeyUsage = keyUsage ?? @"DigitalSignature,KeyAgreement,KeyEncipherment";
            this.Locality = locality;
            this.MaxPathLen = maxPathLen;
            this.Metadata = metadata;
            this.NewName = newName;
            this.NotEnforceHostnames = notEnforceHostnames;
            this.NotRequireCn = notRequireCn;
            this.OrganizationalUnits = organizationalUnits;
            this.Organizations = organizations;
            this.PostalCode = postalCode;
            this.ProtectCertificates = protectCertificates;
            this.Province = province;
            this.RmTag = rmTag;
            this.ScheduledRenew = scheduledRenew;
            this.ServerFlag = serverFlag;
            this.SignerKeyName = signerKeyName;
            this.StreetAddress = streetAddress;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// List of the new tags that will be attached to this item
        /// </summary>
        /// <value>List of the new tags that will be attached to this item</value>
        [DataMember(Name = "add-tag", EmitDefaultValue = false)]
        public List<string> AddTag { get; set; }

        /// <summary>
        /// If set, clients can request certificates for any CN
        /// </summary>
        /// <value>If set, clients can request certificates for any CN</value>
        [DataMember(Name = "allow-any-name", EmitDefaultValue = true)]
        public bool AllowAnyName { get; set; }

        /// <summary>
        /// If set, will allow copying the extra extensions from the csr file (if given)
        /// </summary>
        /// <value>If set, will allow copying the extra extensions from the csr file (if given)</value>
        [DataMember(Name = "allow-copy-ext-from-csr", EmitDefaultValue = true)]
        public bool AllowCopyExtFromCsr { get; set; }

        /// <summary>
        /// If set, clients can request certificates for subdomains of the allowed domains
        /// </summary>
        /// <value>If set, clients can request certificates for subdomains of the allowed domains</value>
        [DataMember(Name = "allow-subdomains", EmitDefaultValue = true)]
        public bool AllowSubdomains { get; set; }

        /// <summary>
        /// A list of the allowed domains that clients can request to be included in the certificate (in a comma-delimited list)
        /// </summary>
        /// <value>A list of the allowed domains that clients can request to be included in the certificate (in a comma-delimited list)</value>
        [DataMember(Name = "allowed-domains", EmitDefaultValue = false)]
        public string AllowedDomains { get; set; }

        /// <summary>
        /// A json string containing the allowed extra extensions for the pki cert issuer
        /// </summary>
        /// <value>A json string containing the allowed extra extensions for the pki cert issuer</value>
        [DataMember(Name = "allowed-extra-extensions", EmitDefaultValue = false)]
        public string AllowedExtraExtensions { get; set; }

        /// <summary>
        /// A list of the allowed CIDRs for ips that clients can request to be included in the certificate as part of the IP Subject Alternative Names (in a comma-delimited list)
        /// </summary>
        /// <value>A list of the allowed CIDRs for ips that clients can request to be included in the certificate as part of the IP Subject Alternative Names (in a comma-delimited list)</value>
        [DataMember(Name = "allowed-ip-sans", EmitDefaultValue = false)]
        public string AllowedIpSans { get; set; }

        /// <summary>
        /// A list of the allowed URIs that clients can request to be included in the certificate as part of the URI Subject Alternative Names (in a comma-delimited list)
        /// </summary>
        /// <value>A list of the allowed URIs that clients can request to be included in the certificate as part of the URI Subject Alternative Names (in a comma-delimited list)</value>
        [DataMember(Name = "allowed-uri-sans", EmitDefaultValue = false)]
        public string AllowedUriSans { get; set; }

        /// <summary>
        /// Automatically renew certificates before expiration
        /// </summary>
        /// <value>Automatically renew certificates before expiration</value>
        [DataMember(Name = "auto-renew", EmitDefaultValue = true)]
        public bool AutoRenew { get; set; }

        /// <summary>
        /// If set, certificates will be flagged for client auth use
        /// </summary>
        /// <value>If set, certificates will be flagged for client auth use</value>
        [DataMember(Name = "client-flag", EmitDefaultValue = true)]
        public bool ClientFlag { get; set; }

        /// <summary>
        /// If set, certificates will be flagged for code signing use
        /// </summary>
        /// <value>If set, certificates will be flagged for code signing use</value>
        [DataMember(Name = "code-signing-flag", EmitDefaultValue = true)]
        public bool CodeSigningFlag { get; set; }

        /// <summary>
        /// A comma-separated list of countries that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of countries that will be set in the issued certificate</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Set this to allow the issuer will expose a CRL endpoint in the Gateway
        /// </summary>
        /// <value>Set this to allow the issuer will expose a CRL endpoint in the Gateway</value>
        [DataMember(Name = "create-private-crl", EmitDefaultValue = true)]
        public bool CreatePrivateCrl { get; set; }

        /// <summary>
        /// Set this to allow the cert issuer will expose a public CRL endpoint
        /// </summary>
        /// <value>Set this to allow the cert issuer will expose a public CRL endpoint</value>
        [DataMember(Name = "create-public-crl", EmitDefaultValue = true)]
        public bool CreatePublicCrl { get; set; }

        /// <summary>
        /// Mark key usage as critical [true/false]
        /// </summary>
        /// <value>Mark key usage as critical [true/false]</value>
        [DataMember(Name = "critical-key-usage", EmitDefaultValue = false)]
        public string CriticalKeyUsage { get; set; }

        /// <summary>
        /// Protection from accidental deletion of this object [true/false]
        /// </summary>
        /// <value>Protection from accidental deletion of this object [true/false]</value>
        [DataMember(Name = "delete_protection", EmitDefaultValue = false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// A path in which to save generated certificates
        /// </summary>
        /// <value>A path in which to save generated certificates</value>
        [DataMember(Name = "destination-path", EmitDefaultValue = false)]
        public string DestinationPath { get; set; }

        /// <summary>
        /// If set, generation of wildcard certificates will be disabled.
        /// </summary>
        /// <value>If set, generation of wildcard certificates will be disabled.</value>
        [DataMember(Name = "disable-wildcards", EmitDefaultValue = true)]
        public bool DisableWildcards { get; set; }

        /// <summary>
        /// If set, the cert issuer will support the acme protocol
        /// </summary>
        /// <value>If set, the cert issuer will support the acme protocol</value>
        [DataMember(Name = "enable-acme", EmitDefaultValue = true)]
        public bool EnableAcme { get; set; }

        /// <summary>
        /// How many days before the expiration of the certificate would you like to be notified.
        /// </summary>
        /// <value>How many days before the expiration of the certificate would you like to be notified.</value>
        [DataMember(Name = "expiration-event-in", EmitDefaultValue = false)]
        public List<string> ExpirationEventIn { get; set; }

        /// <summary>
        /// The GW cluster URL to issue the certificate from. Required in Public CA mode, to allow CRLs on private CA, or to enable ACME
        /// </summary>
        /// <value>The GW cluster URL to issue the certificate from. Required in Public CA mode, to allow CRLs on private CA, or to enable ACME</value>
        [DataMember(Name = "gw-cluster-url", EmitDefaultValue = false)]
        public string GwClusterUrl { get; set; }

        /// <summary>
        /// If set, the basic constraints extension will be added to certificate
        /// </summary>
        /// <value>If set, the basic constraints extension will be added to certificate</value>
        [DataMember(Name = "is-ca", EmitDefaultValue = true)]
        public bool IsCa { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// key-usage
        /// </summary>
        /// <value>key-usage</value>
        [DataMember(Name = "key-usage", EmitDefaultValue = false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// A comma-separated list of localities that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of localities that will be set in the issued certificate</value>
        [DataMember(Name = "locality", EmitDefaultValue = false)]
        public string Locality { get; set; }

        /// <summary>
        /// The maximum path length for the generated certificate. -1, means unlimited
        /// </summary>
        /// <value>The maximum path length for the generated certificate. -1, means unlimited</value>
        [DataMember(Name = "max-path-len", EmitDefaultValue = false)]
        public long MaxPathLen { get; set; }

        /// <summary>
        /// Deprecated - use description
        /// </summary>
        /// <value>Deprecated - use description</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// PKI certificate issuer name
        /// </summary>
        /// <value>PKI certificate issuer name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// New item name
        /// </summary>
        /// <value>New item name</value>
        [DataMember(Name = "new-name", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// If set, any names are allowed for CN and SANs in the certificate and not only a valid host name
        /// </summary>
        /// <value>If set, any names are allowed for CN and SANs in the certificate and not only a valid host name</value>
        [DataMember(Name = "not-enforce-hostnames", EmitDefaultValue = true)]
        public bool NotEnforceHostnames { get; set; }

        /// <summary>
        /// If set, clients can request certificates without a CN
        /// </summary>
        /// <value>If set, clients can request certificates without a CN</value>
        [DataMember(Name = "not-require-cn", EmitDefaultValue = true)]
        public bool NotRequireCn { get; set; }

        /// <summary>
        /// A comma-separated list of organizational units (OU) that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of organizational units (OU) that will be set in the issued certificate</value>
        [DataMember(Name = "organizational-units", EmitDefaultValue = false)]
        public string OrganizationalUnits { get; set; }

        /// <summary>
        /// A comma-separated list of organizations (O) that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of organizations (O) that will be set in the issued certificate</value>
        [DataMember(Name = "organizations", EmitDefaultValue = false)]
        public string Organizations { get; set; }

        /// <summary>
        /// A comma-separated list of postal codes that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of postal codes that will be set in the issued certificate</value>
        [DataMember(Name = "postal-code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Whether to protect generated certificates from deletion
        /// </summary>
        /// <value>Whether to protect generated certificates from deletion</value>
        [DataMember(Name = "protect-certificates", EmitDefaultValue = true)]
        public bool ProtectCertificates { get; set; }

        /// <summary>
        /// A comma-separated list of provinces that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of provinces that will be set in the issued certificate</value>
        [DataMember(Name = "province", EmitDefaultValue = false)]
        public string Province { get; set; }

        /// <summary>
        /// List of the existent tags that will be removed from this item
        /// </summary>
        /// <value>List of the existent tags that will be removed from this item</value>
        [DataMember(Name = "rm-tag", EmitDefaultValue = false)]
        public List<string> RmTag { get; set; }

        /// <summary>
        /// Number of days before expiration to renew certificates
        /// </summary>
        /// <value>Number of days before expiration to renew certificates</value>
        [DataMember(Name = "scheduled-renew", EmitDefaultValue = false)]
        public long ScheduledRenew { get; set; }

        /// <summary>
        /// If set, certificates will be flagged for server auth use
        /// </summary>
        /// <value>If set, certificates will be flagged for server auth use</value>
        [DataMember(Name = "server-flag", EmitDefaultValue = true)]
        public bool ServerFlag { get; set; }

        /// <summary>
        /// A key to sign the certificate with, required in Private CA mode
        /// </summary>
        /// <value>A key to sign the certificate with, required in Private CA mode</value>
        [DataMember(Name = "signer-key-name", EmitDefaultValue = false)]
        public string SignerKeyName { get; set; }

        /// <summary>
        /// A comma-separated list of street addresses that will be set in the issued certificate
        /// </summary>
        /// <value>A comma-separated list of street addresses that will be set in the issued certificate</value>
        [DataMember(Name = "street-address", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// The maximum requested Time To Live for issued certificates, in seconds. In case of Public CA, this is based on the CA target&#39;s supported maximum TTLs
        /// </summary>
        /// <value>The maximum requested Time To Live for issued certificates, in seconds. In case of Public CA, this is based on the CA target&#39;s supported maximum TTLs</value>
        [DataMember(Name = "ttl", IsRequired = true, EmitDefaultValue = true)]
        public string Ttl { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePKICertIssuer {\n");
            sb.Append("  AddTag: ").Append(AddTag).Append("\n");
            sb.Append("  AllowAnyName: ").Append(AllowAnyName).Append("\n");
            sb.Append("  AllowCopyExtFromCsr: ").Append(AllowCopyExtFromCsr).Append("\n");
            sb.Append("  AllowSubdomains: ").Append(AllowSubdomains).Append("\n");
            sb.Append("  AllowedDomains: ").Append(AllowedDomains).Append("\n");
            sb.Append("  AllowedExtraExtensions: ").Append(AllowedExtraExtensions).Append("\n");
            sb.Append("  AllowedIpSans: ").Append(AllowedIpSans).Append("\n");
            sb.Append("  AllowedUriSans: ").Append(AllowedUriSans).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  ClientFlag: ").Append(ClientFlag).Append("\n");
            sb.Append("  CodeSigningFlag: ").Append(CodeSigningFlag).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CreatePrivateCrl: ").Append(CreatePrivateCrl).Append("\n");
            sb.Append("  CreatePublicCrl: ").Append(CreatePublicCrl).Append("\n");
            sb.Append("  CriticalKeyUsage: ").Append(CriticalKeyUsage).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DestinationPath: ").Append(DestinationPath).Append("\n");
            sb.Append("  DisableWildcards: ").Append(DisableWildcards).Append("\n");
            sb.Append("  EnableAcme: ").Append(EnableAcme).Append("\n");
            sb.Append("  ExpirationEventIn: ").Append(ExpirationEventIn).Append("\n");
            sb.Append("  GwClusterUrl: ").Append(GwClusterUrl).Append("\n");
            sb.Append("  IsCa: ").Append(IsCa).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeyUsage: ").Append(KeyUsage).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  MaxPathLen: ").Append(MaxPathLen).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  NotEnforceHostnames: ").Append(NotEnforceHostnames).Append("\n");
            sb.Append("  NotRequireCn: ").Append(NotRequireCn).Append("\n");
            sb.Append("  OrganizationalUnits: ").Append(OrganizationalUnits).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ProtectCertificates: ").Append(ProtectCertificates).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  RmTag: ").Append(RmTag).Append("\n");
            sb.Append("  ScheduledRenew: ").Append(ScheduledRenew).Append("\n");
            sb.Append("  ServerFlag: ").Append(ServerFlag).Append("\n");
            sb.Append("  SignerKeyName: ").Append(SignerKeyName).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
