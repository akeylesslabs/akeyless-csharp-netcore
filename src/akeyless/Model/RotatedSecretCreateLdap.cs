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
    /// RotatedSecretCreateLdap
    /// </summary>
    [DataContract(Name = "rotatedSecretCreateLdap")]
    public partial class RotatedSecretCreateLdap : IEquatable<RotatedSecretCreateLdap>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RotatedSecretCreateLdap" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RotatedSecretCreateLdap() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RotatedSecretCreateLdap" /> class.
        /// </summary>
        /// <param name="providerType">providerType.</param>
        /// <param name="authenticationCredentials">The credentials to connect with use-user-creds/use-target-creds (default to &quot;use-user-creds&quot;).</param>
        /// <param name="autoRotate">Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false].</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this item [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="hostProvider">Host provider type [explicit/target], Relevant only for Secure Remote Access of ssh cert issuer and ldap rotated secret (default to &quot;explicit&quot;).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="key">The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Rotated secret name (required).</param>
        /// <param name="passwordLength">The length of the password to be generated.</param>
        /// <param name="rotateAfterDisconnect">Rotate the value of the secret after SRA session ends [true/false] (default to &quot;false&quot;).</param>
        /// <param name="rotatedPassword">rotated-username password (relevant only for rotator-type&#x3D;ldap).</param>
        /// <param name="rotatedUsername">username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;ldap).</param>
        /// <param name="rotationHour">The Hour of the rotation in UTC.</param>
        /// <param name="rotationInterval">The number of days to wait between every automatic key rotation (1-365).</param>
        /// <param name="rotatorType">The rotator type. options: [target/ldap] (required).</param>
        /// <param name="secureAccessEnable">Enable/Disable secure remote access [true/false].</param>
        /// <param name="secureAccessHost">Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers).</param>
        /// <param name="secureAccessRdpDomain">Default domain name server. i.e. microsoft.com.</param>
        /// <param name="secureAccessUrl">Destination URL to inject secrets.</param>
        /// <param name="secureAccessWeb">Enable Web Secure Remote Access (default to false).</param>
        /// <param name="secureAccessWebBrowsing">Secure browser via Akeyless Web Access Bastion (default to false).</param>
        /// <param name="secureAccessWebProxy">Web-Proxy via Akeyless Web Access Bastion (default to false).</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="target">A list of linked targets to be associated, Relevant only for Secure Remote Access for ssh cert issuer and ldap rotated secret, To specify multiple targets use argument multiple times.</param>
        /// <param name="targetName">Target name (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userAttribute">LDAP User Attribute, Default value \&quot;cn\&quot; (default to &quot;cn&quot;).</param>
        /// <param name="userDn">Base DN to Perform User Search.</param>
        public RotatedSecretCreateLdap(string providerType = default(string), string authenticationCredentials = "use-user-creds", string autoRotate = default(string), string deleteProtection = default(string), string description = default(string), string hostProvider = "explicit", bool json = false, string key = default(string), string maxVersions = default(string), string name = default(string), string passwordLength = default(string), string rotateAfterDisconnect = "false", string rotatedPassword = default(string), string rotatedUsername = default(string), int rotationHour = default(int), string rotationInterval = default(string), string rotatorType = default(string), string secureAccessEnable = default(string), List<string> secureAccessHost = default(List<string>), string secureAccessRdpDomain = default(string), string secureAccessUrl = default(string), bool secureAccessWeb = false, bool secureAccessWebBrowsing = false, bool secureAccessWebProxy = false, List<string> tags = default(List<string>), List<string> target = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userAttribute = "cn", string userDn = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RotatedSecretCreateLdap and cannot be null");
            }
            this.Name = name;
            // to ensure "rotatorType" is required (not null)
            if (rotatorType == null)
            {
                throw new ArgumentNullException("rotatorType is a required property for RotatedSecretCreateLdap and cannot be null");
            }
            this.RotatorType = rotatorType;
            // to ensure "targetName" is required (not null)
            if (targetName == null)
            {
                throw new ArgumentNullException("targetName is a required property for RotatedSecretCreateLdap and cannot be null");
            }
            this.TargetName = targetName;
            this.ProviderType = providerType;
            // use default value if no "authenticationCredentials" provided
            this.AuthenticationCredentials = authenticationCredentials ?? "use-user-creds";
            this.AutoRotate = autoRotate;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            // use default value if no "hostProvider" provided
            this.HostProvider = hostProvider ?? "explicit";
            this.Json = json;
            this.Key = key;
            this.MaxVersions = maxVersions;
            this.PasswordLength = passwordLength;
            // use default value if no "rotateAfterDisconnect" provided
            this.RotateAfterDisconnect = rotateAfterDisconnect ?? "false";
            this.RotatedPassword = rotatedPassword;
            this.RotatedUsername = rotatedUsername;
            this.RotationHour = rotationHour;
            this.RotationInterval = rotationInterval;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessHost = secureAccessHost;
            this.SecureAccessRdpDomain = secureAccessRdpDomain;
            this.SecureAccessUrl = secureAccessUrl;
            this.SecureAccessWeb = secureAccessWeb;
            this.SecureAccessWebBrowsing = secureAccessWebBrowsing;
            this.SecureAccessWebProxy = secureAccessWebProxy;
            this.Tags = tags;
            this.Target = target;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userAttribute" provided
            this.UserAttribute = userAttribute ?? "cn";
            this.UserDn = userDn;
        }

        /// <summary>
        /// Gets or Sets ProviderType
        /// </summary>
        [DataMember(Name = "ProviderType", EmitDefaultValue = false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// The credentials to connect with use-user-creds/use-target-creds
        /// </summary>
        /// <value>The credentials to connect with use-user-creds/use-target-creds</value>
        [DataMember(Name = "authentication-credentials", EmitDefaultValue = false)]
        public string AuthenticationCredentials { get; set; }

        /// <summary>
        /// Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false]
        /// </summary>
        /// <value>Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false]</value>
        [DataMember(Name = "auto-rotate", EmitDefaultValue = false)]
        public string AutoRotate { get; set; }

        /// <summary>
        /// Protection from accidental deletion of this item [true/false]
        /// </summary>
        /// <value>Protection from accidental deletion of this item [true/false]</value>
        [DataMember(Name = "delete_protection", EmitDefaultValue = false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Host provider type [explicit/target], Relevant only for Secure Remote Access of ssh cert issuer and ldap rotated secret
        /// </summary>
        /// <value>Host provider type [explicit/target], Relevant only for Secure Remote Access of ssh cert issuer and ldap rotated secret</value>
        [DataMember(Name = "host-provider", EmitDefaultValue = false)]
        public string HostProvider { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Rotated secret name
        /// </summary>
        /// <value>Rotated secret name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The length of the password to be generated
        /// </summary>
        /// <value>The length of the password to be generated</value>
        [DataMember(Name = "password-length", EmitDefaultValue = false)]
        public string PasswordLength { get; set; }

        /// <summary>
        /// Rotate the value of the secret after SRA session ends [true/false]
        /// </summary>
        /// <value>Rotate the value of the secret after SRA session ends [true/false]</value>
        [DataMember(Name = "rotate-after-disconnect", EmitDefaultValue = false)]
        public string RotateAfterDisconnect { get; set; }

        /// <summary>
        /// rotated-username password (relevant only for rotator-type&#x3D;ldap)
        /// </summary>
        /// <value>rotated-username password (relevant only for rotator-type&#x3D;ldap)</value>
        [DataMember(Name = "rotated-password", EmitDefaultValue = false)]
        public string RotatedPassword { get; set; }

        /// <summary>
        /// username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;ldap)
        /// </summary>
        /// <value>username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;ldap)</value>
        [DataMember(Name = "rotated-username", EmitDefaultValue = false)]
        public string RotatedUsername { get; set; }

        /// <summary>
        /// The Hour of the rotation in UTC
        /// </summary>
        /// <value>The Hour of the rotation in UTC</value>
        [DataMember(Name = "rotation-hour", EmitDefaultValue = false)]
        public int RotationHour { get; set; }

        /// <summary>
        /// The number of days to wait between every automatic key rotation (1-365)
        /// </summary>
        /// <value>The number of days to wait between every automatic key rotation (1-365)</value>
        [DataMember(Name = "rotation-interval", EmitDefaultValue = false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// The rotator type. options: [target/ldap]
        /// </summary>
        /// <value>The rotator type. options: [target/ldap]</value>
        [DataMember(Name = "rotator-type", IsRequired = true, EmitDefaultValue = true)]
        public string RotatorType { get; set; }

        /// <summary>
        /// Enable/Disable secure remote access [true/false]
        /// </summary>
        /// <value>Enable/Disable secure remote access [true/false]</value>
        [DataMember(Name = "secure-access-enable", EmitDefaultValue = false)]
        public string SecureAccessEnable { get; set; }

        /// <summary>
        /// Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers)
        /// </summary>
        /// <value>Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers)</value>
        [DataMember(Name = "secure-access-host", EmitDefaultValue = false)]
        public List<string> SecureAccessHost { get; set; }

        /// <summary>
        /// Default domain name server. i.e. microsoft.com
        /// </summary>
        /// <value>Default domain name server. i.e. microsoft.com</value>
        [DataMember(Name = "secure-access-rdp-domain", EmitDefaultValue = false)]
        public string SecureAccessRdpDomain { get; set; }

        /// <summary>
        /// Destination URL to inject secrets
        /// </summary>
        /// <value>Destination URL to inject secrets</value>
        [DataMember(Name = "secure-access-url", EmitDefaultValue = false)]
        public string SecureAccessUrl { get; set; }

        /// <summary>
        /// Enable Web Secure Remote Access
        /// </summary>
        /// <value>Enable Web Secure Remote Access</value>
        [DataMember(Name = "secure-access-web", EmitDefaultValue = true)]
        public bool SecureAccessWeb { get; set; }

        /// <summary>
        /// Secure browser via Akeyless Web Access Bastion
        /// </summary>
        /// <value>Secure browser via Akeyless Web Access Bastion</value>
        [DataMember(Name = "secure-access-web-browsing", EmitDefaultValue = true)]
        public bool SecureAccessWebBrowsing { get; set; }

        /// <summary>
        /// Web-Proxy via Akeyless Web Access Bastion
        /// </summary>
        /// <value>Web-Proxy via Akeyless Web Access Bastion</value>
        [DataMember(Name = "secure-access-web-proxy", EmitDefaultValue = true)]
        public bool SecureAccessWebProxy { get; set; }

        /// <summary>
        /// Add tags attached to this object
        /// </summary>
        /// <value>Add tags attached to this object</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A list of linked targets to be associated, Relevant only for Secure Remote Access for ssh cert issuer and ldap rotated secret, To specify multiple targets use argument multiple times
        /// </summary>
        /// <value>A list of linked targets to be associated, Relevant only for Secure Remote Access for ssh cert issuer and ldap rotated secret, To specify multiple targets use argument multiple times</value>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public List<string> Target { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "target-name", IsRequired = true, EmitDefaultValue = true)]
        public string TargetName { get; set; }

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
        /// LDAP User Attribute, Default value \&quot;cn\&quot;
        /// </summary>
        /// <value>LDAP User Attribute, Default value \&quot;cn\&quot;</value>
        [DataMember(Name = "user-attribute", EmitDefaultValue = false)]
        public string UserAttribute { get; set; }

        /// <summary>
        /// Base DN to Perform User Search
        /// </summary>
        /// <value>Base DN to Perform User Search</value>
        [DataMember(Name = "user-dn", EmitDefaultValue = false)]
        public string UserDn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RotatedSecretCreateLdap {\n");
            sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
            sb.Append("  AuthenticationCredentials: ").Append(AuthenticationCredentials).Append("\n");
            sb.Append("  AutoRotate: ").Append(AutoRotate).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HostProvider: ").Append(HostProvider).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PasswordLength: ").Append(PasswordLength).Append("\n");
            sb.Append("  RotateAfterDisconnect: ").Append(RotateAfterDisconnect).Append("\n");
            sb.Append("  RotatedPassword: ").Append(RotatedPassword).Append("\n");
            sb.Append("  RotatedUsername: ").Append(RotatedUsername).Append("\n");
            sb.Append("  RotationHour: ").Append(RotationHour).Append("\n");
            sb.Append("  RotationInterval: ").Append(RotationInterval).Append("\n");
            sb.Append("  RotatorType: ").Append(RotatorType).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
            sb.Append("  SecureAccessRdpDomain: ").Append(SecureAccessRdpDomain).Append("\n");
            sb.Append("  SecureAccessUrl: ").Append(SecureAccessUrl).Append("\n");
            sb.Append("  SecureAccessWeb: ").Append(SecureAccessWeb).Append("\n");
            sb.Append("  SecureAccessWebBrowsing: ").Append(SecureAccessWebBrowsing).Append("\n");
            sb.Append("  SecureAccessWebProxy: ").Append(SecureAccessWebProxy).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UserAttribute: ").Append(UserAttribute).Append("\n");
            sb.Append("  UserDn: ").Append(UserDn).Append("\n");
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
            return this.Equals(input as RotatedSecretCreateLdap);
        }

        /// <summary>
        /// Returns true if RotatedSecretCreateLdap instances are equal
        /// </summary>
        /// <param name="input">Instance of RotatedSecretCreateLdap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RotatedSecretCreateLdap input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderType == input.ProviderType ||
                    (this.ProviderType != null &&
                    this.ProviderType.Equals(input.ProviderType))
                ) && 
                (
                    this.AuthenticationCredentials == input.AuthenticationCredentials ||
                    (this.AuthenticationCredentials != null &&
                    this.AuthenticationCredentials.Equals(input.AuthenticationCredentials))
                ) && 
                (
                    this.AutoRotate == input.AutoRotate ||
                    (this.AutoRotate != null &&
                    this.AutoRotate.Equals(input.AutoRotate))
                ) && 
                (
                    this.DeleteProtection == input.DeleteProtection ||
                    (this.DeleteProtection != null &&
                    this.DeleteProtection.Equals(input.DeleteProtection))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HostProvider == input.HostProvider ||
                    (this.HostProvider != null &&
                    this.HostProvider.Equals(input.HostProvider))
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
                    this.PasswordLength == input.PasswordLength ||
                    (this.PasswordLength != null &&
                    this.PasswordLength.Equals(input.PasswordLength))
                ) && 
                (
                    this.RotateAfterDisconnect == input.RotateAfterDisconnect ||
                    (this.RotateAfterDisconnect != null &&
                    this.RotateAfterDisconnect.Equals(input.RotateAfterDisconnect))
                ) && 
                (
                    this.RotatedPassword == input.RotatedPassword ||
                    (this.RotatedPassword != null &&
                    this.RotatedPassword.Equals(input.RotatedPassword))
                ) && 
                (
                    this.RotatedUsername == input.RotatedUsername ||
                    (this.RotatedUsername != null &&
                    this.RotatedUsername.Equals(input.RotatedUsername))
                ) && 
                (
                    this.RotationHour == input.RotationHour ||
                    this.RotationHour.Equals(input.RotationHour)
                ) && 
                (
                    this.RotationInterval == input.RotationInterval ||
                    (this.RotationInterval != null &&
                    this.RotationInterval.Equals(input.RotationInterval))
                ) && 
                (
                    this.RotatorType == input.RotatorType ||
                    (this.RotatorType != null &&
                    this.RotatorType.Equals(input.RotatorType))
                ) && 
                (
                    this.SecureAccessEnable == input.SecureAccessEnable ||
                    (this.SecureAccessEnable != null &&
                    this.SecureAccessEnable.Equals(input.SecureAccessEnable))
                ) && 
                (
                    this.SecureAccessHost == input.SecureAccessHost ||
                    this.SecureAccessHost != null &&
                    input.SecureAccessHost != null &&
                    this.SecureAccessHost.SequenceEqual(input.SecureAccessHost)
                ) && 
                (
                    this.SecureAccessRdpDomain == input.SecureAccessRdpDomain ||
                    (this.SecureAccessRdpDomain != null &&
                    this.SecureAccessRdpDomain.Equals(input.SecureAccessRdpDomain))
                ) && 
                (
                    this.SecureAccessUrl == input.SecureAccessUrl ||
                    (this.SecureAccessUrl != null &&
                    this.SecureAccessUrl.Equals(input.SecureAccessUrl))
                ) && 
                (
                    this.SecureAccessWeb == input.SecureAccessWeb ||
                    this.SecureAccessWeb.Equals(input.SecureAccessWeb)
                ) && 
                (
                    this.SecureAccessWebBrowsing == input.SecureAccessWebBrowsing ||
                    this.SecureAccessWebBrowsing.Equals(input.SecureAccessWebBrowsing)
                ) && 
                (
                    this.SecureAccessWebProxy == input.SecureAccessWebProxy ||
                    this.SecureAccessWebProxy.Equals(input.SecureAccessWebProxy)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Target == input.Target ||
                    this.Target != null &&
                    input.Target != null &&
                    this.Target.SequenceEqual(input.Target)
                ) && 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
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
                ) && 
                (
                    this.UserAttribute == input.UserAttribute ||
                    (this.UserAttribute != null &&
                    this.UserAttribute.Equals(input.UserAttribute))
                ) && 
                (
                    this.UserDn == input.UserDn ||
                    (this.UserDn != null &&
                    this.UserDn.Equals(input.UserDn))
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
                if (this.ProviderType != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderType.GetHashCode();
                }
                if (this.AuthenticationCredentials != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationCredentials.GetHashCode();
                }
                if (this.AutoRotate != null)
                {
                    hashCode = (hashCode * 59) + this.AutoRotate.GetHashCode();
                }
                if (this.DeleteProtection != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteProtection.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.HostProvider != null)
                {
                    hashCode = (hashCode * 59) + this.HostProvider.GetHashCode();
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
                if (this.PasswordLength != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordLength.GetHashCode();
                }
                if (this.RotateAfterDisconnect != null)
                {
                    hashCode = (hashCode * 59) + this.RotateAfterDisconnect.GetHashCode();
                }
                if (this.RotatedPassword != null)
                {
                    hashCode = (hashCode * 59) + this.RotatedPassword.GetHashCode();
                }
                if (this.RotatedUsername != null)
                {
                    hashCode = (hashCode * 59) + this.RotatedUsername.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RotationHour.GetHashCode();
                if (this.RotationInterval != null)
                {
                    hashCode = (hashCode * 59) + this.RotationInterval.GetHashCode();
                }
                if (this.RotatorType != null)
                {
                    hashCode = (hashCode * 59) + this.RotatorType.GetHashCode();
                }
                if (this.SecureAccessEnable != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessEnable.GetHashCode();
                }
                if (this.SecureAccessHost != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessHost.GetHashCode();
                }
                if (this.SecureAccessRdpDomain != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessRdpDomain.GetHashCode();
                }
                if (this.SecureAccessUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureAccessWeb.GetHashCode();
                hashCode = (hashCode * 59) + this.SecureAccessWebBrowsing.GetHashCode();
                hashCode = (hashCode * 59) + this.SecureAccessWebProxy.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                if (this.TargetName != null)
                {
                    hashCode = (hashCode * 59) + this.TargetName.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                if (this.UserAttribute != null)
                {
                    hashCode = (hashCode * 59) + this.UserAttribute.GetHashCode();
                }
                if (this.UserDn != null)
                {
                    hashCode = (hashCode * 59) + this.UserDn.GetHashCode();
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