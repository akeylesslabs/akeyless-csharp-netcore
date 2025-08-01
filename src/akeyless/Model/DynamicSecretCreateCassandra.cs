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
    /// dynamicSecretCreateCassandra is a command that creates a Cassandra dynamic secret
    /// </summary>
    [DataContract(Name = "dynamicSecretCreateCassandra")]
    public partial class DynamicSecretCreateCassandra : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretCreateCassandra" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DynamicSecretCreateCassandra() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretCreateCassandra" /> class.
        /// </summary>
        /// <param name="cassandraCreationStatements">Cassandra creation statements.</param>
        /// <param name="cassandraHosts">Cassandra hosts IP or addresses, comma separated.</param>
        /// <param name="cassandraPassword">Cassandra superuser password.</param>
        /// <param name="cassandraPort">Cassandra port (default to &quot;9042&quot;).</param>
        /// <param name="cassandraUsername">Cassandra superuser username.</param>
        /// <param name="customUsernameTemplate">Customize how temporary usernames are generated using go template.</param>
        /// <param name="deleteProtection">Protection from accidental deletion of this object [true/false].</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="name">Dynamic secret name (required).</param>
        /// <param name="passwordLength">The length of the password to be generated.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="ssl">Enable/Disable SSL [true/false] (default to false).</param>
        /// <param name="sslCertificate">SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA).</param>
        /// <param name="tags">Add tags attached to this object.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        public DynamicSecretCreateCassandra(string cassandraCreationStatements = default(string), string cassandraHosts = default(string), string cassandraPassword = default(string), string cassandraPort = @"9042", string cassandraUsername = default(string), string customUsernameTemplate = default(string), string deleteProtection = default(string), string description = default(string), bool json = false, string name = default(string), string passwordLength = default(string), string producerEncryptionKeyName = default(string), bool ssl = false, string sslCertificate = default(string), List<string> tags = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = @"60m")
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for DynamicSecretCreateCassandra and cannot be null");
            }
            this.Name = name;
            this.CassandraCreationStatements = cassandraCreationStatements;
            this.CassandraHosts = cassandraHosts;
            this.CassandraPassword = cassandraPassword;
            // use default value if no "cassandraPort" provided
            this.CassandraPort = cassandraPort ?? @"9042";
            this.CassandraUsername = cassandraUsername;
            this.CustomUsernameTemplate = customUsernameTemplate;
            this.DeleteProtection = deleteProtection;
            this.Description = description;
            this.Json = json;
            this.PasswordLength = passwordLength;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.Ssl = ssl;
            this.SslCertificate = sslCertificate;
            this.Tags = tags;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? @"60m";
        }

        /// <summary>
        /// Cassandra creation statements
        /// </summary>
        /// <value>Cassandra creation statements</value>
        [DataMember(Name = "cassandra-creation-statements", EmitDefaultValue = false)]
        public string CassandraCreationStatements { get; set; }

        /// <summary>
        /// Cassandra hosts IP or addresses, comma separated
        /// </summary>
        /// <value>Cassandra hosts IP or addresses, comma separated</value>
        [DataMember(Name = "cassandra-hosts", EmitDefaultValue = false)]
        public string CassandraHosts { get; set; }

        /// <summary>
        /// Cassandra superuser password
        /// </summary>
        /// <value>Cassandra superuser password</value>
        [DataMember(Name = "cassandra-password", EmitDefaultValue = false)]
        public string CassandraPassword { get; set; }

        /// <summary>
        /// Cassandra port
        /// </summary>
        /// <value>Cassandra port</value>
        [DataMember(Name = "cassandra-port", EmitDefaultValue = false)]
        public string CassandraPort { get; set; }

        /// <summary>
        /// Cassandra superuser username
        /// </summary>
        /// <value>Cassandra superuser username</value>
        [DataMember(Name = "cassandra-username", EmitDefaultValue = false)]
        public string CassandraUsername { get; set; }

        /// <summary>
        /// Customize how temporary usernames are generated using go template
        /// </summary>
        /// <value>Customize how temporary usernames are generated using go template</value>
        [DataMember(Name = "custom-username-template", EmitDefaultValue = false)]
        public string CustomUsernameTemplate { get; set; }

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
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

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
        /// Enable/Disable SSL [true/false]
        /// </summary>
        /// <value>Enable/Disable SSL [true/false]</value>
        [DataMember(Name = "ssl", EmitDefaultValue = true)]
        public bool Ssl { get; set; }

        /// <summary>
        /// SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA)
        /// </summary>
        /// <value>SSL CA certificate in base64 encoding generated from a trusted Certificate Authority (CA)</value>
        [DataMember(Name = "ssl-certificate", EmitDefaultValue = false)]
        public string SslCertificate { get; set; }

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
            sb.Append("class DynamicSecretCreateCassandra {\n");
            sb.Append("  CassandraCreationStatements: ").Append(CassandraCreationStatements).Append("\n");
            sb.Append("  CassandraHosts: ").Append(CassandraHosts).Append("\n");
            sb.Append("  CassandraPassword: ").Append(CassandraPassword).Append("\n");
            sb.Append("  CassandraPort: ").Append(CassandraPort).Append("\n");
            sb.Append("  CassandraUsername: ").Append(CassandraUsername).Append("\n");
            sb.Append("  CustomUsernameTemplate: ").Append(CustomUsernameTemplate).Append("\n");
            sb.Append("  DeleteProtection: ").Append(DeleteProtection).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PasswordLength: ").Append(PasswordLength).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  Ssl: ").Append(Ssl).Append("\n");
            sb.Append("  SslCertificate: ").Append(SslCertificate).Append("\n");
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
