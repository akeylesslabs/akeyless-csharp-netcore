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
    /// CreatePasskeyOutput
    /// </summary>
    [DataContract(Name = "CreatePasskeyOutput")]
    public partial class CreatePasskeyOutput : IEquatable<CreatePasskeyOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePasskeyOutput" /> class.
        /// </summary>
        /// <param name="classicKeyId">classicKeyId.</param>
        /// <param name="classicKeyName">classicKeyName.</param>
        /// <param name="classicKeyType">classicKeyType.</param>
        /// <param name="publicKey">publicKey.</param>
        public CreatePasskeyOutput(string classicKeyId = default(string), string classicKeyName = default(string), string classicKeyType = default(string), string publicKey = default(string))
        {
            this.ClassicKeyId = classicKeyId;
            this.ClassicKeyName = classicKeyName;
            this.ClassicKeyType = classicKeyType;
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// Gets or Sets ClassicKeyId
        /// </summary>
        [DataMember(Name = "classic_key_id", EmitDefaultValue = false)]
        public string ClassicKeyId { get; set; }

        /// <summary>
        /// Gets or Sets ClassicKeyName
        /// </summary>
        [DataMember(Name = "classic_key_name", EmitDefaultValue = false)]
        public string ClassicKeyName { get; set; }

        /// <summary>
        /// Gets or Sets ClassicKeyType
        /// </summary>
        [DataMember(Name = "classic_key_type", EmitDefaultValue = false)]
        public string ClassicKeyType { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePasskeyOutput {\n");
            sb.Append("  ClassicKeyId: ").Append(ClassicKeyId).Append("\n");
            sb.Append("  ClassicKeyName: ").Append(ClassicKeyName).Append("\n");
            sb.Append("  ClassicKeyType: ").Append(ClassicKeyType).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as CreatePasskeyOutput);
        }

        /// <summary>
        /// Returns true if CreatePasskeyOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreatePasskeyOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreatePasskeyOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClassicKeyId == input.ClassicKeyId ||
                    (this.ClassicKeyId != null &&
                    this.ClassicKeyId.Equals(input.ClassicKeyId))
                ) && 
                (
                    this.ClassicKeyName == input.ClassicKeyName ||
                    (this.ClassicKeyName != null &&
                    this.ClassicKeyName.Equals(input.ClassicKeyName))
                ) && 
                (
                    this.ClassicKeyType == input.ClassicKeyType ||
                    (this.ClassicKeyType != null &&
                    this.ClassicKeyType.Equals(input.ClassicKeyType))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.ClassicKeyId != null)
                {
                    hashCode = (hashCode * 59) + this.ClassicKeyId.GetHashCode();
                }
                if (this.ClassicKeyName != null)
                {
                    hashCode = (hashCode * 59) + this.ClassicKeyName.GetHashCode();
                }
                if (this.ClassicKeyType != null)
                {
                    hashCode = (hashCode * 59) + this.ClassicKeyType.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
