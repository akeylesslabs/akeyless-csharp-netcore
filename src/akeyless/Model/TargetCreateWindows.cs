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
    /// GatewayCreateProducerWindowsCmd is a command that creates a new windows target
    /// </summary>
    [DataContract(Name = "targetCreateWindows")]
    public partial class TargetCreateWindows : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateWindows" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetCreateWindows() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateWindows" /> class.
        /// </summary>
        /// <param name="certificate">SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA).</param>
        /// <param name="connectionType">Type of connection to Windows Server [credentials/parent-target] (default to &quot;credentials&quot;).</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="domain">User domain name.</param>
        /// <param name="hostname">Server hostname (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="parentTargetName">Name of the parent target, relevant only when connection-type is parent-target.</param>
        /// <param name="password">Privileged user password (required) (default to &quot;dummy_value&quot;).</param>
        /// <param name="port">Server WinRM port (default to &quot;5986&quot;).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="useTls">Enable/Disable TLS for WinRM over HTTPS [true/false] (default to &quot;true&quot;).</param>
        /// <param name="username">Privileged username (required) (default to &quot;dummy_value&quot;).</param>
        public TargetCreateWindows(string certificate = default(string), string connectionType = @"credentials", string description = default(string), string domain = default(string), string hostname = default(string), bool json = false, string key = default(string), string maxVersions = default(string), string name = default(string), string parentTargetName = default(string), string password = @"dummy_value", string port = @"5986", string token = default(string), string uidToken = default(string), string useTls = @"true", string username = @"dummy_value")
        {
            // to ensure "hostname" is required (not null)
            if (hostname == null)
            {
                throw new ArgumentNullException("hostname is a required property for TargetCreateWindows and cannot be null");
            }
            this.Hostname = hostname;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TargetCreateWindows and cannot be null");
            }
            this.Name = name;
            // to ensure "password" is required (not null)
            if (password == null)
            {
                throw new ArgumentNullException("password is a required property for TargetCreateWindows and cannot be null");
            }
            this.Password = password;
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new ArgumentNullException("username is a required property for TargetCreateWindows and cannot be null");
            }
            this.Username = username;
            this.Certificate = certificate;
            // use default value if no "connectionType" provided
            this.ConnectionType = connectionType ?? @"credentials";
            this.Description = description;
            this.Domain = domain;
            this.Json = json;
            this.Key = key;
            this.MaxVersions = maxVersions;
            this.ParentTargetName = parentTargetName;
            // use default value if no "port" provided
            this.Port = port ?? @"5986";
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "useTls" provided
            this.UseTls = useTls ?? @"true";
        }

        /// <summary>
        /// SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA)
        /// </summary>
        /// <value>SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA)</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Type of connection to Windows Server [credentials/parent-target]
        /// </summary>
        /// <value>Type of connection to Windows Server [credentials/parent-target]</value>
        [DataMember(Name = "connection-type", EmitDefaultValue = false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// User domain name
        /// </summary>
        /// <value>User domain name</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Server hostname
        /// </summary>
        /// <value>Server hostname</value>
        [DataMember(Name = "hostname", IsRequired = true, EmitDefaultValue = true)]
        public string Hostname { get; set; }

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
        /// Name of the parent target, relevant only when connection-type is parent-target
        /// </summary>
        /// <value>Name of the parent target, relevant only when connection-type is parent-target</value>
        [DataMember(Name = "parent-target-name", EmitDefaultValue = false)]
        public string ParentTargetName { get; set; }

        /// <summary>
        /// Privileged user password
        /// </summary>
        /// <value>Privileged user password</value>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Server WinRM port
        /// </summary>
        /// <value>Server WinRM port</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public string Port { get; set; }

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
        /// Enable/Disable TLS for WinRM over HTTPS [true/false]
        /// </summary>
        /// <value>Enable/Disable TLS for WinRM over HTTPS [true/false]</value>
        [DataMember(Name = "use-tls", EmitDefaultValue = false)]
        public string UseTls { get; set; }

        /// <summary>
        /// Privileged username
        /// </summary>
        /// <value>Privileged username</value>
        [DataMember(Name = "username", IsRequired = true, EmitDefaultValue = true)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetCreateWindows {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentTargetName: ").Append(ParentTargetName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UseTls: ").Append(UseTls).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
