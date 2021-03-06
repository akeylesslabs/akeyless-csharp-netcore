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
    /// gatewayCreateProducerMSSQL is a command that creates mssql producer
    /// </summary>
    [DataContract]
    public partial class GatewayCreateProducerMSSQL :  IEquatable<GatewayCreateProducerMSSQL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerMSSQL" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateProducerMSSQL() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerMSSQL" /> class.
        /// </summary>
        /// <param name="mssqlCreateStatements">MSSQL Creation statements.</param>
        /// <param name="mssqlDbname">MSSQL Name.</param>
        /// <param name="mssqlHost">MSSQL Host (default to &quot;127.0.0.1&quot;).</param>
        /// <param name="mssqlPassword">MSSQL Password.</param>
        /// <param name="mssqlPort">MSSQL Port (default to &quot;1433&quot;).</param>
        /// <param name="mssqlRevocationStatements">MSSQL Revocation statements.</param>
        /// <param name="mssqlUsername">MSSQL Username.</param>
        /// <param name="name">Producer name (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="secureAccessBastionIssuer">secureAccessBastionIssuer.</param>
        /// <param name="secureAccessDbSchema">secureAccessDbSchema.</param>
        /// <param name="secureAccessEnable">secureAccessEnable.</param>
        /// <param name="secureAccessHost">secureAccessHost.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public GatewayCreateProducerMSSQL(string mssqlCreateStatements = default(string), string mssqlDbname = default(string), string mssqlHost = "127.0.0.1", string mssqlPassword = default(string), string mssqlPort = "1433", string mssqlRevocationStatements = default(string), string mssqlUsername = default(string), string name = default(string), string password = default(string), string producerEncryptionKeyName = default(string), string secureAccessBastionIssuer = default(string), string secureAccessDbSchema = default(string), string secureAccessEnable = default(string), List<string> secureAccessHost = default(List<string>), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "60m", string username = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GatewayCreateProducerMSSQL and cannot be null");
            this.MssqlCreateStatements = mssqlCreateStatements;
            this.MssqlDbname = mssqlDbname;
            // use default value if no "mssqlHost" provided
            this.MssqlHost = mssqlHost ?? "127.0.0.1";
            this.MssqlPassword = mssqlPassword;
            // use default value if no "mssqlPort" provided
            this.MssqlPort = mssqlPort ?? "1433";
            this.MssqlRevocationStatements = mssqlRevocationStatements;
            this.MssqlUsername = mssqlUsername;
            this.Password = password;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.SecureAccessBastionIssuer = secureAccessBastionIssuer;
            this.SecureAccessDbSchema = secureAccessDbSchema;
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
        /// MSSQL Creation statements
        /// </summary>
        /// <value>MSSQL Creation statements</value>
        [DataMember(Name="mssql-create-statements", EmitDefaultValue=false)]
        public string MssqlCreateStatements { get; set; }

        /// <summary>
        /// MSSQL Name
        /// </summary>
        /// <value>MSSQL Name</value>
        [DataMember(Name="mssql-dbname", EmitDefaultValue=false)]
        public string MssqlDbname { get; set; }

        /// <summary>
        /// MSSQL Host
        /// </summary>
        /// <value>MSSQL Host</value>
        [DataMember(Name="mssql-host", EmitDefaultValue=false)]
        public string MssqlHost { get; set; }

        /// <summary>
        /// MSSQL Password
        /// </summary>
        /// <value>MSSQL Password</value>
        [DataMember(Name="mssql-password", EmitDefaultValue=false)]
        public string MssqlPassword { get; set; }

        /// <summary>
        /// MSSQL Port
        /// </summary>
        /// <value>MSSQL Port</value>
        [DataMember(Name="mssql-port", EmitDefaultValue=false)]
        public string MssqlPort { get; set; }

        /// <summary>
        /// MSSQL Revocation statements
        /// </summary>
        /// <value>MSSQL Revocation statements</value>
        [DataMember(Name="mssql-revocation-statements", EmitDefaultValue=false)]
        public string MssqlRevocationStatements { get; set; }

        /// <summary>
        /// MSSQL Username
        /// </summary>
        /// <value>MSSQL Username</value>
        [DataMember(Name="mssql-username", EmitDefaultValue=false)]
        public string MssqlUsername { get; set; }

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
        /// Gets or Sets SecureAccessDbSchema
        /// </summary>
        [DataMember(Name="secure-access-db-schema", EmitDefaultValue=false)]
        public string SecureAccessDbSchema { get; set; }

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
            sb.Append("class GatewayCreateProducerMSSQL {\n");
            sb.Append("  MssqlCreateStatements: ").Append(MssqlCreateStatements).Append("\n");
            sb.Append("  MssqlDbname: ").Append(MssqlDbname).Append("\n");
            sb.Append("  MssqlHost: ").Append(MssqlHost).Append("\n");
            sb.Append("  MssqlPassword: ").Append(MssqlPassword).Append("\n");
            sb.Append("  MssqlPort: ").Append(MssqlPort).Append("\n");
            sb.Append("  MssqlRevocationStatements: ").Append(MssqlRevocationStatements).Append("\n");
            sb.Append("  MssqlUsername: ").Append(MssqlUsername).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  SecureAccessBastionIssuer: ").Append(SecureAccessBastionIssuer).Append("\n");
            sb.Append("  SecureAccessDbSchema: ").Append(SecureAccessDbSchema).Append("\n");
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
            return this.Equals(input as GatewayCreateProducerMSSQL);
        }

        /// <summary>
        /// Returns true if GatewayCreateProducerMSSQL instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayCreateProducerMSSQL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayCreateProducerMSSQL input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.MssqlCreateStatements != null)
                    hashCode = hashCode * 59 + this.MssqlCreateStatements.GetHashCode();
                if (this.MssqlDbname != null)
                    hashCode = hashCode * 59 + this.MssqlDbname.GetHashCode();
                if (this.MssqlHost != null)
                    hashCode = hashCode * 59 + this.MssqlHost.GetHashCode();
                if (this.MssqlPassword != null)
                    hashCode = hashCode * 59 + this.MssqlPassword.GetHashCode();
                if (this.MssqlPort != null)
                    hashCode = hashCode * 59 + this.MssqlPort.GetHashCode();
                if (this.MssqlRevocationStatements != null)
                    hashCode = hashCode * 59 + this.MssqlRevocationStatements.GetHashCode();
                if (this.MssqlUsername != null)
                    hashCode = hashCode * 59 + this.MssqlUsername.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProducerEncryptionKeyName != null)
                    hashCode = hashCode * 59 + this.ProducerEncryptionKeyName.GetHashCode();
                if (this.SecureAccessBastionIssuer != null)
                    hashCode = hashCode * 59 + this.SecureAccessBastionIssuer.GetHashCode();
                if (this.SecureAccessDbSchema != null)
                    hashCode = hashCode * 59 + this.SecureAccessDbSchema.GetHashCode();
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
