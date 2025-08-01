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
    /// updateSSHTarget is a command that updates an existing target. [Deprecated: Use target-update-ssh command]
    /// </summary>
    [DataContract(Name = "updateSSHTarget")]
    public partial class UpdateSSHTarget : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSSHTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSSHTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSSHTarget" /> class.
        /// </summary>
        /// <param name="description">Description of the object.</param>
        /// <param name="host">SSH host name.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="keepPrevVersion">Whether to keep previous version [true/false]. If not set, use default according to account settings.</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="newName">New target name.</param>
        /// <param name="port">SSH port (default to &quot;22&quot;).</param>
        /// <param name="privateKey">SSH private key.</param>
        /// <param name="privateKeyPassword">SSH private key password.</param>
        /// <param name="sshPassword">SSH password to rotate.</param>
        /// <param name="sshUsername">SSH username.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="updateVersion">Deprecated.</param>
        public UpdateSSHTarget(string description = default(string), string host = default(string), bool json = false, string keepPrevVersion = default(string), string key = default(string), string maxVersions = default(string), string name = default(string), string newName = default(string), string port = @"22", string privateKey = default(string), string privateKeyPassword = default(string), string sshPassword = default(string), string sshUsername = default(string), string token = default(string), string uidToken = default(string), bool updateVersion = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateSSHTarget and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.Host = host;
            this.Json = json;
            this.KeepPrevVersion = keepPrevVersion;
            this.Key = key;
            this.MaxVersions = maxVersions;
            this.NewName = newName;
            // use default value if no "port" provided
            this.Port = port ?? @"22";
            this.PrivateKey = privateKey;
            this.PrivateKeyPassword = privateKeyPassword;
            this.SshPassword = sshPassword;
            this.SshUsername = sshUsername;
            this.Token = token;
            this.UidToken = uidToken;
            this.UpdateVersion = updateVersion;
        }

        /// <summary>
        /// Description of the object
        /// </summary>
        /// <value>Description of the object</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// SSH host name
        /// </summary>
        /// <value>SSH host name</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

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
        /// SSH port
        /// </summary>
        /// <value>SSH port</value>
        [DataMember(Name = "port", EmitDefaultValue = false)]
        public string Port { get; set; }

        /// <summary>
        /// SSH private key
        /// </summary>
        /// <value>SSH private key</value>
        [DataMember(Name = "private-key", EmitDefaultValue = false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// SSH private key password
        /// </summary>
        /// <value>SSH private key password</value>
        [DataMember(Name = "private-key-password", EmitDefaultValue = false)]
        public string PrivateKeyPassword { get; set; }

        /// <summary>
        /// SSH password to rotate
        /// </summary>
        /// <value>SSH password to rotate</value>
        [DataMember(Name = "ssh-password", EmitDefaultValue = false)]
        public string SshPassword { get; set; }

        /// <summary>
        /// SSH username
        /// </summary>
        /// <value>SSH username</value>
        [DataMember(Name = "ssh-username", EmitDefaultValue = false)]
        public string SshUsername { get; set; }

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
        /// Deprecated
        /// </summary>
        /// <value>Deprecated</value>
        [DataMember(Name = "update-version", EmitDefaultValue = true)]
        public bool UpdateVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSSHTarget {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  KeepPrevVersion: ").Append(KeepPrevVersion).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NewName: ").Append(NewName).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  PrivateKeyPassword: ").Append(PrivateKeyPassword).Append("\n");
            sb.Append("  SshPassword: ").Append(SshPassword).Append("\n");
            sb.Append("  SshUsername: ").Append(SshUsername).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UpdateVersion: ").Append(UpdateVersion).Append("\n");
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
