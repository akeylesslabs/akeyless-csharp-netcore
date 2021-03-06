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
    /// CreateSSHCertIssuer
    /// </summary>
    [DataContract]
    public partial class CreateSSHCertIssuer :  IEquatable<CreateSSHCertIssuer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSSHCertIssuer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSSHCertIssuer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSSHCertIssuer" /> class.
        /// </summary>
        /// <param name="allowedUsers">Users allowed to fetch the certificate, e.g root,ubuntu (required).</param>
        /// <param name="extensions">Signed certificates with extensions, e.g permit-port-forwarding&#x3D;\\\&quot;\\\&quot;.</param>
        /// <param name="metadata">A metadata about the issuer.</param>
        /// <param name="name">SSH certificate issuer name (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="principals">Signed certificates with principal, e.g example_role1,example_role2.</param>
        /// <param name="secureAccessBastionApi">secureAccessBastionApi.</param>
        /// <param name="secureAccessBastionSsh">secureAccessBastionSsh.</param>
        /// <param name="secureAccessEnable">secureAccessEnable.</param>
        /// <param name="secureAccessHost">secureAccessHost.</param>
        /// <param name="secureAccessSshCredsUser">secureAccessSshCredsUser.</param>
        /// <param name="signerKeyName">A key to sign the certificate with (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="ttl">The requested Time To Live for the certificate, use second units (required).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public CreateSSHCertIssuer(string allowedUsers = default(string), Dictionary<string, string> extensions = default(Dictionary<string, string>), string metadata = default(string), string name = default(string), string password = default(string), string principals = default(string), string secureAccessBastionApi = default(string), string secureAccessBastionSsh = default(string), string secureAccessEnable = default(string), List<string> secureAccessHost = default(List<string>), string secureAccessSshCredsUser = default(string), string signerKeyName = default(string), string token = default(string), long ttl = default(long), string uidToken = default(string), string username = default(string))
        {
            // to ensure "allowedUsers" is required (not null)
            this.AllowedUsers = allowedUsers ?? throw new ArgumentNullException("allowedUsers is a required property for CreateSSHCertIssuer and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for CreateSSHCertIssuer and cannot be null");
            // to ensure "signerKeyName" is required (not null)
            this.SignerKeyName = signerKeyName ?? throw new ArgumentNullException("signerKeyName is a required property for CreateSSHCertIssuer and cannot be null");
            this.Ttl = ttl;
            this.Extensions = extensions;
            this.Metadata = metadata;
            this.Password = password;
            this.Principals = principals;
            this.SecureAccessBastionApi = secureAccessBastionApi;
            this.SecureAccessBastionSsh = secureAccessBastionSsh;
            this.SecureAccessEnable = secureAccessEnable;
            this.SecureAccessHost = secureAccessHost;
            this.SecureAccessSshCredsUser = secureAccessSshCredsUser;
            this.Token = token;
            this.UidToken = uidToken;
            this.Username = username;
        }
        
        /// <summary>
        /// Users allowed to fetch the certificate, e.g root,ubuntu
        /// </summary>
        /// <value>Users allowed to fetch the certificate, e.g root,ubuntu</value>
        [DataMember(Name="allowed-users", EmitDefaultValue=false)]
        public string AllowedUsers { get; set; }

        /// <summary>
        /// Signed certificates with extensions, e.g permit-port-forwarding&#x3D;\\\&quot;\\\&quot;
        /// </summary>
        /// <value>Signed certificates with extensions, e.g permit-port-forwarding&#x3D;\\\&quot;\\\&quot;</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public Dictionary<string, string> Extensions { get; set; }

        /// <summary>
        /// A metadata about the issuer
        /// </summary>
        /// <value>A metadata about the issuer</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// SSH certificate issuer name
        /// </summary>
        /// <value>SSH certificate issuer name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Signed certificates with principal, e.g example_role1,example_role2
        /// </summary>
        /// <value>Signed certificates with principal, e.g example_role1,example_role2</value>
        [DataMember(Name="principals", EmitDefaultValue=false)]
        public string Principals { get; set; }

        /// <summary>
        /// Gets or Sets SecureAccessBastionApi
        /// </summary>
        [DataMember(Name="secure-access-bastion-api", EmitDefaultValue=false)]
        public string SecureAccessBastionApi { get; set; }

        /// <summary>
        /// Gets or Sets SecureAccessBastionSsh
        /// </summary>
        [DataMember(Name="secure-access-bastion-ssh", EmitDefaultValue=false)]
        public string SecureAccessBastionSsh { get; set; }

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
        /// Gets or Sets SecureAccessSshCredsUser
        /// </summary>
        [DataMember(Name="secure-access-ssh-creds-user", EmitDefaultValue=false)]
        public string SecureAccessSshCredsUser { get; set; }

        /// <summary>
        /// A key to sign the certificate with
        /// </summary>
        /// <value>A key to sign the certificate with</value>
        [DataMember(Name="signer-key-name", EmitDefaultValue=false)]
        public string SignerKeyName { get; set; }

        /// <summary>
        /// Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)
        /// </summary>
        /// <value>Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;)</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// The requested Time To Live for the certificate, use second units
        /// </summary>
        /// <value>The requested Time To Live for the certificate, use second units</value>
        [DataMember(Name="ttl", EmitDefaultValue=false)]
        public long Ttl { get; set; }

        /// <summary>
        /// The universal identity token, Required only for universal_identity authentication
        /// </summary>
        /// <value>The universal identity token, Required only for universal_identity authentication</value>
        [DataMember(Name="uid-token", EmitDefaultValue=false)]
        public string UidToken { get; set; }

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
            sb.Append("class CreateSSHCertIssuer {\n");
            sb.Append("  AllowedUsers: ").Append(AllowedUsers).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Principals: ").Append(Principals).Append("\n");
            sb.Append("  SecureAccessBastionApi: ").Append(SecureAccessBastionApi).Append("\n");
            sb.Append("  SecureAccessBastionSsh: ").Append(SecureAccessBastionSsh).Append("\n");
            sb.Append("  SecureAccessEnable: ").Append(SecureAccessEnable).Append("\n");
            sb.Append("  SecureAccessHost: ").Append(SecureAccessHost).Append("\n");
            sb.Append("  SecureAccessSshCredsUser: ").Append(SecureAccessSshCredsUser).Append("\n");
            sb.Append("  SignerKeyName: ").Append(SignerKeyName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
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
            return this.Equals(input as CreateSSHCertIssuer);
        }

        /// <summary>
        /// Returns true if CreateSSHCertIssuer instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSSHCertIssuer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSSHCertIssuer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedUsers == input.AllowedUsers ||
                    (this.AllowedUsers != null &&
                    this.AllowedUsers.Equals(input.AllowedUsers))
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    input.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                    this.Principals == input.Principals ||
                    (this.Principals != null &&
                    this.Principals.Equals(input.Principals))
                ) && 
                (
                    this.SecureAccessBastionApi == input.SecureAccessBastionApi ||
                    (this.SecureAccessBastionApi != null &&
                    this.SecureAccessBastionApi.Equals(input.SecureAccessBastionApi))
                ) && 
                (
                    this.SecureAccessBastionSsh == input.SecureAccessBastionSsh ||
                    (this.SecureAccessBastionSsh != null &&
                    this.SecureAccessBastionSsh.Equals(input.SecureAccessBastionSsh))
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
                    this.SecureAccessSshCredsUser == input.SecureAccessSshCredsUser ||
                    (this.SecureAccessSshCredsUser != null &&
                    this.SecureAccessSshCredsUser.Equals(input.SecureAccessSshCredsUser))
                ) && 
                (
                    this.SignerKeyName == input.SignerKeyName ||
                    (this.SignerKeyName != null &&
                    this.SignerKeyName.Equals(input.SignerKeyName))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) && 
                (
                    this.UidToken == input.UidToken ||
                    (this.UidToken != null &&
                    this.UidToken.Equals(input.UidToken))
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
                if (this.AllowedUsers != null)
                    hashCode = hashCode * 59 + this.AllowedUsers.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Principals != null)
                    hashCode = hashCode * 59 + this.Principals.GetHashCode();
                if (this.SecureAccessBastionApi != null)
                    hashCode = hashCode * 59 + this.SecureAccessBastionApi.GetHashCode();
                if (this.SecureAccessBastionSsh != null)
                    hashCode = hashCode * 59 + this.SecureAccessBastionSsh.GetHashCode();
                if (this.SecureAccessEnable != null)
                    hashCode = hashCode * 59 + this.SecureAccessEnable.GetHashCode();
                if (this.SecureAccessHost != null)
                    hashCode = hashCode * 59 + this.SecureAccessHost.GetHashCode();
                if (this.SecureAccessSshCredsUser != null)
                    hashCode = hashCode * 59 + this.SecureAccessSshCredsUser.GetHashCode();
                if (this.SignerKeyName != null)
                    hashCode = hashCode * 59 + this.SignerKeyName.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.UidToken != null)
                    hashCode = hashCode * 59 + this.UidToken.GetHashCode();
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
