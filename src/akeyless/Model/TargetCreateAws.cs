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
    /// TargetCreateAws
    /// </summary>
    [DataContract(Name = "targetCreateAws")]
    public partial class TargetCreateAws : IEquatable<TargetCreateAws>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateAws" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetCreateAws() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetCreateAws" /> class.
        /// </summary>
        /// <param name="accessKey">AWS secret access key (required).</param>
        /// <param name="accessKeyId">AWS access key ID (required).</param>
        /// <param name="description">Description of the object.</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="key">The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used).</param>
        /// <param name="maxVersions">Set the maximum number of versions, limited by the account settings defaults..</param>
        /// <param name="name">Target name (required).</param>
        /// <param name="region">AWS region (default to &quot;us-east-2&quot;).</param>
        /// <param name="sessionToken">Required only for temporary security credentials retrieved using STS.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="useGwCloudIdentity">Use the GW&#39;s Cloud IAM.</param>
        public TargetCreateAws(string accessKey = default(string), string accessKeyId = default(string), string description = default(string), bool json = false, string key = default(string), string maxVersions = default(string), string name = default(string), string region = "us-east-2", string sessionToken = default(string), string token = default(string), string uidToken = default(string), bool useGwCloudIdentity = default(bool))
        {
            // to ensure "accessKey" is required (not null)
            if (accessKey == null)
            {
                throw new ArgumentNullException("accessKey is a required property for TargetCreateAws and cannot be null");
            }
            this.AccessKey = accessKey;
            // to ensure "accessKeyId" is required (not null)
            if (accessKeyId == null)
            {
                throw new ArgumentNullException("accessKeyId is a required property for TargetCreateAws and cannot be null");
            }
            this.AccessKeyId = accessKeyId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TargetCreateAws and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.Json = json;
            this.Key = key;
            this.MaxVersions = maxVersions;
            // use default value if no "region" provided
            this.Region = region ?? "us-east-2";
            this.SessionToken = sessionToken;
            this.Token = token;
            this.UidToken = uidToken;
            this.UseGwCloudIdentity = useGwCloudIdentity;
        }

        /// <summary>
        /// AWS secret access key
        /// </summary>
        /// <value>AWS secret access key</value>
        [DataMember(Name = "access-key", IsRequired = true, EmitDefaultValue = true)]
        public string AccessKey { get; set; }

        /// <summary>
        /// AWS access key ID
        /// </summary>
        /// <value>AWS access key ID</value>
        [DataMember(Name = "access-key-id", IsRequired = true, EmitDefaultValue = true)]
        public string AccessKeyId { get; set; }

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
        /// The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)
        /// </summary>
        /// <value>The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used)</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Set the maximum number of versions, limited by the account settings defaults.
        /// </summary>
        /// <value>Set the maximum number of versions, limited by the account settings defaults.</value>
        [DataMember(Name = "max-versions", EmitDefaultValue = false)]
        public string MaxVersions { get; set; }

        /// <summary>
        /// Target name
        /// </summary>
        /// <value>Target name</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// AWS region
        /// </summary>
        /// <value>AWS region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Required only for temporary security credentials retrieved using STS
        /// </summary>
        /// <value>Required only for temporary security credentials retrieved using STS</value>
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
        /// Use the GW&#39;s Cloud IAM
        /// </summary>
        /// <value>Use the GW&#39;s Cloud IAM</value>
        [DataMember(Name = "use-gw-cloud-identity", EmitDefaultValue = true)]
        public bool UseGwCloudIdentity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TargetCreateAws {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  AccessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxVersions: ").Append(MaxVersions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  UseGwCloudIdentity: ").Append(UseGwCloudIdentity).Append("\n");
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
            return this.Equals(input as TargetCreateAws);
        }

        /// <summary>
        /// Returns true if TargetCreateAws instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetCreateAws to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetCreateAws input)
        {
            if (input == null)
            {
                return false;
            }
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.MaxVersions == input.MaxVersions ||
                    (this.MaxVersions != null &&
                    this.MaxVersions.Equals(input.MaxVersions))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                {
                    hashCode = (hashCode * 59) + this.AccessKey.GetHashCode();
                }
                if (this.AccessKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.AccessKeyId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                if (this.MaxVersions != null)
                {
                    hashCode = (hashCode * 59) + this.MaxVersions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.SessionToken != null)
                {
                    hashCode = (hashCode * 59) + this.SessionToken.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseGwCloudIdentity.GetHashCode();
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