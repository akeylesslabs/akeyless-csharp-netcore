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
    /// UpdateItem
    /// </summary>
    [DataContract(Name = "updateItem")]
    public partial class UpdateItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateItem" /> class.
        /// </summary>
        /// <param name="providerType">providerType.</param>
        /// <param name="accessibility">for personal password manager (default to &quot;regular&quot;).</param>
        /// <param name="addTag">List of the new tags that will be attached to this item.</param>
        /// <param name="certFileData">PEM Certificate in a Base64 format. Used for updating RSA keys&#39; certificates..</param>
        /// <param name="certificateFormat">certificateFormat.</param>
        /// <param name="changeEvent">Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret).</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Description of the object (default to &quot;default_metadata&quot;).</param>
        /// <param name="expirationEventIn">How many days before the expiration of the certificate would you like to be notified..</param>
        /// <param name="hostProvider">Host provider type [explicit/target], Default Host provider is explicit, Relevant only for Secure Remote Access of ssh cert issuer, ldap rotated secret and ldap dynamic secret.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Current item name (required).</param>
        /// <param name="newMetadata">Deprecated - use description (default to &quot;default_metadata&quot;).</param>
        /// <param name="newName">New item name.</param>
        /// <param name="rmTag">List of the existent tags that will be removed from this item.</param>
        /// <param name="rotateAfterDisconnect">Rotate the value of the secret after SRA session ends [true/false] (default to &quot;false&quot;).</param>
        /// <param name="secureAccessAddHost">List of the new hosts that will be attached to SRA servers host.</param>
        /// <param name="secureAccessAllowExternalUser">Allow providing external user for a domain users [true/false].</param>
        /// <param name="secureAccessAllowPortForwading">Enable Port forwarding while using CLI access (relevant only for EKS/GKE/K8s Dynamic-Secret).</param>
        /// <param name="secureAccessApi">Bastion&#39;s SSH control API endpoint. E.g. https://my.sra-server:9900 (relevant only for ssh cert issuer).</param>
        /// <param name="secureAccessAwsAccountId">The AWS account id (relevant only for aws).</param>
        /// <param name="secureAccessAwsNativeCli">The AWS native cli (relevant only for aws).</param>
        /// <param name="secureAccessAwsRegion">The AWS region (relevant only for aws).</param>
        /// <param name="secureAccessBastionApi">Deprecated. use secure-access-api.</param>
        /// <param name="secureAccessBastionIssuer">Deprecated. use secure-access-certificate-issuer.</param>
        /// <param name="secureAccessBastionSsh">Deprecated. use secure-access-ssh.</param>
        /// <param name="secureAccessCertificateIssuer">Path to the SSH Certificate Issuer for your Akeyless Secure Access.</param>
        /// <param name="secureAccessClusterEndpoint">The K8s cluster endpoint URL (relevant only for EKS/GKE/K8s Dynamic-Secret).</param>
        /// <param name="secureAccessDashboardUrl">The K8s dashboard url (relevant only for k8s).</param>
        /// <param name="secureAccessDbName">The DB name (relevant only for DB Dynamic-Secret).</param>
        /// <param name="secureAccessDbSchema">The DB schema (relevant only for DB Dynamic-Secret).</param>
        /// <param name="secureAccessEnable">Enable/Disable secure remote access [true/false].</param>
        /// <param name="secureAccessGateway">secureAccessGateway.</param>
        /// <param name="secureAccessHost">Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers).</param>
        /// <param name="secureAccessRdGatewayServer">RD Gateway server (relevant only for rdp).</param>
        /// <param name="secureAccessRdpDomain">Required when the Dynamic Secret is used for a domain user (relevant only for RDP Dynamic-Secret).</param>
        /// <param name="secureAccessRdpUser">Override the RDP Domain username.</param>
        /// <param name="secureAccessRmHost">List of the existent hosts that will be removed from SRA servers host.</param>
        /// <param name="secureAccessSsh">Bastion&#39;s SSH server. E.g. my.sra-server:22 (relevant only for ssh cert issuer).</param>
        /// <param name="secureAccessSshCreds">Secret values contains SSH Credentials, either Private Key or Password [password/private-key] (relevant only for Static-Secret or Rotated-secret).</param>
        /// <param name="secureAccessSshCredsUser">SSH username to connect to target server, must be in &#39;Allowed Users&#39; list (relevant only for ssh cert issuer).</param>
        /// <param name="secureAccessUrl">Destination URL to inject secrets.</param>
        /// <param name="secureAccessUseInternalBastion">Deprecated. Use secure-access-use-internal-ssh-access.</param>
        /// <param name="secureAccessUseInternalSshAccess">Use internal SSH Access.</param>
        /// <param name="secureAccessWebBrowsing">Secure browser via Akeyless&#39;s Secure Remote Access (SRA) (default to false).</param>
        /// <param name="secureAccessWebProxy">Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) (default to false).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public UpdateItem(string providerType = default(string), string accessibility = @"regular", List<string> addTag = default(List<string>), string certFileData = default(string), string certificateFormat = default(string), string changeEvent = default(string), string deleteProtection = default(string), string description = @"default_metadata", List<string> expirationEventIn = default(List<string>), string hostProvider = default(string), bool json = false, string maxVersions = default(string), string name = default(string), string newMetadata = @"default_metadata", string newName = default(string), List<string> rmTag = default(List<string>), string rotateAfterDisconnect = @"false", List<string> secureAccessAddHost = default(List<string>), string secureAccessAllowExternalUser = default(string), bool secureAccessAllowPortForwading = default(bool), string secureAccessApi = default(string), string secureAccessAwsAccountId = default(string), bool secureAccessAwsNativeCli = default(bool), string secureAccessAwsRegion = default(string), string secureAccessBastionApi = default(string), string secureAccessBastionIssuer = default(string), string secureAccessBastionSsh = default(string), string secureAccessCertificateIssuer = default(string), string secureAccessClusterEndpoint = default(string), string secureAccessDashboardUrl = default(string), string secureAccessDbName = default(string), string secureAccessDbSchema = default(string), string secureAccessEnable = default(string), string secureAccessGateway = default(string), List<string> secureAccessHost = default(List<string>), string secureAccessRdGatewayServer = default(string), string secureAccessRdpDomain = default(string), string secureAccessRdpUser = default(string), List<string> secureAccessRmHost = default(List<string>), string secureAccessSsh = default(string), string secureAccessSshCreds = default(string), string secureAccessSshCredsUser = default(string), string secureAccessUrl = default(string), bool secureAccessUseInternalBastion = default(bool), bool secureAccessUseInternalSshAccess = default(bool), bool secureAccessWebBrowsing = false, bool secureAccessWebProxy = false, string token = default(string), string uidToken = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateItem and cannot be null");
            }
            this.Name = name;
            this.ProviderType = providerType;
            // use default value if no "accessibility" provided
            this.Accessibility = accessibility ?? @"regular";
            this.AddTag = addTag;
            this.CertFileData = certFileData;
            this.CertificateFormat = certificateFormat;
            this.ChangeEvent = changeEvent;
            this.DeleteProtection = deleteProtection;
            // use default value if no "description" provided
            this.Description = description ?? @"default_metadata";
            this.ExpirationEventIn = expirationEventIn;
            this.HostProvider = hostProvider;
            this.Json = json;
            this.MaxVersions = maxVersions;
            // use default value if no "newMetadata" provided
            this.NewMetadata = newMetadata ?? @"default_metadata";
            this.NewName = newName;
            this.RmTag = rmTag;
            // use default value if no "rotateAfterDisconnect" provided
            this.RotateAfterDisconnect = rotateAfterDisconnect ?? @"false";
            this.SecureAccessAddHost = secureAccessAddHost;
            this.SecureAccessAllowExternalUser = secureAccessAllowExternalUser;
            this.SecureAccessAllowPortForwading = secureAccessAllowPortForwading;
            this.SecureAccessApi = secureAccessApi;
            this.SecureAccessAwsAccountId = secureAccessAwsAccountId;
            this.SecureAccessAwsNativeCli = secureAccessAwsNativeCli;
            this.SecureAccessAwsRegion = secureAccessAwsRegion;
            this.SecureAccessBastionApi = secureAccessBastionApi;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessBastionSsh = secureAccessBastionSsh;
            this.SecureAccessCertificateIssuer = secureAccessCertificateIssuer;
            this.SecureAccessClusterEndpoint = secureAccessClusterEndpoint;
            this.SecureAccessDashboardUrl = secureAccessDashboardUrl;
            this.SecureAccessDbName = secureAccessDbName;
            this.SecureAccessDbSchema = secureAccessDbSchema;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessGateway = secureAccessGateway;
            this.SecureAccessHost = secureAccessHost;
            this.SecureAccessRdGatewayServer = secureAccessRdGatewayServer;
            this.SecureAccessRdpDomain = secureAccessRdpDomain;
            this.SecureAccessRdpUser = secureAccessRdpUser;
            this.SecureAccessRmHost = secureAccessRmHost;
            this.SecureAccessSsh = secureAccessSsh;
            this.SecureAccessSshCreds = secureAccessSshCreds;
            this.SecureAccessSshCredsUser = secureAccessSshCredsUser;
            this.SecureAccessUrl = secureAccessUrl;
            this.SecureAccessUseInternalBastion = secureAccessUseInternalBastion;
            this.SecureAccessUseInternalSshAccess = secureAccessUseInternalSshAccess;
            this.SecureAccessWebBrowsing = secureAccessWebBrowsing;
            this.SecureAccessWebProxy = secureAccessWebProxy;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Gets or Sets ProviderType
        /// </summary>
        [DataMember(Name = "ProviderType", EmitDefaultValue = false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// for personal password manager
        /// </summary>
        /// <value>for personal password manager</value>
        [DataMember(Name = "accessibility", EmitDefaultValue = false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// List of the new tags that will be attached to this item
        /// </summary>
        /// <value>List of the new tags that will be attached to this item</value>
        [DataMember(Name = "add-tag", EmitDefaultValue = false)]
        public List<string> AddTag { get; set; }

        /// <summary>
        /// PEM Certificate in a Base64 format. Used for updating RSA keys&#39; certificates.
        /// </summary>
        /// <value>PEM Certificate in a Base64 format. Used for updating RSA keys&#39; certificates.</value>
        [DataMember(Name = "cert-file-data", EmitDefaultValue = false)]
        public string CertFileData { get; set; }

        /// <summary>
        /// Gets or Sets CertificateFormat
        /// </summary>
        [DataMember(Name = "certificate-format", EmitDefaultValue = false)]
        public string CertificateFormat { get; set; }

        /// <summary>
        /// Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret)
        /// </summary>
        /// <value>Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret)</value>
        [DataMember(Name = "change-event", EmitDefaultValue = false)]
        public string ChangeEvent { get; set; }

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
        /// How many days before the expiration of the certificate would you like to be notified.
        /// </summary>
        /// <value>How many days before the expiration of the certificate would you like to be notified.</value>
        [DataMember(Name = "expiration-event-in", EmitDefaultValue = false)]
        public List<string> ExpirationEventIn { get; set; }

        /// <summary>
        /// Host provider type [explicit/target], Default Host provider is explicit, Relevant only for Secure Remote Access of ssh cert issuer, ldap rotated secret and ldap dynamic secret
        /// </summary>
        /// <value>Host provider type [explicit/target], Default Host provider is explicit, Relevant only for Secure Remote Access of ssh cert issuer, ldap rotated secret and ldap dynamic secret</value>
        [DataMember(Name = "host-provider", EmitDefaultValue = false)]
        public string HostProvider { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Current item name
        /// </summary>
        /// <value>Current item name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Deprecated - use description
        /// </summary>
        /// <value>Deprecated - use description</value>
        [DataMember(Name = "new-metadata", EmitDefaultValue = false)]
        public string NewMetadata { get; set; }

        /// <summary>
        /// New item name
        /// </summary>
        /// <value>New item name</value>
        [DataMember(Name = "new-name", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// List of the existent tags that will be removed from this item
        /// </summary>
        /// <value>List of the existent tags that will be removed from this item</value>
        [DataMember(Name = "rm-tag", EmitDefaultValue = false)]
        public List<string> RmTag { get; set; }

        /// <summary>
        /// Rotate the value of the secret after SRA session ends [true/false]
        /// </summary>
        /// <value>Rotate the value of the secret after SRA session ends [true/false]</value>
        [DataMember(Name = "rotate-after-disconnect", EmitDefaultValue = false)]
        public string RotateAfterDisconnect { get; set; }

        /// <summary>
        /// List of the new hosts that will be attached to SRA servers host
        /// </summary>
        /// <value>List of the new hosts that will be attached to SRA servers host</value>
        [DataMember(Name = "secure-access-add-host", EmitDefaultValue = false)]
        public List<string> SecureAccessAddHost { get; set; }

        /// <summary>
        /// Allow providing external user for a domain users [true/false]
        /// </summary>
        /// <value>Allow providing external user for a domain users [true/false]</value>
        [DataMember(Name = "secure-access-allow-external-user", EmitDefaultValue = false)]
        public string SecureAccessAllowExternalUser { get; set; }

        /// <summary>
        /// Enable Port forwarding while using CLI access (relevant only for EKS/GKE/K8s Dynamic-Secret)
        /// </summary>
        /// <value>Enable Port forwarding while using CLI access (relevant only for EKS/GKE/K8s Dynamic-Secret)</value>
        [DataMember(Name = "secure-access-allow-port-forwading", EmitDefaultValue = true)]
        public bool SecureAccessAllowPortForwading { get; set; }

        /// <summary>
        /// Bastion&#39;s SSH control API endpoint. E.g. https://my.sra-server:9900 (relevant only for ssh cert issuer)
        /// </summary>
        /// <value>Bastion&#39;s SSH control API endpoint. E.g. https://my.sra-server:9900 (relevant only for ssh cert issuer)</value>
        [DataMember(Name = "secure-access-api", EmitDefaultValue = false)]
        public string SecureAccessApi { get; set; }

        /// <summary>
        /// The AWS account id (relevant only for aws)
        /// </summary>
        /// <value>The AWS account id (relevant only for aws)</value>
        [DataMember(Name = "secure-access-aws-account-id", EmitDefaultValue = false)]
        public string SecureAccessAwsAccountId { get; set; }

        /// <summary>
        /// The AWS native cli (relevant only for aws)
        /// </summary>
        /// <value>The AWS native cli (relevant only for aws)</value>
        [DataMember(Name = "secure-access-aws-native-cli", EmitDefaultValue = true)]
        public bool SecureAccessAwsNativeCli { get; set; }

        /// <summary>
        /// The AWS region (relevant only for aws)
        /// </summary>
        /// <value>The AWS region (relevant only for aws)</value>
        [DataMember(Name = "secure-access-aws-region", EmitDefaultValue = false)]
        public string SecureAccessAwsRegion { get; set; }

        /// <summary>
        /// Deprecated. use secure-access-api
        /// </summary>
        /// <value>Deprecated. use secure-access-api</value>
        [DataMember(Name = "secure-access-bastion-api", EmitDefaultValue = false)]
        public string SecureAccessBastionApi { get; set; }

        /// <summary>
        /// Deprecated. use secure-access-certificate-issuer
        /// </summary>
        /// <value>Deprecated. use secure-access-certificate-issuer</value>
        [DataMember(Name = "secure-access-bastion-issuer", EmitDefaultValue = false)]
        public string SecureAccessBastionIssuer { get; set; }

        /// <summary>
        /// Deprecated. use secure-access-ssh
        /// </summary>
        /// <value>Deprecated. use secure-access-ssh</value>
        [DataMember(Name = "secure-access-bastion-ssh", EmitDefaultValue = false)]
        public string SecureAccessBastionSsh { get; set; }

        /// <summary>
        /// Path to the SSH Certificate Issuer for your Akeyless Secure Access
        /// </summary>
        /// <value>Path to the SSH Certificate Issuer for your Akeyless Secure Access</value>
        [DataMember(Name = "secure-access-certificate-issuer", EmitDefaultValue = false)]
        public string SecureAccessCertificateIssuer { get; set; }

        /// <summary>
        /// The K8s cluster endpoint URL (relevant only for EKS/GKE/K8s Dynamic-Secret)
        /// </summary>
        /// <value>The K8s cluster endpoint URL (relevant only for EKS/GKE/K8s Dynamic-Secret)</value>
        [DataMember(Name = "secure-access-cluster-endpoint", EmitDefaultValue = false)]
        public string SecureAccessClusterEndpoint { get; set; }

        /// <summary>
        /// The K8s dashboard url (relevant only for k8s)
        /// </summary>
        /// <value>The K8s dashboard url (relevant only for k8s)</value>
        [DataMember(Name = "secure-access-dashboard-url", EmitDefaultValue = false)]
        public string SecureAccessDashboardUrl { get; set; }

        /// <summary>
        /// The DB name (relevant only for DB Dynamic-Secret)
        /// </summary>
        /// <value>The DB name (relevant only for DB Dynamic-Secret)</value>
        [DataMember(Name = "secure-access-db-name", EmitDefaultValue = false)]
        public string SecureAccessDbName { get; set; }

        /// <summary>
        /// The DB schema (relevant only for DB Dynamic-Secret)
        /// </summary>
        /// <value>The DB schema (relevant only for DB Dynamic-Secret)</value>
        [DataMember(Name = "secure-access-db-schema", EmitDefaultValue = false)]
        public string SecureAccessDbSchema { get; set; }

        /// <summary>
        /// Enable/Disable secure remote access [true/false]
        /// </summary>
        /// <value>Enable/Disable secure remote access [true/false]</value>
        [DataMember(Name = "secure-access-enable", EmitDefaultValue = false)]
        public string SecureAccessEnable { get; set; }

        /// <summary>
        /// Gets or Sets SecureAccessGateway
        /// </summary>
        [DataMember(Name = "secure-access-gateway", EmitDefaultValue = false)]
        public string SecureAccessGateway { get; set; }

        /// <summary>
        /// Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers)
        /// </summary>
        /// <value>Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers)</value>
        [DataMember(Name = "secure-access-host", EmitDefaultValue = false)]
        public List<string> SecureAccessHost { get; set; }

        /// <summary>
        /// RD Gateway server (relevant only for rdp)
        /// </summary>
        /// <value>RD Gateway server (relevant only for rdp)</value>
        [DataMember(Name = "secure-access-rd-gateway-server", EmitDefaultValue = false)]
        public string SecureAccessRdGatewayServer { get; set; }

        /// <summary>
        /// Required when the Dynamic Secret is used for a domain user (relevant only for RDP Dynamic-Secret)
        /// </summary>
        /// <value>Required when the Dynamic Secret is used for a domain user (relevant only for RDP Dynamic-Secret)</value>
        [DataMember(Name = "secure-access-rdp-domain", EmitDefaultValue = false)]
        public string SecureAccessRdpDomain { get; set; }

        /// <summary>
        /// Override the RDP Domain username
        /// </summary>
        /// <value>Override the RDP Domain username</value>
        [DataMember(Name = "secure-access-rdp-user", EmitDefaultValue = false)]
        public string SecureAccessRdpUser { get; set; }

        /// <summary>
        /// List of the existent hosts that will be removed from SRA servers host
        /// </summary>
        /// <value>List of the existent hosts that will be removed from SRA servers host</value>
        [DataMember(Name = "secure-access-rm-host", EmitDefaultValue = false)]
        public List<string> SecureAccessRmHost { get; set; }

        /// <summary>
        /// Bastion&#39;s SSH server. E.g. my.sra-server:22 (relevant only for ssh cert issuer)
        /// </summary>
        /// <value>Bastion&#39;s SSH server. E.g. my.sra-server:22 (relevant only for ssh cert issuer)</value>
        [DataMember(Name = "secure-access-ssh", EmitDefaultValue = false)]
        public string SecureAccessSsh { get; set; }

        /// <summary>
        /// Secret values contains SSH Credentials, either Private Key or Password [password/private-key] (relevant only for Static-Secret or Rotated-secret)
        /// </summary>
        /// <value>Secret values contains SSH Credentials, either Private Key or Password [password/private-key] (relevant only for Static-Secret or Rotated-secret)</value>
        [DataMember(Name = "secure-access-ssh-creds", EmitDefaultValue = false)]
        public string SecureAccessSshCreds { get; set; }

        /// <summary>
        /// SSH username to connect to target server, must be in &#39;Allowed Users&#39; list (relevant only for ssh cert issuer)
        /// </summary>
        /// <value>SSH username to connect to target server, must be in &#39;Allowed Users&#39; list (relevant only for ssh cert issuer)</value>
        [DataMember(Name = "secure-access-ssh-creds-user", EmitDefaultValue = false)]
        public string SecureAccessSshCredsUser { get; set; }

        /// <summary>
        /// Destination URL to inject secrets
        /// </summary>
        /// <value>Destination URL to inject secrets</value>
        [DataMember(Name = "secure-access-url", EmitDefaultValue = false)]
        public string SecureAccessUrl { get; set; }

        /// <summary>
        /// Deprecated. Use secure-access-use-internal-ssh-access
        /// </summary>
        /// <value>Deprecated. Use secure-access-use-internal-ssh-access</value>
        [DataMember(Name = "secure-access-use-internal-bastion", EmitDefaultValue = true)]
        public bool SecureAccessUseInternalBastion { get; set; }

        /// <summary>
        /// Use internal SSH Access
        /// </summary>
        /// <value>Use internal SSH Access</value>
        [DataMember(Name = "secure-access-use-internal-ssh-access", EmitDefaultValue = true)]
        public bool SecureAccessUseInternalSshAccess { get; set; }

        /// <summary>
        /// Secure browser via Akeyless&#39;s Secure Remote Access (SRA)
        /// </summary>
        /// <value>Secure browser via Akeyless&#39;s Secure Remote Access (SRA)</value>
        [DataMember(Name = "secure-access-web-browsing", EmitDefaultValue = true)]
        public bool SecureAccessWebBrowsing { get; set; }

        /// <summary>
        /// Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA)
        /// </summary>
        /// <value>Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA)</value>
        [DataMember(Name = "secure-access-web-proxy", EmitDefaultValue = true)]
        public bool SecureAccessWebProxy { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

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
            sb.Append("class UpdateItem {\n");
            sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  AddTag: ").Append(AddTag).Append("\n");
            sb.Append("  CertFileData: ").Append(CertFileData).Append("\n");
            sb.Append("  CertificateFormat: ").Append(CertificateFormat).Append("\n");
            sb.Append("  ChangeEvent: ").Append(ChangeEvent).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpirationEventIn: ").Append(ExpirationEventIn).Append("\n");
            sb.Append("  HostProvider: ").Append(HostProvider).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewMetadata: ").Append(NewMetadata).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  RmTag: ").Append(RmTag).Append("\n");
            sb.Append("  RotateAfterDisconnect: ").Append(RotateAfterDisconnect).Append("\n");
            sb.Append("  SecureAccessAddHost: ").Append(SecureAccessAddHost).Append("\n");
            sb.Append("  SecureAccessAllowExternalUser: ").Append(SecureAccessAllowExternalUser).Append("\n");
            sb.Append("  SecureAccessAllowPortForwading: ").Append(SecureAccessAllowPortForwading).Append("\n");
            sb.Append("  SecureAccessApi: ").Append(SecureAccessApi).Append("\n");
            sb.Append("  SecureAccessAwsAccountId: ").Append(SecureAccessAwsAccountId).Append("\n");
            sb.Append("  SecureAccessAwsNativeCli: ").Append(SecureAccessAwsNativeCli).Append("\n");
            sb.Append("  SecureAccessAwsRegion: ").Append(SecureAccessAwsRegion).Append("\n");
            sb.Append("  SecureAccessBastionApi: ").Append(SecureAccessBastionApi).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessBastionSsh: ").Append(SecureAccessBastionSsh).Append("\n");
            sb.Append("  SecureAccessCertificateIssuer: ").Append(SecureAccessCertificateIssuer).Append("\n");
            sb.Append("  SecureAccessClusterEndpoint: ").Append(SecureAccessClusterEndpoint).Append("\n");
            sb.Append("  SecureAccessDashboardUrl: ").Append(SecureAccessDashboardUrl).Append("\n");
            sb.Append("  SecureAccessDbName: ").Append(SecureAccessDbName).Append("\n");
            sb.Append("  SecureAccessDbSchema: ").Append(SecureAccessDbSchema).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessGateway: ").Append(SecureAccessGateway).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
            sb.Append("  SecureAccessRdGatewayServer: ").Append(SecureAccessRdGatewayServer).Append("\n");
            sb.Append("  SecureAccessRdpDomain: ").Append(SecureAccessRdpDomain).Append("\n");
            sb.Append("  SecureAccessRdpUser: ").Append(SecureAccessRdpUser).Append("\n");
            sb.Append("  SecureAccessRmHost: ").Append(SecureAccessRmHost).Append("\n");
            sb.Append("  SecureAccessSsh: ").Append(SecureAccessSsh).Append("\n");
            sb.Append("  SecureAccessSshCreds: ").Append(SecureAccessSshCreds).Append("\n");
            sb.Append("  SecureAccessSshCredsUser: ").Append(SecureAccessSshCredsUser).Append("\n");
            sb.Append("  SecureAccessUrl: ").Append(SecureAccessUrl).Append("\n");
            sb.Append("  SecureAccessUseInternalBastion: ").Append(SecureAccessUseInternalBastion).Append("\n");
            sb.Append("  SecureAccessUseInternalSshAccess: ").Append(SecureAccessUseInternalSshAccess).Append("\n");
            sb.Append("  SecureAccessWebBrowsing: ").Append(SecureAccessWebBrowsing).Append("\n");
            sb.Append("  SecureAccessWebProxy: ").Append(SecureAccessWebProxy).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
