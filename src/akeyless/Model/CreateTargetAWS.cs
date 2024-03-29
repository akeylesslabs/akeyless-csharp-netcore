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
    /// CreateTargetAWS
    /// </summary>
    [DataContract(Name = "createTargetAWS")]
    public partial class CreateTargetAWS : IEquatable<CreateTargetAWS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTargetAWS" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTargetAWS() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTargetAWS" /> class.
        /// </summary>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="accessKeyId">accessKeyId.</param>
        /// <param name="comment">Comment about the target.</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="password">Required only when the authentication process requires a username and password.</param>
        /// <param name="region">region.</param>
        /// <param name="sessionToken">sessionToken.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="useGwCloudIdentity">useGwCloudIdentity.</param>
        /// <param name="username">Required only when the authentication process requires a username and password.</param>
        public CreateTargetAWS(string accessKey = default(string), string accessKeyId = default(string), string comment = default(string), string key = default(string), string name = default(string), string password = default(string), string region = default(string), string sessionToken = default(string), string token = default(string), string uidToken = default(string), bool useGwCloudIdentity = default(bool), string username = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CreateTargetAWS and cannot be null");
            }
            this.Name = name;
            this.AccessKey = accessKey;
            this.AccessKeyId = accessKeyId;
            this.Comment = comment;
            this.Key = key;
            this.Password = password;
            this.Region = region;
            this.SessionToken = sessionToken;
            this.Token = token;
            this.UidToken = uidToken;
            this.UseGwCloudIdentity = useGwCloudIdentity;
            this.Username = username;
        }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "access-key", EmitDefaultValue = false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets AccessKeyId
        /// </summary>
        [DataMember(Name = "access-key-id", EmitDefaultValue = false)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Comment about the target
        /// </summary>
        /// <value>Comment about the target</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets SessionToken
        /// </summary>
        [DataMember(Name = "session-token", EmitDefaultValue = false)]
        public string SessionToken { get; set; }

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
        /// Gets or Sets UseGwCloudIdentity
        /// </summary>
        [DataMember(Name = "use-gw-cloud-identity", EmitDefaultValue = true)]
        public bool UseGwCloudIdentity { get; set; }

        /// <summary>
        /// Required only when the authentication process requires a username and password
        /// </summary>
        /// <value>Required only when the authentication process requires a username and password</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTargetAWS {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  AccessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UseGwCloudIdentity: ").Append(UseGwCloudIdentity).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTargetAWS);
        }

        /// <summary>
        /// Returns true if CreateTargetAWS instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTargetAWS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTargetAWS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.AccessKeyId == input.AccessKeyId ||
                    (this.AccessKeyId != null &&
                    this.AccessKeyId.Equals(input.AccessKeyId))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.SessionToken == input.SessionToken ||
                    (this.SessionToken != null &&
                    this.SessionToken.Equals(input.SessionToken))
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
                    this.UseGwCloudIdentity == input.UseGwCloudIdentity ||
                    this.UseGwCloudIdentity.Equals(input.UseGwCloudIdentity)
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
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.AccessKeyId != null)
                    hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SessionToken != null)
                    hashCode = hashCode * 59 + this.SessionToken.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.UidToken != null)
                    hashCode = hashCode * 59 + this.UidToken.GetHashCode();
                hashCode = hashCode * 59 + this.UseGwCloudIdentity.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
