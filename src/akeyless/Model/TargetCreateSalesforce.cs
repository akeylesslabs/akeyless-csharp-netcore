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
    /// targetCreateSalesforce is a command that creates a new Salesforce target
    /// </summary>
    [DataContract(Name = "targetCreateSalesforce")]
    public partial class TargetCreateSalesforce : IEquatable<TargetCreateSalesforce>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateSalesforce" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetCreateSalesforce() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateSalesforce" /> class.
        /// </summary>
        /// <param name="appPrivateKeyData">Base64 encoded PEM of the connected app private key (relevant for JWT auth only).</param>
        /// <param name="authFlow">type of the auth flow (&#39;jwt&#39; / &#39;user-password&#39;) (required).</param>
        /// <param name="caCertData">Base64 encoded PEM cert to use when uploading a new key to Salesforce.</param>
        /// <param name="caCertName">name of the certificate in Salesforce tenant to use when uploading new key.</param>
        /// <param name="clientId">Client ID of the oauth2 app to use for connecting to Salesforce (required).</param>
        /// <param name="clientSecret">Client secret of the oauth2 app to use for connecting to Salesforce (required for password flow).</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="email">The email of the user attached to the oauth2 app used for connecting to Salesforce (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="password">The password of the user attached to the oauth2 app used for connecting to Salesforce (required for user-password flow).</param>
        /// <param name="securityToken">The security token of the user attached to the oauth2 app used for connecting to Salesforce  (required for user-password flow).</param>
        /// <param name="tenantUrl">Url of the Salesforce tenant (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public TargetCreateSalesforce(string appPrivateKeyData = default(string), string authFlow = default(string), string caCertData = default(string), string caCertName = default(string), string clientId = default(string), string clientSecret = default(string), string description = default(string), string email = default(string), bool json = false, string key = default(string), string maxVersions = default(string), string name = default(string), string password = default(string), string securityToken = default(string), string tenantUrl = default(string), string token = default(string), string uidToken = default(string))
        {
            // to ensure "authFlow" is required (not null)
            if (authFlow == null)
            {
                throw new ArgumentNullException("authFlow is a required property for TargetCreateSalesforce and cannot be null");
            }
            this.AuthFlow = authFlow;
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for TargetCreateSalesforce and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for TargetCreateSalesforce and cannot be null");
            }
            this.Email = email;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TargetCreateSalesforce and cannot be null");
            }
            this.Name = name;
            // to ensure "tenantUrl" is required (not null)
            if (tenantUrl == null)
            {
                throw new ArgumentNullException("tenantUrl is a required property for TargetCreateSalesforce and cannot be null");
            }
            this.TenantUrl = tenantUrl;
            this.AppPrivateKeyData = appPrivateKeyData;
            this.CaCertData = caCertData;
            this.CaCertName = caCertName;
            this.ClientSecret = clientSecret;
            this.Description = description;
            this.Json = json;
            this.Key = key;
            this.MaxVersions = maxVersions;
            this.Password = password;
            this.SecurityToken = securityToken;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Base64 encoded PEM of the connected app private key (relevant for JWT auth only)
        /// </summary>
        /// <value>Base64 encoded PEM of the connected app private key (relevant for JWT auth only)</value>
        [DataMember(Name = "app-private-key-data", EmitDefaultValue = false)]
        public string AppPrivateKeyData { get; set; }

        /// <summary>
        /// type of the auth flow (&#39;jwt&#39; / &#39;user-password&#39;)
        /// </summary>
        /// <value>type of the auth flow (&#39;jwt&#39; / &#39;user-password&#39;)</value>
        [DataMember(Name = "auth-flow", IsRequired = true, EmitDefaultValue = true)]
        public string AuthFlow { get; set; }

        /// <summary>
        /// Base64 encoded PEM cert to use when uploading a new key to Salesforce
        /// </summary>
        /// <value>Base64 encoded PEM cert to use when uploading a new key to Salesforce</value>
        [DataMember(Name = "ca-cert-data", EmitDefaultValue = false)]
        public string CaCertData { get; set; }

        /// <summary>
        /// name of the certificate in Salesforce tenant to use when uploading new key
        /// </summary>
        /// <value>name of the certificate in Salesforce tenant to use when uploading new key</value>
        [DataMember(Name = "ca-cert-name", EmitDefaultValue = false)]
        public string CaCertName { get; set; }

        /// <summary>
        /// Client ID of the oauth2 app to use for connecting to Salesforce
        /// </summary>
        /// <value>Client ID of the oauth2 app to use for connecting to Salesforce</value>
        [DataMember(Name = "client-id", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret of the oauth2 app to use for connecting to Salesforce (required for password flow)
        /// </summary>
        /// <value>Client secret of the oauth2 app to use for connecting to Salesforce (required for password flow)</value>
        [DataMember(Name = "client-secret", EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The email of the user attached to the oauth2 app used for connecting to Salesforce
        /// </summary>
        /// <value>The email of the user attached to the oauth2 app used for connecting to Salesforce</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The password of the user attached to the oauth2 app used for connecting to Salesforce (required for user-password flow)
        /// </summary>
        /// <value>The password of the user attached to the oauth2 app used for connecting to Salesforce (required for user-password flow)</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// The security token of the user attached to the oauth2 app used for connecting to Salesforce  (required for user-password flow)
        /// </summary>
        /// <value>The security token of the user attached to the oauth2 app used for connecting to Salesforce  (required for user-password flow)</value>
        [DataMember(Name = "security-token", EmitDefaultValue = false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// Url of the Salesforce tenant
        /// </summary>
        /// <value>Url of the Salesforce tenant</value>
        [DataMember(Name = "tenant-url", IsRequired = true, EmitDefaultValue = true)]
        public string TenantUrl { get; set; }

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
            sb.Append("class TargetCreateSalesforce {\n");
            sb.Append("  AppPrivateKeyData: ").Append(AppPrivateKeyData).Append("\n");
            sb.Append("  AuthFlow: ").Append(AuthFlow).Append("\n");
            sb.Append("  CaCertData: ").Append(CaCertData).Append("\n");
            sb.Append("  CaCertName: ").Append(CaCertName).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SecurityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("  TenantUrl: ").Append(TenantUrl).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TargetCreateSalesforce);
        }

        /// <summary>
        /// Returns true if TargetCreateSalesforce instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetCreateSalesforce to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetCreateSalesforce input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppPrivateKeyData == input.AppPrivateKeyData ||
                    (this.AppPrivateKeyData != null &&
                    this.AppPrivateKeyData.Equals(input.AppPrivateKeyData))
                ) && 
                (
                    this.AuthFlow == input.AuthFlow ||
                    (this.AuthFlow != null &&
                    this.AuthFlow.Equals(input.AuthFlow))
                ) && 
                (
                    this.CaCertData == input.CaCertData ||
                    (this.CaCertData != null &&
                    this.CaCertData.Equals(input.CaCertData))
                ) && 
                (
                    this.CaCertName == input.CaCertName ||
                    (this.CaCertName != null &&
                    this.CaCertName.Equals(input.CaCertName))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MaxVersions == input.MaxVersions ||
                    (this.MaxVersions != null &&
                    this.MaxVersions.Equals(input.MaxVersions))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SecurityToken == input.SecurityToken ||
                    (this.SecurityToken != null &&
                    this.SecurityToken.Equals(input.SecurityToken))
                ) && 
                (
                    this.TenantUrl == input.TenantUrl ||
                    (this.TenantUrl != null &&
                    this.TenantUrl.Equals(input.TenantUrl))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
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
                if (this.AppPrivateKeyData != null)
                {
                    hashCode = (hashCode * 59) + this.AppPrivateKeyData.GetHashCode();
                }
                if (this.AuthFlow != null)
                {
                    hashCode = (hashCode * 59) + this.AuthFlow.GetHashCode();
                }
                if (this.CaCertData != null)
                {
                    hashCode = (hashCode * 59) + this.CaCertData.GetHashCode();
                }
                if (this.CaCertName != null)
                {
                    hashCode = (hashCode * 59) + this.CaCertName.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.ClientSecret != null)
                {
                    hashCode = (hashCode * 59) + this.ClientSecret.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.MaxVersions != null)
                {
                    hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.SecurityToken != null)
                {
                    hashCode = (hashCode * 59) + this.SecurityToken.GetHashCode();
                }
                if (this.TenantUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TenantUrl.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
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
