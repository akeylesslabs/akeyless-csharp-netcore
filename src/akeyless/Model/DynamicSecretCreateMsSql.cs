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
    /// dynamicSecretCreateMsSql is a command that creates mssql dynamic secret
    /// </summary>
    [DataContract(Name = "dynamicSecretCreateMsSql")]
    public partial class DynamicSecretCreateMsSql : IEquatable<DynamicSecretCreateMsSql>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretCreateMsSql" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicSecretCreateMsSql() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretCreateMsSql" /> class.
        /// </summary>
        /// <param name="deleteProtection">Protection from accidental deletion of this item [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="mssqlCreateStatements">MSSQL Creation statements.</param>
        /// <param name="mssqlDbname">MSSQL Name.</param>
        /// <param name="mssqlHost">MSSQL Host (default to &quot;127.0.0.1&quot;).</param>
        /// <param name="mssqlPassword">MSSQL Password.</param>
        /// <param name="mssqlPort">MSSQL Port (default to &quot;1433&quot;).</param>
        /// <param name="mssqlRevocationStatements">MSSQL Revocation statements.</param>
        /// <param name="mssqlUsername">MSSQL Username.</param>
        /// <param name="name">Dynamic secret name (required).</param>
        /// <param name="passwordLength">The length of the password to be generated.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="secureAccessBastionIssuer">Path to the SSH Certificate Issuer for your Akeyless Bastion.</param>
        /// <param name="secureAccessDbSchema">The DB schema.</param>
        /// <param name="secureAccessEnable">Enable/Disable secure remote access [true/false].</param>
        /// <param name="secureAccessHost">Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts).</param>
        /// <param name="secureAccessWeb">Enable Web Secure Remote Access (default to false).</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        public DynamicSecretCreateMsSql(string deleteProtection = default(string), string description = default(string), bool json = false, string mssqlCreateStatements = default(string), string mssqlDbname = default(string), string mssqlHost = "127.0.0.1", string mssqlPassword = default(string), string mssqlPort = "1433", string mssqlRevocationStatements = default(string), string mssqlUsername = default(string), string name = default(string), string passwordLength = default(string), string producerEncryptionKeyName = default(string), string secureAccessBastionIssuer = default(string), string secureAccessDbSchema = default(string), string secureAccessEnable = default(string), List<string> secureAccessHost = default(List<string>), bool secureAccessWeb = false, List<string> tags = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "60m")
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DynamicSecretCreateMsSql and cannot be null");
            }
            this.Name = name;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.Json = json;
            this.MssqlCreateStatements = mssqlCreateStatements;
            this.MssqlDbname = mssqlDbname;
            // use default value if no "mssqlHost" provided
            this.MssqlHost = mssqlHost ?? "127.0.0.1";
            this.MssqlPassword = mssqlPassword;
            // use default value if no "mssqlPort" provided
            this.MssqlPort = mssqlPort ?? "1433";
            this.MssqlRevocationStatements = mssqlRevocationStatements;
            this.MssqlUsername = mssqlUsername;
            this.PasswordLength = passwordLength;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessDbSchema = secureAccessDbSchema;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessHost = secureAccessHost;
            this.SecureAccessWeb = secureAccessWeb;
            this.Tags = tags;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? "60m";
        }

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
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// MSSQL Creation statements
        /// </summary>
        /// <value>MSSQL Creation statements</value>
        [DataMember(Name = "mssql-create-statements", EmitDefaultValue = false)]
        public string MssqlCreateStatements { get; set; }

        /// <summary>
        /// MSSQL Name
        /// </summary>
        /// <value>MSSQL Name</value>
        [DataMember(Name = "mssql-dbname", EmitDefaultValue = false)]
        public string MssqlDbname { get; set; }

        /// <summary>
        /// MSSQL Host
        /// </summary>
        /// <value>MSSQL Host</value>
        [DataMember(Name = "mssql-host", EmitDefaultValue = false)]
        public string MssqlHost { get; set; }

        /// <summary>
        /// MSSQL Password
        /// </summary>
        /// <value>MSSQL Password</value>
        [DataMember(Name = "mssql-password", EmitDefaultValue = false)]
        public string MssqlPassword { get; set; }

        /// <summary>
        /// MSSQL Port
        /// </summary>
        /// <value>MSSQL Port</value>
        [DataMember(Name = "mssql-port", EmitDefaultValue = false)]
        public string MssqlPort { get; set; }

        /// <summary>
        /// MSSQL Revocation statements
        /// </summary>
        /// <value>MSSQL Revocation statements</value>
        [DataMember(Name = "mssql-revocation-statements", EmitDefaultValue = false)]
        public string MssqlRevocationStatements { get; set; }

        /// <summary>
        /// MSSQL Username
        /// </summary>
        /// <value>MSSQL Username</value>
        [DataMember(Name = "mssql-username", EmitDefaultValue = false)]
        public string MssqlUsername { get; set; }

        /// <summary>
        /// Dynamic secret name
        /// </summary>
        /// <value>Dynamic secret name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The length of the password to be generated
        /// </summary>
        /// <value>The length of the password to be generated</value>
        [DataMember(Name = "password-length", EmitDefaultValue = false)]
        public string PasswordLength { get; set; }

        /// <summary>
        /// Dynamic producer encryption key
        /// </summary>
        /// <value>Dynamic producer encryption key</value>
        [DataMember(Name = "producer-encryption-key-name", EmitDefaultValue = false)]
        public string ProducerEncryptionKeyName { get; set; }

        /// <summary>
        /// Path to the SSH Certificate Issuer for your Akeyless Bastion
        /// </summary>
        /// <value>Path to the SSH Certificate Issuer for your Akeyless Bastion</value>
        [DataMember(Name = "secure-access-bastion-issuer", EmitDefaultValue = false)]
        public string SecureAccessBastionIssuer { get; set; }

        /// <summary>
        /// The DB schema
        /// </summary>
        /// <value>The DB schema</value>
        [DataMember(Name = "secure-access-db-schema", EmitDefaultValue = false)]
        public string SecureAccessDbSchema { get; set; }

        /// <summary>
        /// Enable/Disable secure remote access [true/false]
        /// </summary>
        /// <value>Enable/Disable secure remote access [true/false]</value>
        [DataMember(Name = "secure-access-enable", EmitDefaultValue = false)]
        public string SecureAccessEnable { get; set; }

        /// <summary>
        /// Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts)
        /// </summary>
        /// <value>Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts)</value>
        [DataMember(Name = "secure-access-host", EmitDefaultValue = false)]
        public List<string> SecureAccessHost { get; set; }

        /// <summary>
        /// Enable Web Secure Remote Access
        /// </summary>
        /// <value>Enable Web Secure Remote Access</value>
        [DataMember(Name = "secure-access-web", EmitDefaultValue = true)]
        public bool SecureAccessWeb { get; set; }

        /// <summary>
        /// Add tags attached to this object
        /// </summary>
        /// <value>Add tags attached to this object</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "target-name", EmitDefaultValue = false)]
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
        /// User TTL
        /// </summary>
        /// <value>User TTL</value>
        [DataMember(Name = "user-ttl", EmitDefaultValue = false)]
        public string UserTtl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicSecretCreateMsSql {\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  MssqlCreateStatements: ").Append(MssqlCreateStatements).Append("\n");
            sb.Append("  MssqlDbname: ").Append(MssqlDbname).Append("\n");
            sb.Append("  MssqlHost: ").Append(MssqlHost).Append("\n");
            sb.Append("  MssqlPassword: ").Append(MssqlPassword).Append("\n");
            sb.Append("  MssqlPort: ").Append(MssqlPort).Append("\n");
            sb.Append("  MssqlRevocationStatements: ").Append(MssqlRevocationStatements).Append("\n");
            sb.Append("  MssqlUsername: ").Append(MssqlUsername).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PasswordLength: ").Append(PasswordLength).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessDbSchema: ").Append(SecureAccessDbSchema).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
            sb.Append("  SecureAccessWeb: ").Append(SecureAccessWeb).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UserTtl: ").Append(UserTtl).Append("\n");
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
            return this.Equals(input as DynamicSecretCreateMsSql);
        }

        /// <summary>
        /// Returns true if DynamicSecretCreateMsSql instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicSecretCreateMsSql to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicSecretCreateMsSql input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.MssqlCreateStatements == input.MssqlCreateStatements ||
                    (this.MssqlCreateStatements != null &&
                    this.MssqlCreateStatements.Equals(input.MssqlCreateStatements))
                ) && 
                (
                    this.MssqlDbname == input.MssqlDbname ||
                    (this.MssqlDbname != null &&
                    this.MssqlDbname.Equals(input.MssqlDbname))
                ) && 
                (
                    this.MssqlHost == input.MssqlHost ||
                    (this.MssqlHost != null &&
                    this.MssqlHost.Equals(input.MssqlHost))
                ) && 
                (
                    this.MssqlPassword == input.MssqlPassword ||
                    (this.MssqlPassword != null &&
                    this.MssqlPassword.Equals(input.MssqlPassword))
                ) && 
                (
                    this.MssqlPort == input.MssqlPort ||
                    (this.MssqlPort != null &&
                    this.MssqlPort.Equals(input.MssqlPort))
                ) && 
                (
                    this.MssqlRevocationStatements == input.MssqlRevocationStatements ||
                    (this.MssqlRevocationStatements != null &&
                    this.MssqlRevocationStatements.Equals(input.MssqlRevocationStatements))
                ) && 
                (
                    this.MssqlUsername == input.MssqlUsername ||
                    (this.MssqlUsername != null &&
                    this.MssqlUsername.Equals(input.MssqlUsername))
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
                    this.ProducerEncryptionKeyName == input.ProducerEncryptionKeyName ||
                    (this.ProducerEncryptionKeyName != null &&
                    this.ProducerEncryptionKeyName.Equals(input.ProducerEncryptionKeyName))
                ) && 
                (
                    this.SecureAccessBastionIssuer == input.SecureAccessBastionIssuer ||
                    (this.SecureAccessBastionIssuer != null &&
                    this.SecureAccessBastionIssuer.Equals(input.SecureAccessBastionIssuer))
                ) && 
                (
                    this.SecureAccessDbSchema == input.SecureAccessDbSchema ||
                    (this.SecureAccessDbSchema != null &&
                    this.SecureAccessDbSchema.Equals(input.SecureAccessDbSchema))
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
                    this.SecureAccessWeb == input.SecureAccessWeb ||
                    this.SecureAccessWeb.Equals(input.SecureAccessWeb)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                    this.UserTtl == input.UserTtl ||
                    (this.UserTtl != null &&
                    this.UserTtl.Equals(input.UserTtl))
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
                if (this.DeleteProtection != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteProtection.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.MssqlCreateStatements != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlCreateStatements.GetHashCode();
                }
                if (this.MssqlDbname != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlDbname.GetHashCode();
                }
                if (this.MssqlHost != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlHost.GetHashCode();
                }
                if (this.MssqlPassword != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlPassword.GetHashCode();
                }
                if (this.MssqlPort != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlPort.GetHashCode();
                }
                if (this.MssqlRevocationStatements != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlRevocationStatements.GetHashCode();
                }
                if (this.MssqlUsername != null)
                {
                    hashCode = (hashCode * 59) + this.MssqlUsername.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PasswordLength != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordLength.GetHashCode();
                }
                if (this.ProducerEncryptionKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.ProducerEncryptionKeyName.GetHashCode();
                }
                if (this.SecureAccessBastionIssuer != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessBastionIssuer.GetHashCode();
                }
                if (this.SecureAccessDbSchema != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessDbSchema.GetHashCode();
                }
                if (this.SecureAccessEnable != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessEnable.GetHashCode();
                }
                if (this.SecureAccessHost != null)
                {
                    hashCode = (hashCode * 59) + this.SecureAccessHost.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureAccessWeb.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
                if (this.UserTtl != null)
                {
                    hashCode = (hashCode * 59) + this.UserTtl.GetHashCode();
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