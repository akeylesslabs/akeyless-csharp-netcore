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
    /// VerifyJWTWithClassicKey
    /// </summary>
    [DataContract]
    public partial class VerifyJWTWithClassicKey :  IEquatable<VerifyJWTWithClassicKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyJWTWithClassicKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyJWTWithClassicKey() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyJWTWithClassicKey" /> class.
        /// </summary>
        /// <param name="displayId">The name of the key to use in the verify JWT process (required).</param>
        /// <param name="jwt">JWT (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="requiredClaims">RequiredClaims (required).</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        /// <param name="version">classic key version (required).</param>
        public VerifyJWTWithClassicKey(string displayId = default(string), string jwt = default(string), string password = default(string), string requiredClaims = default(string), string token = default(string), string uidToken = default(string), string username = default(string), int version = default(int))
        {
            // to ensure "displayId" is required (not null)
            this.DisplayId = displayId ?? throw new ArgumentNullException("displayId is a required property for VerifyJWTWithClassicKey and cannot be null");
            // to ensure "jwt" is required (not null)
            this.Jwt = jwt ?? throw new ArgumentNullException("jwt is a required property for VerifyJWTWithClassicKey and cannot be null");
            // to ensure "requiredClaims" is required (not null)
            this.RequiredClaims = requiredClaims ?? throw new ArgumentNullException("requiredClaims is a required property for VerifyJWTWithClassicKey and cannot be null");
            this.Version = version;
            this.Password = password;
            this.Token = token;
            this.UidToken = uidToken;
            this.Username = username;
        }
        
        /// <summary>
        /// The name of the key to use in the verify JWT process
        /// </summary>
        /// <value>The name of the key to use in the verify JWT process</value>
        [DataMember(Name="display-id", EmitDefaultValue=false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// JWT
        /// </summary>
        /// <value>JWT</value>
        [DataMember(Name="jwt", EmitDefaultValue=false)]
        public string Jwt { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// RequiredClaims
        /// </summary>
        /// <value>RequiredClaims</value>
        [DataMember(Name="required-claims", EmitDefaultValue=false)]
        public string RequiredClaims { get; set; }

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
        /// classic key version
        /// </summary>
        /// <value>classic key version</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyJWTWithClassicKey {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  Jwt: ").Append(Jwt).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RequiredClaims: ").Append(RequiredClaims).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as VerifyJWTWithClassicKey);
        }

        /// <summary>
        /// Returns true if VerifyJWTWithClassicKey instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyJWTWithClassicKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyJWTWithClassicKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayId == input.DisplayId ||
                    (this.DisplayId != null &&
                    this.DisplayId.Equals(input.DisplayId))
                ) && 
                (
                    this.Jwt == input.Jwt ||
                    (this.Jwt != null &&
                    this.Jwt.Equals(input.Jwt))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.RequiredClaims == input.RequiredClaims ||
                    (this.RequiredClaims != null &&
                    this.RequiredClaims.Equals(input.RequiredClaims))
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
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
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
                if (this.DisplayId != null)
                    hashCode = hashCode * 59 + this.DisplayId.GetHashCode();
                if (this.Jwt != null)
                    hashCode = hashCode * 59 + this.Jwt.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.RequiredClaims != null)
                    hashCode = hashCode * 59 + this.RequiredClaims.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UidToken != null)
                    hashCode = hashCode * 59 + this.UidToken.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
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