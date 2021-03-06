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
    /// gatewayCreateProducerChef is a command that creates chef producer
    /// </summary>
    [DataContract]
    public partial class GatewayCreateProducerChef :  IEquatable<GatewayCreateProducerChef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerChef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateProducerChef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerChef" /> class.
        /// </summary>
        /// <param name="chefOrgs">Organizations.</param>
        /// <param name="chefServerKey">Server key.</param>
        /// <param name="chefServerUrl">Server URL.</param>
        /// <param name="chefServerUsername">Server username.</param>
        /// <param name="name">Producer name (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="skipSsl">Skip SSL (default to true).</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public GatewayCreateProducerChef(string chefOrgs = default(string), string chefServerKey = default(string), string chefServerUrl = default(string), string chefServerUsername = default(string), string name = default(string), string password = default(string), string producerEncryptionKeyName = default(string), bool skipSsl = true, string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "60m", string username = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GatewayCreateProducerChef and cannot be null");
            this.ChefOrgs = chefOrgs;
            this.ChefServerKey = chefServerKey;
            this.ChefServerUrl = chefServerUrl;
            this.ChefServerUsername = chefServerUsername;
            this.Password = password;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.SkipSsl = skipSsl;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? "60m";
            this.Username = username;
        }
        
        /// <summary>
        /// Organizations
        /// </summary>
        /// <value>Organizations</value>
        [DataMember(Name="chef-orgs", EmitDefaultValue=false)]
        public string ChefOrgs { get; set; }

        /// <summary>
        /// Server key
        /// </summary>
        /// <value>Server key</value>
        [DataMember(Name="chef-server-key", EmitDefaultValue=false)]
        public string ChefServerKey { get; set; }

        /// <summary>
        /// Server URL
        /// </summary>
        /// <value>Server URL</value>
        [DataMember(Name="chef-server-url", EmitDefaultValue=false)]
        public string ChefServerUrl { get; set; }

        /// <summary>
        /// Server username
        /// </summary>
        /// <value>Server username</value>
        [DataMember(Name="chef-server-username", EmitDefaultValue=false)]
        public string ChefServerUsername { get; set; }

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
        /// Skip SSL
        /// </summary>
        /// <value>Skip SSL</value>
        [DataMember(Name="skip-ssl", EmitDefaultValue=false)]
        public bool SkipSsl { get; set; }

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
            sb.Append("class GatewayCreateProducerChef {\n");
            sb.Append("  ChefOrgs: ").Append(ChefOrgs).Append("\n");
            sb.Append("  ChefServerKey: ").Append(ChefServerKey).Append("\n");
            sb.Append("  ChefServerUrl: ").Append(ChefServerUrl).Append("\n");
            sb.Append("  ChefServerUsername: ").Append(ChefServerUsername).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  SkipSsl: ").Append(SkipSsl).Append("\n");
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
            return this.Equals(input as GatewayCreateProducerChef);
        }

        /// <summary>
        /// Returns true if GatewayCreateProducerChef instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayCreateProducerChef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayCreateProducerChef input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChefOrgs == input.ChefOrgs ||
                    (this.ChefOrgs != null &&
                    this.ChefOrgs.Equals(input.ChefOrgs))
                ) && 
                (
                    this.ChefServerKey == input.ChefServerKey ||
                    (this.ChefServerKey != null &&
                    this.ChefServerKey.Equals(input.ChefServerKey))
                ) && 
                (
                    this.ChefServerUrl == input.ChefServerUrl ||
                    (this.ChefServerUrl != null &&
                    this.ChefServerUrl.Equals(input.ChefServerUrl))
                ) && 
                (
                    this.ChefServerUsername == input.ChefServerUsername ||
                    (this.ChefServerUsername != null &&
                    this.ChefServerUsername.Equals(input.ChefServerUsername))
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
                    this.SkipSsl == input.SkipSsl ||
                    this.SkipSsl.Equals(input.SkipSsl)
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
                if (this.ChefOrgs != null)
                    hashCode = hashCode * 59 + this.ChefOrgs.GetHashCode();
                if (this.ChefServerKey != null)
                    hashCode = hashCode * 59 + this.ChefServerKey.GetHashCode();
                if (this.ChefServerUrl != null)
                    hashCode = hashCode * 59 + this.ChefServerUrl.GetHashCode();
                if (this.ChefServerUsername != null)
                    hashCode = hashCode * 59 + this.ChefServerUsername.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProducerEncryptionKeyName != null)
                    hashCode = hashCode * 59 + this.ProducerEncryptionKeyName.GetHashCode();
                hashCode = hashCode * 59 + this.SkipSsl.GetHashCode();
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
