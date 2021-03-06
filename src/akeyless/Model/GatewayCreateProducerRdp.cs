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
    /// gatewayCreateProducerRdp is a command that creates rdp producer
    /// </summary>
    [DataContract]
    public partial class GatewayCreateProducerRdp :  IEquatable<GatewayCreateProducerRdp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerRdp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GatewayCreateProducerRdp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayCreateProducerRdp" /> class.
        /// </summary>
        /// <param name="fixedUserOnly">Fixed user (default to &quot;false&quot;).</param>
        /// <param name="name">Producer name (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="producerEncryptionKeyName">Dynamic producer encryption key.</param>
        /// <param name="rdpAdminName">RDP Admin Name.</param>
        /// <param name="rdpAdminPwd">RDP Admin password.</param>
        /// <param name="rdpHostName">Hostname.</param>
        /// <param name="rdpHostPort">Port (default to &quot;22&quot;).</param>
        /// <param name="rdpUserGroups">Groups.</param>
        /// <param name="secureAccessEnable">secureAccessEnable.</param>
        /// <param name="secureAccessHost">secureAccessHost.</param>
        /// <param name="secureAccessRdpDomain">secureAccessRdpDomain.</param>
        /// <param name="targetName">Target name.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="userTtl">User TTL (default to &quot;60m&quot;).</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public GatewayCreateProducerRdp(string fixedUserOnly = "false", string name = default(string), string password = default(string), string producerEncryptionKeyName = default(string), string rdpAdminName = default(string), string rdpAdminPwd = default(string), string rdpHostName = default(string), string rdpHostPort = "22", string rdpUserGroups = default(string), string secureAccessEnable = default(string), List<string> secureAccessHost = default(List<string>), string secureAccessRdpDomain = default(string), string targetName = default(string), string token = default(string), string uidToken = default(string), string userTtl = "60m", string username = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GatewayCreateProducerRdp and cannot be null");
            // use default value if no "fixedUserOnly" provided
            this.FixedUserOnly = fixedUserOnly ?? "false";
            this.Password = password;
            this.ProducerEncryptionKeyName = producerEncryptionKeyName;
            this.RdpAdminName = rdpAdminName;
            this.RdpAdminPwd = rdpAdminPwd;
            this.RdpHostName = rdpHostName;
            // use default value if no "rdpHostPort" provided
            this.RdpHostPort = rdpHostPort ?? "22";
            this.RdpUserGroups = rdpUserGroups;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessHost = secureAccessHost;
            this.SecureAccessRdpDomain = secureAccessRdpDomain;
            this.TargetName = targetName;
            this.Token = token;
            this.UidToken = uidToken;
            // use default value if no "userTtl" provided
            this.UserTtl = userTtl ?? "60m";
            this.Username = username;
        }
        
        /// <summary>
        /// Fixed user
        /// </summary>
        /// <value>Fixed user</value>
        [DataMember(Name="fixed-user-only", EmitDefaultValue=false)]
        public string FixedUserOnly { get; set; }

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
        /// RDP Admin Name
        /// </summary>
        /// <value>RDP Admin Name</value>
        [DataMember(Name="rdp-admin-name", EmitDefaultValue=false)]
        public string RdpAdminName { get; set; }

        /// <summary>
        /// RDP Admin password
        /// </summary>
        /// <value>RDP Admin password</value>
        [DataMember(Name="rdp-admin-pwd", EmitDefaultValue=false)]
        public string RdpAdminPwd { get; set; }

        /// <summary>
        /// Hostname
        /// </summary>
        /// <value>Hostname</value>
        [DataMember(Name="rdp-host-name", EmitDefaultValue=false)]
        public string RdpHostName { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        /// <value>Port</value>
        [DataMember(Name="rdp-host-port", EmitDefaultValue=false)]
        public string RdpHostPort { get; set; }

        /// <summary>
        /// Groups
        /// </summary>
        /// <value>Groups</value>
        [DataMember(Name="rdp-user-groups", EmitDefaultValue=false)]
        public string RdpUserGroups { get; set; }

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
        /// Gets or Sets SecureAccessRdpDomain
        /// </summary>
        [DataMember(Name="secure-access-rdp-domain", EmitDefaultValue=false)]
        public string SecureAccessRdpDomain { get; set; }

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
            sb.Append("class GatewayCreateProducerRdp {\n");
            sb.Append("  FixedUserOnly: ").Append(FixedUserOnly).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProducerEncryptionKeyName: ").Append(ProducerEncryptionKeyName).Append("\n");
            sb.Append("  RdpAdminName: ").Append(RdpAdminName).Append("\n");
            sb.Append("  RdpAdminPwd: ").Append(RdpAdminPwd).Append("\n");
            sb.Append("  RdpHostName: ").Append(RdpHostName).Append("\n");
            sb.Append("  RdpHostPort: ").Append(RdpHostPort).Append("\n");
            sb.Append("  RdpUserGroups: ").Append(RdpUserGroups).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
            sb.Append("  SecureAccessRdpDomain: ").Append(SecureAccessRdpDomain).Append("\n");
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
            return this.Equals(input as GatewayCreateProducerRdp);
        }

        /// <summary>
        /// Returns true if GatewayCreateProducerRdp instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayCreateProducerRdp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayCreateProducerRdp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FixedUserOnly == input.FixedUserOnly ||
                    (this.FixedUserOnly != null &&
                    this.FixedUserOnly.Equals(input.FixedUserOnly))
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
                    this.RdpAdminName == input.RdpAdminName ||
                    (this.RdpAdminName != null &&
                    this.RdpAdminName.Equals(input.RdpAdminName))
                ) && 
                (
                    this.RdpAdminPwd == input.RdpAdminPwd ||
                    (this.RdpAdminPwd != null &&
                    this.RdpAdminPwd.Equals(input.RdpAdminPwd))
                ) && 
                (
                    this.RdpHostName == input.RdpHostName ||
                    (this.RdpHostName != null &&
                    this.RdpHostName.Equals(input.RdpHostName))
                ) && 
                (
                    this.RdpHostPort == input.RdpHostPort ||
                    (this.RdpHostPort != null &&
                    this.RdpHostPort.Equals(input.RdpHostPort))
                ) && 
                (
                    this.RdpUserGroups == input.RdpUserGroups ||
                    (this.RdpUserGroups != null &&
                    this.RdpUserGroups.Equals(input.RdpUserGroups))
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
                if (this.FixedUserOnly != null)
                    hashCode = hashCode * 59 + this.FixedUserOnly.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.ProducerEncryptionKeyName != null)
                    hashCode = hashCode * 59 + this.ProducerEncryptionKeyName.GetHashCode();
                if (this.RdpAdminName != null)
                    hashCode = hashCode * 59 + this.RdpAdminName.GetHashCode();
                if (this.RdpAdminPwd != null)
                    hashCode = hashCode * 59 + this.RdpAdminPwd.GetHashCode();
                if (this.RdpHostName != null)
                    hashCode = hashCode * 59 + this.RdpHostName.GetHashCode();
                if (this.RdpHostPort != null)
                    hashCode = hashCode * 59 + this.RdpHostPort.GetHashCode();
                if (this.RdpUserGroups != null)
                    hashCode = hashCode * 59 + this.RdpUserGroups.GetHashCode();
                if (this.SecureAccessEnable != null)
                    hashCode = hashCode * 59 + this.SecureAccessEnable.GetHashCode();
                if (this.SecureAccessHost != null)
                    hashCode = hashCode * 59 + this.SecureAccessHost.GetHashCode();
                if (this.SecureAccessRdpDomain != null)
                    hashCode = hashCode * 59 + this.SecureAccessRdpDomain.GetHashCode();
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
