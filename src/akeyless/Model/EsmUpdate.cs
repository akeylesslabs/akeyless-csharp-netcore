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
    /// esmUpdate is a command that updates a secret in an External Secrets Manager
    /// </summary>
    [DataContract(Name = "esmUpdate")]
    public partial class EsmUpdate : IEquatable<EsmUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EsmUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EsmUpdate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EsmUpdate" /> class.
        /// </summary>
        /// <param name="binaryValue">Use this option if the external secret value is a base64 encoded binary.</param>
        /// <param name="description">Description of the external secret.</param>
        /// <param name="esmName">Name of the External Secrets Manager item (required).</param>
        /// <param name="json">Set output format to JSON (default to false).</param>
        /// <param name="secretId">The external secret id (or name, for AWS, Azure or K8s targets) to update (required).</param>
        /// <param name="tags">Tags for the external secret.</param>
        /// <param name="token">Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;).</param>
        /// <param name="uidToken">The universal identity token, Required only for universal_identity authentication.</param>
        /// <param name="value">Value of the external secret item, either text or base64 encoded binary (required).</param>
        public EsmUpdate(bool binaryValue = default(bool), string description = default(string), string esmName = default(string), bool json = false, string secretId = default(string), Dictionary<string, string> tags = default(Dictionary<string, string>), string token = default(string), string uidToken = default(string), string value = default(string))
        {
            // to ensure "esmName" is required (not null)
            if (esmName == null)
            {
                throw new ArgumentNullException("esmName is a required property for EsmUpdate and cannot be null");
            }
            this.EsmName = esmName;
            // to ensure "secretId" is required (not null)
            if (secretId == null)
            {
                throw new ArgumentNullException("secretId is a required property for EsmUpdate and cannot be null");
            }
            this.SecretId = secretId;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for EsmUpdate and cannot be null");
            }
            this.Value = value;
            this.BinaryValue = binaryValue;
            this.Description = description;
            this.Json = json;
            this.Tags = tags;
            this.Token = token;
            this.UidToken = uidToken;
        }

        /// <summary>
        /// Use this option if the external secret value is a base64 encoded binary
        /// </summary>
        /// <value>Use this option if the external secret value is a base64 encoded binary</value>
        [DataMember(Name = "binary-value", EmitDefaultValue = true)]
        public bool BinaryValue { get; set; }

        /// <summary>
        /// Description of the external secret
        /// </summary>
        /// <value>Description of the external secret</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the External Secrets Manager item
        /// </summary>
        /// <value>Name of the External Secrets Manager item</value>
        [DataMember(Name = "esm-name", IsRequired = true, EmitDefaultValue = true)]
        public string EsmName { get; set; }

        /// <summary>
        /// Set output format to JSON
        /// </summary>
        /// <value>Set output format to JSON</value>
        [DataMember(Name = "json", EmitDefaultValue = true)]
        public bool Json { get; set; }

        /// <summary>
        /// The external secret id (or name, for AWS, Azure or K8s targets) to update
        /// </summary>
        /// <value>The external secret id (or name, for AWS, Azure or K8s targets) to update</value>
        [DataMember(Name = "secret-id", IsRequired = true, EmitDefaultValue = true)]
        public string SecretId { get; set; }

        /// <summary>
        /// Tags for the external secret
        /// </summary>
        /// <value>Tags for the external secret</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string> Tags { get; set; }

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
        /// Value of the external secret item, either text or base64 encoded binary
        /// </summary>
        /// <value>Value of the external secret item, either text or base64 encoded binary</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EsmUpdate {\n");
            sb.Append("  BinaryValue: ").Append(BinaryValue).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EsmName: ").Append(EsmName).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  SecretId: ").Append(SecretId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  UidToken: ").Append(UidToken).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as EsmUpdate);
        }

        /// <summary>
        /// Returns true if EsmUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of EsmUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EsmUpdate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BinaryValue == input.BinaryValue ||
                    this.BinaryValue.Equals(input.BinaryValue)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EsmName == input.EsmName ||
                    (this.EsmName != null &&
                    this.EsmName.Equals(input.EsmName))
                ) && 
                (
                    this.Json == input.Json ||
                    this.Json.Equals(input.Json)
                ) && 
                (
                    this.SecretId == input.SecretId ||
                    (this.SecretId != null &&
                    this.SecretId.Equals(input.SecretId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = (hashCode * 59) + this.BinaryValue.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EsmName != null)
                {
                    hashCode = (hashCode * 59) + this.EsmName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Json.GetHashCode();
                if (this.SecretId != null)
                {
                    hashCode = (hashCode * 59) + this.SecretId.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.UidToken != null)
                {
                    hashCode = (hashCode * 59) + this.UidToken.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
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
