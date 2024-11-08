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
    /// targetUpdateLdap is a command that updates an existing ldap target
    /// </summary>
    [DataContract(Name = "targetUpdateLdap")]
    public partial class TargetUpdateLdap : IEquatable<TargetUpdateLdap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetUpdateLdap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetUpdateLdap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetUpdateLdap" /> class.
        /// </summary>
        /// <param name="bindDn">Bind DN (required).</param>
        /// <param name="bindDnPassword">Bind DN Password (required).</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keepPrevVersion">Whether to keep previous version [true/false]. If not set, use default according to account settings.</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="ldapCaCert">CA Certificate File Content.</param>
        /// <param name="ldapUrl">LDAP Server URL (required).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="newName">New target name.</param>
        /// <param name="serverType">Set Ldap server type, Options:[OpenLDAP, ActiveDirectory].</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="tokenExpiration">Token expiration.</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        public TargetUpdateLdap(string bindDn = default(string), string bindDnPassword = default(string), string description = default(string), bool json = false, string keepPrevVersion = default(string), string key = default(string), string ldapCaCert = default(string), string ldapUrl = default(string), string maxVersions = default(string), string name = default(string), string newName = default(string), string serverType = default(string), string token = default(string), string tokenExpiration = default(string), string uidToken = default(string))
        {
            // to ensure "bindDn" is required (not null)
            if (bindDn == null)
            {
                throw new ArgumentNullException("bindDn is a required property for TargetUpdateLdap and cannot be null");
            }
            this.BindDn = bindDn;
            // to ensure "bindDnPassword" is required (not null)
            if (bindDnPassword == null)
            {
                throw new ArgumentNullException("bindDnPassword is a required property for TargetUpdateLdap and cannot be null");
            }
            this.BindDnPassword = bindDnPassword;
            // to ensure "ldapUrl" is required (not null)
            if (ldapUrl == null)
            {
                throw new ArgumentNullException("ldapUrl is a required property for TargetUpdateLdap and cannot be null");
            }
            this.LdapUrl = ldapUrl;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TargetUpdateLdap and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.Json = json;
            this.KeepPrevVersion = keepPrevVersion;
            this.Key = key;
            this.LdapCaCert = ldapCaCert;
            this.MaxVersions = maxVersions;
            this.NewName = newName;
            this.ServerType = serverType;
            this.Token = token;
            this.TokenExpiration = tokenExpiration;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Bind DN
        /// </summary>
        /// <value>Bind DN</value>
        [DataMember(Name = "bind-dn", IsRequired = true, EmitDefaultValue = true)]
        public string BindDn { get; set; }

        /// <summary>
        /// Bind DN Password
        /// </summary>
        /// <value>Bind DN Password</value>
        [DataMember(Name = "bind-dn-password", IsRequired = true, EmitDefaultValue = true)]
        public string BindDnPassword { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// Whether to keep previous version [true/false]. If not set, use default according to account settings
        /// </summary>
        /// <value>Whether to keep previous version [true/false]. If not set, use default according to account settings</value>
        [DataMember(Name = "keep-prev-version", EmitDefaultValue = false)]
        public string KeepPrevVersion { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// CA Certificate File Content
        /// </summary>
        /// <value>CA Certificate File Content</value>
        [DataMember(Name = "ldap-ca-cert", EmitDefaultValue = false)]
        public string LdapCaCert { get; set; }

        /// <summary>
        /// LDAP Server URL
        /// </summary>
        /// <value>LDAP Server URL</value>
        [DataMember(Name = "ldap-url", IsRequired = true, EmitDefaultValue = true)]
        public string LdapUrl { get; set; }

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
        /// New target name
        /// </summary>
        /// <value>New target name</value>
        [DataMember(Name = "new-name", EmitDefaultValue = false)]
        public string NewName { get; set; }

        /// <summary>
        /// Set Ldap server type, Options:[OpenLDAP, ActiveDirectory]
        /// </summary>
        /// <value>Set Ldap server type, Options:[OpenLDAP, ActiveDirectory]</value>
        [DataMember(Name = "server-type", EmitDefaultValue = false)]
        public string ServerType { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        /// Token expiration
        /// </summary>
        /// <value>Token expiration</value>
        [DataMember(Name = "token-expiration", EmitDefaultValue = false)]
        public string TokenExpiration { get; set; }

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
            sb.Append("class TargetUpdateLdap {\n");
            sb.Append("  BindDn: ").Append(BindDn).Append("\n");
            sb.Append("  BindDnPassword: ").Append(BindDnPassword).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeepPrevVersion: ").Append(KeepPrevVersion).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LdapCaCert: ").Append(LdapCaCert).Append("\n");
            sb.Append("  LdapUrl: ").Append(LdapUrl).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  ServerType: ").Append(ServerType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenExpiration: ").Append(TokenExpiration).Append("\n");
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
            return this.Equals(input as TargetUpdateLdap);
        }

        /// <summary>
        /// Returns true if TargetUpdateLdap instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetUpdateLdap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetUpdateLdap input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindDn == input.BindDn ||
                    (this.BindDn != null &&
                    this.BindDn.Equals(input.BindDn))
                ) && 
                (
                    this.BindDnPassword == input.BindDnPassword ||
                    (this.BindDnPassword != null &&
                    this.BindDnPassword.Equals(input.BindDnPassword))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.KeepPrevVersion == input.KeepPrevVersion ||
                    (this.KeepPrevVersion != null &&
                    this.KeepPrevVersion.Equals(input.KeepPrevVersion))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.LdapCaCert == input.LdapCaCert ||
                    (this.LdapCaCert != null &&
                    this.LdapCaCert.Equals(input.LdapCaCert))
                ) && 
                (
                    this.LdapUrl == input.LdapUrl ||
                    (this.LdapUrl != null &&
                    this.LdapUrl.Equals(input.LdapUrl))
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
                    this.NewName == input.NewName ||
                    (this.NewName != null &&
                    this.NewName.Equals(input.NewName))
                ) && 
                (
                    this.ServerType == input.ServerType ||
                    (this.ServerType != null &&
                    this.ServerType.Equals(input.ServerType))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenExpiration == input.TokenExpiration ||
                    (this.TokenExpiration != null &&
                    this.TokenExpiration.Equals(input.TokenExpiration))
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
                if (this.BindDn != null)
                {
                    hashCode = (hashCode * 59) + this.BindDn.GetHashCode();
                }
                if (this.BindDnPassword != null)
                {
                    hashCode = (hashCode * 59) + this.BindDnPassword.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.KeepPrevVersion != null)
                {
                    hashCode = (hashCode * 59) + this.KeepPrevVersion.GetHashCode();
                }
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.LdapCaCert != null)
                {
                    hashCode = (hashCode * 59) + this.LdapCaCert.GetHashCode();
                }
                if (this.LdapUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LdapUrl.GetHashCode();
                }
                if (this.MaxVersions != null)
                {
                    hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NewName != null)
                {
                    hashCode = (hashCode * 59) + this.NewName.GetHashCode();
                }
                if (this.ServerType != null)
                {
                    hashCode = (hashCode * 59) + this.ServerType.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.TokenExpiration != null)
                {
                    hashCode = (hashCode * 59) + this.TokenExpiration.GetHashCode();
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
