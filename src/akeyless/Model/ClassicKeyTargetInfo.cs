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
    /// ClassicKeyTargetInfo
    /// </summary>
    [DataContract]
    public partial class ClassicKeyTargetInfo :  IEquatable<ClassicKeyTargetInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClassicKeyTargetInfo" /> class.
        /// </summary>
        /// <param name="externalKmsId">externalKmsId.</param>
        /// <param name="keyPurpose">keyPurpose.</param>
        /// <param name="keyStatus">keyStatus.</param>
        /// <param name="targetAssocId">targetAssocId.</param>
        /// <param name="targetType">targetType.</param>
        public ClassicKeyTargetInfo(ExternalKMSKeyId externalKmsId = default(ExternalKMSKeyId), List<string> keyPurpose = default(List<string>), ClassicKeyStatusInfo keyStatus = default(ClassicKeyStatusInfo), string targetAssocId = default(string), string targetType = default(string))
        {
            this.ExternalKmsId = externalKmsId;
            this.KeyPurpose = keyPurpose;
            this.KeyStatus = keyStatus;
            this.TargetAssocId = targetAssocId;
            this.TargetType = targetType;
        }
        
        /// <summary>
        /// Gets or Sets ExternalKmsId
        /// </summary>
        [DataMember(Name="external_kms_id", EmitDefaultValue=false)]
        public ExternalKMSKeyId ExternalKmsId { get; set; }

        /// <summary>
        /// Gets or Sets KeyPurpose
        /// </summary>
        [DataMember(Name="key_purpose", EmitDefaultValue=false)]
        public List<string> KeyPurpose { get; set; }

        /// <summary>
        /// Gets or Sets KeyStatus
        /// </summary>
        [DataMember(Name="key_status", EmitDefaultValue=false)]
        public ClassicKeyStatusInfo KeyStatus { get; set; }

        /// <summary>
        /// Gets or Sets TargetAssocId
        /// </summary>
        [DataMember(Name="target_assoc_id", EmitDefaultValue=false)]
        public string TargetAssocId { get; set; }

        /// <summary>
        /// Gets or Sets TargetType
        /// </summary>
        [DataMember(Name="target_type", EmitDefaultValue=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassicKeyTargetInfo {\n");
            sb.Append("  ExternalKmsId: ").Append(ExternalKmsId).Append("\n");
            sb.Append("  KeyPurpose: ").Append(KeyPurpose).Append("\n");
            sb.Append("  KeyStatus: ").Append(KeyStatus).Append("\n");
            sb.Append("  TargetAssocId: ").Append(TargetAssocId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
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
            return this.Equals(input as ClassicKeyTargetInfo);
        }

        /// <summary>
        /// Returns true if ClassicKeyTargetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ClassicKeyTargetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClassicKeyTargetInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalKmsId == input.ExternalKmsId ||
                    (this.ExternalKmsId != null &&
                    this.ExternalKmsId.Equals(input.ExternalKmsId))
                ) && 
                (
                    this.KeyPurpose == input.KeyPurpose ||
                    this.KeyPurpose != null &&
                    input.KeyPurpose != null &&
                    this.KeyPurpose.SequenceEqual(input.KeyPurpose)
                ) && 
                (
                    this.KeyStatus == input.KeyStatus ||
                    (this.KeyStatus != null &&
                    this.KeyStatus.Equals(input.KeyStatus))
                ) && 
                (
                    this.TargetAssocId == input.TargetAssocId ||
                    (this.TargetAssocId != null &&
                    this.TargetAssocId.Equals(input.TargetAssocId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
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
                if (this.ExternalKmsId != null)
                    hashCode = hashCode * 59 + this.ExternalKmsId.GetHashCode();
                if (this.KeyPurpose != null)
                    hashCode = hashCode * 59 + this.KeyPurpose.GetHashCode();
                if (this.KeyStatus != null)
                    hashCode = hashCode * 59 + this.KeyStatus.GetHashCode();
                if (this.TargetAssocId != null)
                    hashCode = hashCode * 59 + this.TargetAssocId.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
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