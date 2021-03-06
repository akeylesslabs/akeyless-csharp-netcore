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
    /// gatewayCreateProducerMySQL is a command that creates mysql producer
    /// </summary>
    [DataContract]
    public partial class GatewayCreateProducerMySQL :  IEquatable<GatewayCreateProducerMySQL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerMySQL" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateProducerMySQL() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerMySQL" /> class.
        /// </summary>
        /// <param name="dbServerCertificates">(Optional) DB server certificates.</param>
        /// <param name="dbServerName">(Optional) Server name for certificate verification.</param>
        /// <param name="mysqlDbname">MySQL DB Name.</param>
        /// <param name="mysqlHost">MySQL Host (default to &quot;127.0.0.1&quot;).</param>
        /// <param name="mysqlPassword">MySQL Password.</param>
        /// <param name="mysqlPort">MySQL Port (default to &quot;3306&quot;).</param>
        /// <param name="mysqlScreationStatements">MySQL Creation statements.</param>
        /// <param name="mysqlUsername">MySQL Username.</param>
        /// <param name="name">Producer name (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="secureAccessBastionIssuer">secureAccessBastionIssuer.</param>
        /// <param name="secureAccessEnable">secureAccessEnable.</param>
        /// <param name="secureAccessHost">secureAccessHost.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public GatewayCreateProducerMySQL(string dbServerCertificates = default(string), string dbServerName = default(string), string mysqlDbname = default(string), string mysqlHost = "127.0.0.1", string mysqlPassword = default(string), string mysqlPort = "3306", string mysqlScreationStatements = default(string), string mysqlUsername = default(string), string name = default(string), string password = default(string), string producerEncryptionKeyName = default(string), string secureAccessBastionIssuer = default(string), string secureAccessEnable = default(string), List<string> secureAccessHost = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "60m", string username = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GatewayCreateProducerMySQL and cannot be null");
            this.DbServerCertificates = dbServerCertificates;
            this.DbServerName = dbServerName;
            this.MysqlDbname = mysqlDbname;
            // use default value if no "mysqlHost" provided
            this.MysqlHost = mysqlHost ?? "127.0.0.1";
            this.MysqlPassword = mysqlPassword;
            // use default value if no "mysqlPort" provided
            this.MysqlPort = mysqlPort ?? "3306";
            this.MysqlScreationStatements = mysqlScreationStatements;
            this.MysqlUsername = mysqlUsername;
            this.Password = password;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessHost = secureAccessHost;
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
        /// MySQL DB Name
        /// </summary>
        /// <value>MySQL DB Name</value>
        [DataMember(Name="mysql-dbname", EmitDefaultValue=false)]
        public string MysqlDbname { get; set; }

        /// <summary>
        /// MySQL Host
        /// </summary>
        /// <value>MySQL Host</value>
        [DataMember(Name="mysql-host", EmitDefaultValue=false)]
        public string MysqlHost { get; set; }

        /// <summary>
        /// MySQL Password
        /// </summary>
        /// <value>MySQL Password</value>
        [DataMember(Name="mysql-password", EmitDefaultValue=false)]
        public string MysqlPassword { get; set; }

        /// <summary>
        /// MySQL Port
        /// </summary>
        /// <value>MySQL Port</value>
        [DataMember(Name="mysql-port", EmitDefaultValue=false)]
        public string MysqlPort { get; set; }

        /// <summary>
        /// MySQL Creation statements
        /// </summary>
        /// <value>MySQL Creation statements</value>
        [DataMember(Name="mysql-screation-statements", EmitDefaultValue=false)]
        public string MysqlScreationStatements { get; set; }

        /// <summary>
        /// MySQL Username
        /// </summary>
        /// <value>MySQL Username</value>
        [DataMember(Name="mysql-username", EmitDefaultValue=false)]
        public string MysqlUsername { get; set; }

        /// <summary>
        /// Producer name
        /// </summary>
        /// <value>Producer name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// Gets or Sets SecureAccessBastionIssuer
        /// </summary>
        [DataMember(Name="secure-access-bastion-issuer", EmitDefaultValue=false)]
        public string SecureAccessBastionIssuer { get; set; }

        /// <summary>
        /// Gets or Sets SecureAccessEnable
        /// </summary>
        [DataMember(Name="secure-access-enable", EmitDefaultValue=false)]
        public string SecureAccessEnable { get; set; }

        /// <summary>
        /// Gets or Sets SecureAccessHost
        /// </summary>
        [DataMember(Name="secure-access-host", EmitDefaultValue=false)]
        public List<string> SecureAccessHost { get; set; }

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
            sb.Append("class GatewayCreateProducerMySQL {\n");
            sb.Append("  DbServerCertificates: ").Append(DbServerCertificates).Append("\n");
            sb.Append("  DbServerName: ").Append(DbServerName).Append("\n");
            sb.Append("  MysqlDbname: ").Append(MysqlDbname).Append("\n");
            sb.Append("  MysqlHost: ").Append(MysqlHost).Append("\n");
            sb.Append("  MysqlPassword: ").Append(MysqlPassword).Append("\n");
            sb.Append("  MysqlPort: ").Append(MysqlPort).Append("\n");
            sb.Append("  MysqlScreationStatements: ").Append(MysqlScreationStatements).Append("\n");
            sb.Append("  MysqlUsername: ").Append(MysqlUsername).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
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
            return this.Equals(input as GatewayCreateProducerMySQL);
        }

        /// <summary>
        /// Returns true if GatewayCreateProducerMySQL instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayCreateProducerMySQL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayCreateProducerMySQL input)
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
                    this.MysqlDbname == input.MysqlDbname ||
                    (this.MysqlDbname != null &&
                    this.MysqlDbname.Equals(input.MysqlDbname))
                ) && 
                (
                    this.MysqlHost == input.MysqlHost ||
                    (this.MysqlHost != null &&
                    this.MysqlHost.Equals(input.MysqlHost))
                ) && 
                (
                    this.MysqlPassword == input.MysqlPassword ||
                    (this.MysqlPassword != null &&
                    this.MysqlPassword.Equals(input.MysqlPassword))
                ) && 
                (
                    this.MysqlPort == input.MysqlPort ||
                    (this.MysqlPort != null &&
                    this.MysqlPort.Equals(input.MysqlPort))
                ) && 
                (
                    this.MysqlScreationStatements == input.MysqlScreationStatements ||
                    (this.MysqlScreationStatements != null &&
                    this.MysqlScreationStatements.Equals(input.MysqlScreationStatements))
                ) && 
                (
                    this.MysqlUsername == input.MysqlUsername ||
                    (this.MysqlUsername != null &&
                    this.MysqlUsername.Equals(input.MysqlUsername))
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
                if (this.MysqlDbname != null)
                    hashCode = hashCode * 59 + this.MysqlDbname.GetHashCode();
                if (this.MysqlHost != null)
                    hashCode = hashCode * 59 + this.MysqlHost.GetHashCode();
                if (this.MysqlPassword != null)
                    hashCode = hashCode * 59 + this.MysqlPassword.GetHashCode();
                if (this.MysqlPort != null)
                    hashCode = hashCode * 59 + this.MysqlPort.GetHashCode();
                if (this.MysqlScreationStatements != null)
                    hashCode = hashCode * 59 + this.MysqlScreationStatements.GetHashCode();
                if (this.MysqlUsername != null)
                    hashCode = hashCode * 59 + this.MysqlUsername.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProducerEncryptionKeyName != null)
                    hashCode = hashCode * 59 + this.ProducerEncryptionKeyName.GetHashCode();
                if (this.SecureAccessBastionIssuer != null)
                    hashCode = hashCode * 59 + this.SecureAccessBastionIssuer.GetHashCode();
                if (this.SecureAccessEnable != null)
                    hashCode = hashCode * 59 + this.SecureAccessEnable.GetHashCode();
                if (this.SecureAccessHost != null)
                    hashCode = hashCode * 59 + this.SecureAccessHost.GetHashCode();
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
