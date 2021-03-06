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
    /// KmipClientSetRule
    /// </summary>
    [DataContract]
    public partial class KmipClientSetRule :  IEquatable<KmipClientSetRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KmipClientSetRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KmipClientSetRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KmipClientSetRule" /> class.
        /// </summary>
        /// <param name="capability">Access capabilities (required).</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="name">name.</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="path">Access path (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public KmipClientSetRule(List<string> capability = default(List<string>), string clientId = default(string), string name = default(string), string password = default(string), string path = default(string), string token = default(string), string uidToken = default(string), string username = default(string))
        {
            // to ensure "capability" is required (not null)
            this.Capability = capability ?? throw new ArgumentNullException("capability is a required property for KmipClientSetRule and cannot be null");
            // to ensure "path" is required (not null)
            this.Path = path ?? throw new ArgumentNullException("path is a required property for KmipClientSetRule and cannot be null");
            this.ClientId = clientId;
            this.Name = name;
            this.Password = password;
            this.Token = token;
            this.UidToken = uidToken;
            this.Username = username;
        }
        
        /// <summary>
        /// Access capabilities
        /// </summary>
        /// <value>Access capabilities</value>
        [DataMember(Name="capability", EmitDefaultValue=false)]
        public List<string> Capability { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="client-id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Access path
        /// </summary>
        /// <value>Access path</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

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
            sb.Append("class KmipClientSetRule {\n");
            sb.Append("  Capability: ").Append(Capability).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as KmipClientSetRule);
        }

        /// <summary>
        /// Returns true if KmipClientSetRule instances are equal
        /// </summary>
        /// <param name="input">Instance of KmipClientSetRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KmipClientSetRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Capability == input.Capability ||
                    this.Capability != null &&
                    input.Capability != null &&
                    this.Capability.SequenceEqual(input.Capability)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
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
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.Capability != null)
                    hashCode = hashCode * 59 + this.Capability.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
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
