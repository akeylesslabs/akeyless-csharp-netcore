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
    /// CreateSecret
    /// </summary>
    [DataContract(Name = "createSecret")]
    public partial class CreateSecret : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecret" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSecret() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSecret" /> class.
        /// </summary>
        /// <param name="accessibility">for personal password manager (default to &quot;regular&quot;).</param>
        /// <param name="changeEvent">Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret).</param>
        /// <param name="customField">For Password Management use, additional fields.</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="format">Secret format [text/json/key-value] (relevant only for type &#39;generic&#39;) (default to &quot;text&quot;).</param>
        /// <param name="injectUrl">For Password Management use, reflect the website context.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="metadata">Deprecated - use description.</param>
        /// <param name="multilineValue">The provided value is a multiline value (separated by &#39;\\n&#39;).</param>
        /// <param name="name">Secret name (required).</param>
        /// <param name="password">For Password Management use, additional fields.</param>
        /// <param name="protectionKey">The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="secureAccessBastionIssuer">Deprecated. use secure-access-certificate-issuer.</param>
        /// <param name="secureAccessCertificateIssuer">Path to the SSH Certificate Issuer for your Akeyless Secure Access.</param>
        /// <param name="secureAccessEnable">Enable/Disable secure remote access [true/false].</param>
        /// <param name="secureAccessGateway">secureAccessGateway.</param>
        /// <param name="secureAccessHost">Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers).</param>
        /// <param name="secureAccessRdpUser">Remote Desktop Username.</param>
        /// <param name="secureAccessSshCreds">Static-Secret values contains SSH Credentials, either Private Key or Password [password/private-key].</param>
        /// <param name="secureAccessSshUser">Override the SSH username as indicated in SSH Certificate Issuer.</param>
        /// <param name="secureAccessUrl">Destination URL to inject secrets.</param>
        /// <param name="secureAccessWebBrowsing">Secure browser via Akeyless&#39;s Secure Remote Access (SRA) (default to false).</param>
        /// <param name="secureAccessWebProxy">Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) (default to false).</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="type">The secret sub type [generic/password] (default to &quot;generic&quot;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="username">For Password Management use.</param>
        /// <param name="value">The secret value (relevant only for type &#39;generic&#39;) (required).</param>
        public CreateSecret(string accessibility = @"regular", string changeEvent = default(string), Dictionary<string, string> customField = default(Dictionary<string, string>), string deleteProtection = default(string), string description = default(string), string format = @"text", List<string> injectUrl = default(List<string>), bool json = false, string maxVersions = default(string), string metadata = default(string), bool multilineValue = default(bool), string name = default(string), string password = default(string), string protectionKey = default(string), string secureAccessBastionIssuer = default(string), string secureAccessCertificateIssuer = default(string), string secureAccessEnable = default(string), string secureAccessGateway = default(string), List<string> secureAccessHost = default(List<string>), string secureAccessRdpUser = default(string), string secureAccessSshCreds = default(string), string secureAccessSshUser = default(string), string secureAccessUrl = default(string), bool secureAccessWebBrowsing = false, bool secureAccessWebProxy = false, List<string> tags = default(List<string>), string token = default(string), string type = @"generic", string uidToken = default(string), string username = default(string), string value = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CreateSecret and cannot be null");
            }
            this.Name = name;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for CreateSecret and cannot be null");
            }
            this.Value = value;
            // use default value if no "accessibility" provided
            this.Accessibility = accessibility ?? @"regular";
            this.ChangeEvent = changeEvent;
            this.CustomField = customField;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            // use default value if no "format" provided
            this.Format = format ?? @"text";
            this.InjectUrl = injectUrl;
            this.Json = json;
            this.MaxVersions = maxVersions;
            this.Metadata = metadata;
            this.MultilineValue = multilineValue;
            this.Password = password;
            this.ProtectionKey = protectionKey;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessCertificateIssuer = secureAccessCertificateIssuer;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessGateway = secureAccessGateway;
            this.SecureAccessHost = secureAccessHost;
            this.SecureAccessRdpUser = secureAccessRdpUser;
            this.SecureAccessSshCreds = secureAccessSshCreds;
            this.SecureAccessSshUser = secureAccessSshUser;
            this.SecureAccessUrl = secureAccessUrl;
            this.SecureAccessWebBrowsing = secureAccessWebBrowsing;
            this.SecureAccessWebProxy = secureAccessWebProxy;
            this.Tags = tags;
            this.Token = token;
            // use default value if no "type" provided
            this.Type = type ?? @"generic";
            this.UidToken = uidToken;
            this.Username = username;
        }

        /// <summary>
        /// for personal password manager
        /// </summary>
        /// <value>for personal password manager</value>
        [DataMember(Name = "accessibility", EmitDefaultValue = false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret)
        /// </summary>
        /// <value>Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret)</value>
        [DataMember(Name = "change-event", EmitDefaultValue = false)]
        public string ChangeEvent { get; set; }

        /// <summary>
        /// For Password Management use, additional fields
        /// </summary>
        /// <value>For Password Management use, additional fields</value>
        [DataMember(Name = "custom-field", EmitDefaultValue = false)]
        public Dictionary<string, string> CustomField { get; set; }

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
        /// Secret format [text/json/key-value] (relevant only for type &#39;generic&#39;)
        /// </summary>
        /// <value>Secret format [text/json/key-value] (relevant only for type &#39;generic&#39;)</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// For Password Management use, reflect the website context
        /// </summary>
        /// <value>For Password Management use, reflect the website context</value>
        [DataMember(Name = "inject-url", EmitDefaultValue = false)]
        public List<string> InjectUrl { get; set; }

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
        /// Deprecated - use description
        /// </summary>
        /// <value>Deprecated - use description</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// The provided value is a multiline value (separated by &#39;\\n&#39;)
        /// </summary>
        /// <value>The provided value is a multiline value (separated by &#39;\\n&#39;)</value>
        [DataMember(Name = "multiline_value", EmitDefaultValue = true)]
        public bool MultilineValue { get; set; }

        /// <summary>
        /// Secret name
        /// </summary>
        /// <value>Secret name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// For Password Management use, additional fields
        /// </summary>
        /// <value>For Password Management use, additional fields</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "protection_key", EmitDefaultValue = false)]
        public string ProtectionKey { get; set; }

        /// <summary>
        /// Deprecated. use secure-access-certificate-issuer
        /// </summary>
        /// <value>Deprecated. use secure-access-certificate-issuer</value>
        [DataMember(Name = "secure-access-bastion-issuer", EmitDefaultValue = false)]
        public string SecureAccessBastionIssuer { get; set; }

        /// <summary>
        /// Path to the SSH Certificate Issuer for your Akeyless Secure Access
        /// </summary>
        /// <value>Path to the SSH Certificate Issuer for your Akeyless Secure Access</value>
        [DataMember(Name = "secure-access-certificate-issuer", EmitDefaultValue = false)]
        public string SecureAccessCertificateIssuer { get; set; }

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
        /// Remote Desktop Username
        /// </summary>
        /// <value>Remote Desktop Username</value>
        [DataMember(Name = "secure-access-rdp-user", EmitDefaultValue = false)]
        public string SecureAccessRdpUser { get; set; }

        /// <summary>
        /// Static-Secret values contains SSH Credentials, either Private Key or Password [password/private-key]
        /// </summary>
        /// <value>Static-Secret values contains SSH Credentials, either Private Key or Password [password/private-key]</value>
        [DataMember(Name = "secure-access-ssh-creds", EmitDefaultValue = false)]
        public string SecureAccessSshCreds { get; set; }

        /// <summary>
        /// Override the SSH username as indicated in SSH Certificate Issuer
        /// </summary>
        /// <value>Override the SSH username as indicated in SSH Certificate Issuer</value>
        [DataMember(Name = "secure-access-ssh-user", EmitDefaultValue = false)]
        public string SecureAccessSshUser { get; set; }

        /// <summary>
        /// Destination URL to inject secrets
        /// </summary>
        /// <value>Destination URL to inject secrets</value>
        [DataMember(Name = "secure-access-url", EmitDefaultValue = false)]
        public string SecureAccessUrl { get; set; }

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
        /// Add tags attached to this object
        /// </summary>
        /// <value>Add tags attached to this object</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// The secret sub type [generic/password]
        /// </summary>
        /// <value>The secret sub type [generic/password]</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name = "uid-token", EmitDefaultValue = false)]
        public string UidToken { get; set; }

        /// <summary>
        /// For Password Management use
        /// </summary>
        /// <value>For Password Management use</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The secret value (relevant only for type &#39;generic&#39;)
        /// </summary>
        /// <value>The secret value (relevant only for type &#39;generic&#39;)</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSecret {\n");
            sb.Append("  Accessibility: ").Append(Accessibility).Append("\n");
            sb.Append("  ChangeEvent: ").Append(ChangeEvent).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  InjectUrl: ").Append(InjectUrl).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MultilineValue: ").Append(MultilineValue).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProtectionKey: ").Append(ProtectionKey).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessCertificateIssuer: ").Append(SecureAccessCertificateIssuer).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessGateway: ").Append(SecureAccessGateway).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
            sb.Append("  SecureAccessRdpUser: ").Append(SecureAccessRdpUser).Append("\n");
            sb.Append("  SecureAccessSshCreds: ").Append(SecureAccessSshCreds).Append("\n");
            sb.Append("  SecureAccessSshUser: ").Append(SecureAccessSshUser).Append("\n");
            sb.Append("  SecureAccessUrl: ").Append(SecureAccessUrl).Append("\n");
            sb.Append("  SecureAccessWebBrowsing: ").Append(SecureAccessWebBrowsing).Append("\n");
            sb.Append("  SecureAccessWebProxy: ").Append(SecureAccessWebProxy).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
