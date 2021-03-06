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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = akeyless.Client.OpenAPIDateConverter;

namespace akeyless.Model
{
    /// <summary>
    /// gatewayCreateProducerOracleDb is a command that creates oracle db producer
    /// </summary>
    [DataContract]
    public partial class GatewayCreateProducerOracleDb :  IEquatable<GatewayCreateProducerOracleDb>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerOracleDb" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateProducerOracleDb() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerOracleDb" /> class.
        /// </summary>
        /// <param name="dbServerCertificates">(Optional) DB server certificates.</param>
        /// <param name="dbServerName">(Optional) Server name for certificate verification.</param>
        /// <param name="name">Producer name (required).</param>
        /// <param name="oracleHost">Oracle Host (default to &quot;127.0.0.1&quot;).</param>
        /// <param name="oraclePassword">Oracle Password.</param>
        /// <param name="oraclePort">Oracle Port (default to &quot;1521&quot;).</param>
        /// <param name="oracleScreationStatements">Oracle Creation statements.</param>
        /// <param name="oracleServiceName">Oracle DB Name.</param>
        /// <param name="oracleUsername">Oracle Username.</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public GatewayCreateProducerOracleDb(string dbServerCertificates = default(string), string dbServerName = default(string), string name = default(string), string oracleHost = "127.0.0.1", string oraclePassword = default(string), string oraclePort = "1521", string oracleScreationStatements = default(string), string oracleServiceName = default(string), string oracleUsername = default(string), string password = default(string), string producerEncryptionKeyName = default(string), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "60m", string username = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GatewayCreateProducerOracleDb and cannot be null");
            this.DbServerCertificates = dbServerCertificates;
            this.DbServerName = dbServerName;
            // use default value if no "oracleHost" provided
            this.OracleHost = oracleHost ?? "127.0.0.1";
            this.OraclePassword = oraclePassword;
            // use default value if no "oraclePort" provided
            this.OraclePort = oraclePort ?? "1521";
            this.OracleScreationStatements = oracleScreationStatements;
            this.OracleServiceName = oracleServiceName;
            this.OracleUsername = oracleUsername;
            this.Password = password;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? "60m";
            this.Username = username;
        }
        
        /// <summary>
        /// (Optional) DB server certificates
        /// </summary>
        /// <value>(Optional) DB server certificates</value>
        [DataMember(Name="db-server-certificates", EmitDefaultValue=false)]
        public string DbServerCertificates { get; set; }

        /// <summary>
        /// (Optional) Server name for certificate verification
        /// </summary>
        /// <value>(Optional) Server name for certificate verification</value>
        [DataMember(Name="db-server-name", EmitDefaultValue=false)]
        public string DbServerName { get; set; }

        /// <summary>
        /// Producer name
        /// </summary>
        /// <value>Producer name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Oracle Host
        /// </summary>
        /// <value>Oracle Host</value>
        [DataMember(Name="oracle-host", EmitDefaultValue=false)]
        public string OracleHost { get; set; }

        /// <summary>
        /// Oracle Password
        /// </summary>
        /// <value>Oracle Password</value>
        [DataMember(Name="oracle-password", EmitDefaultValue=false)]
        public string OraclePassword { get; set; }

        /// <summary>
        /// Oracle Port
        /// </summary>
        /// <value>Oracle Port</value>
        [DataMember(Name="oracle-port", EmitDefaultValue=false)]
        public string OraclePort { get; set; }

        /// <summary>
        /// Oracle Creation statements
        /// </summary>
        /// <value>Oracle Creation statements</value>
        [DataMember(Name="oracle-screation-statements", EmitDefaultValue=false)]
        public string OracleScreationStatements { get; set; }

        /// <summary>
        /// Oracle DB Name
        /// </summary>
        /// <value>Oracle DB Name</value>
        [DataMember(Name="oracle-service-name", EmitDefaultValue=false)]
        public string OracleServiceName { get; set; }

        /// <summary>
        /// Oracle Username
        /// </summary>
        /// <value>Oracle Username</value>
        [DataMember(Name="oracle-username", EmitDefaultValue=false)]
        public string OracleUsername { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Dynamic producer encryption key
        /// </summary>
        /// <value>Dynamic producer encryption key</value>
        [DataMember(Name="producer-encryption-key-name", EmitDefaultValue=false)]
        public string ProducerEncryptionKeyName { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name="target-name", EmitDefaultValue=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name="uid-token", EmitDefaultValue=false)]
        public string UidToken { get; set; }

        /// <summary>
        /// User TTL
        /// </summary>
        /// <value>User TTL</value>
        [DataMember(Name="user-ttl", EmitDefaultValue=false)]
        public string UserTtl { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GatewayCreateProducerOracleDb {\n");
            sb.Append("  DbServerCertificates: ").Append(DbServerCertificates).Append("\n");
            sb.Append("  DbServerName: ").Append(DbServerName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OracleHost: ").Append(OracleHost).Append("\n");
            sb.Append("  OraclePassword: ").Append(OraclePassword).Append("\n");
            sb.Append("  OraclePort: ").Append(OraclePort).Append("\n");
            sb.Append("  OracleScreationStatements: ").Append(OracleScreationStatements).Append("\n");
            sb.Append("  OracleServiceName: ").Append(OracleServiceName).Append("\n");
            sb.Append("  OracleUsername: ").Append(OracleUsername).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UserTtl: ").Append(UserTtl).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GatewayCreateProducerOracleDb);
        }

        /// <summary>
        /// Returns true if GatewayCreateProducerOracleDb instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayCreateProducerOracleDb to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayCreateProducerOracleDb input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbServerCertificates == input.DbServerCertificates ||
                    (this.DbServerCertificates != null &&
                    this.DbServerCertificates.Equals(input.DbServerCertificates))
                ) && 
                (
                    this.DbServerName == input.DbServerName ||
                    (this.DbServerName != null &&
                    this.DbServerName.Equals(input.DbServerName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OracleHost == input.OracleHost ||
                    (this.OracleHost != null &&
                    this.OracleHost.Equals(input.OracleHost))
                ) && 
                (
                    this.OraclePassword == input.OraclePassword ||
                    (this.OraclePassword != null &&
                    this.OraclePassword.Equals(input.OraclePassword))
                ) && 
                (
                    this.OraclePort == input.OraclePort ||
                    (this.OraclePort != null &&
                    this.OraclePort.Equals(input.OraclePort))
                ) && 
                (
                    this.OracleScreationStatements == input.OracleScreationStatements ||
                    (this.OracleScreationStatements != null &&
                    this.OracleScreationStatements.Equals(input.OracleScreationStatements))
                ) && 
                (
                    this.OracleServiceName == input.OracleServiceName ||
                    (this.OracleServiceName != null &&
                    this.OracleServiceName.Equals(input.OracleServiceName))
                ) && 
                (
                    this.OracleUsername == input.OracleUsername ||
                    (this.OracleUsername != null &&
                    this.OracleUsername.Equals(input.OracleUsername))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.ProducerEncryptionKeyName == input.ProducerEncryptionKeyName ||
                    (this.ProducerEncryptionKeyName != null &&
                    this.ProducerEncryptionKeyName.Equals(input.ProducerEncryptionKeyName))
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
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.DbServerCertificates != null)
                    hashCode = hashCode * 59 + this.DbServerCertificates.GetHashCode();
                if (this.DbServerName != null)
                    hashCode = hashCode * 59 + this.DbServerName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OracleHost != null)
                    hashCode = hashCode * 59 + this.OracleHost.GetHashCode();
                if (this.OraclePassword != null)
                    hashCode = hashCode * 59 + this.OraclePassword.GetHashCode();
                if (this.OraclePort != null)
                    hashCode = hashCode * 59 + this.OraclePort.GetHashCode();
                if (this.OracleScreationStatements != null)
                    hashCode = hashCode * 59 + this.OracleScreationStatements.GetHashCode();
                if (this.OracleServiceName != null)
                    hashCode = hashCode * 59 + this.OracleServiceName.GetHashCode();
                if (this.OracleUsername != null)
                    hashCode = hashCode * 59 + this.OracleUsername.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProducerEncryptionKeyName != null)
                    hashCode = hashCode * 59 + this.ProducerEncryptionKeyName.GetHashCode();
                if (this.TargetName != null)
                    hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UidToken != null)
                    hashCode = hashCode * 59 + this.UidToken.GetHashCode();
                if (this.UserTtl != null)
                    hashCode = hashCode * 59 + this.UserTtl.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
