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
    /// Target
    /// </summary>
    [DataContract]
    public partial class Target :  IEquatable<Target>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Target" /> class.
        /// </summary>
        /// <param name="clientPermissions">clientPermissions.</param>
        /// <param name="comment">comment.</param>
        /// <param name="lastVersion">lastVersion.</param>
        /// <param name="protectionKeyName">protectionKeyName.</param>
        /// <param name="targetId">targetId.</param>
        /// <param name="targetItemsAssoc">targetItemsAssoc.</param>
        /// <param name="targetName">targetName.</param>
        /// <param name="targetType">targetType.</param>
        /// <param name="targetVersions">targetVersions.</param>
        /// <param name="withCustomerFragment">withCustomerFragment.</param>
        public Target(List<string> clientPermissions = default(List<string>), string comment = default(string), int lastVersion = default(int), string protectionKeyName = default(string), long targetId = default(long), List<TargetItemAssociation> targetItemsAssoc = default(List<TargetItemAssociation>), string targetName = default(string), string targetType = default(string), List<ItemVersion> targetVersions = default(List<ItemVersion>), bool withCustomerFragment = default(bool))
        {
            this.ClientPermissions = clientPermissions;
            this.Comment = comment;
            this.LastVersion = lastVersion;
            this.ProtectionKeyName = protectionKeyName;
            this.TargetId = targetId;
            this.TargetItemsAssoc = targetItemsAssoc;
            this.TargetName = targetName;
            this.TargetType = targetType;
            this.TargetVersions = targetVersions;
            this.WithCustomerFragment = withCustomerFragment;
        }
        
        /// <summary>
        /// Gets or Sets ClientPermissions
        /// </summary>
        [DataMember(Name="client_permissions", EmitDefaultValue=false)]
        public List<string> ClientPermissions { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets LastVersion
        /// </summary>
        [DataMember(Name="last_version", EmitDefaultValue=false)]
        public int LastVersion { get; set; }

        /// <summary>
        /// Gets or Sets ProtectionKeyName
        /// </summary>
        [DataMember(Name="protection_key_name", EmitDefaultValue=false)]
        public string ProtectionKeyName { get; set; }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name="target_id", EmitDefaultValue=false)]
        public long TargetId { get; set; }

        /// <summary>
        /// Gets or Sets TargetItemsAssoc
        /// </summary>
        [DataMember(Name="target_items_assoc", EmitDefaultValue=false)]
        public List<TargetItemAssociation> TargetItemsAssoc { get; set; }

        /// <summary>
        /// Gets or Sets TargetName
        /// </summary>
        [DataMember(Name="target_name", EmitDefaultValue=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// Gets or Sets TargetType
        /// </summary>
        [DataMember(Name="target_type", EmitDefaultValue=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Gets or Sets TargetVersions
        /// </summary>
        [DataMember(Name="target_versions", EmitDefaultValue=false)]
        public List<ItemVersion> TargetVersions { get; set; }

        /// <summary>
        /// Gets or Sets WithCustomerFragment
        /// </summary>
        [DataMember(Name="with_customer_fragment", EmitDefaultValue=false)]
        public bool WithCustomerFragment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Target {\n");
            sb.Append("  ClientPermissions: ").Append(ClientPermissions).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  LastVersion: ").Append(LastVersion).Append("\n");
            sb.Append("  ProtectionKeyName: ").Append(ProtectionKeyName).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetItemsAssoc: ").Append(TargetItemsAssoc).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  TargetVersions: ").Append(TargetVersions).Append("\n");
            sb.Append("  WithCustomerFragment: ").Append(WithCustomerFragment).Append("\n");
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
            return this.Equals(input as Target);
        }

        /// <summary>
        /// Returns true if Target instances are equal
        /// </summary>
        /// <param name="input">Instance of Target to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Target input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientPermissions == input.ClientPermissions ||
                    this.ClientPermissions != null &&
                    input.ClientPermissions != null &&
                    this.ClientPermissions.SequenceEqual(input.ClientPermissions)
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.LastVersion == input.LastVersion ||
                    this.LastVersion.Equals(input.LastVersion)
                ) && 
                (
                    this.ProtectionKeyName == input.ProtectionKeyName ||
                    (this.ProtectionKeyName != null &&
                    this.ProtectionKeyName.Equals(input.ProtectionKeyName))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    this.TargetId.Equals(input.TargetId)
                ) && 
                (
                    this.TargetItemsAssoc == input.TargetItemsAssoc ||
                    this.TargetItemsAssoc != null &&
                    input.TargetItemsAssoc != null &&
                    this.TargetItemsAssoc.SequenceEqual(input.TargetItemsAssoc)
                ) && 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TargetVersions == input.TargetVersions ||
                    this.TargetVersions != null &&
                    input.TargetVersions != null &&
                    this.TargetVersions.SequenceEqual(input.TargetVersions)
                ) && 
                (
                    this.WithCustomerFragment == input.WithCustomerFragment ||
                    this.WithCustomerFragment.Equals(input.WithCustomerFragment)
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
                if (this.ClientPermissions != null)
                    hashCode = hashCode * 59 + this.ClientPermissions.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                hashCode = hashCode * 59 + this.LastVersion.GetHashCode();
                if (this.ProtectionKeyName != null)
                    hashCode = hashCode * 59 + this.ProtectionKeyName.GetHashCode();
                hashCode = hashCode * 59 + this.TargetId.GetHashCode();
                if (this.TargetItemsAssoc != null)
                    hashCode = hashCode * 59 + this.TargetItemsAssoc.GetHashCode();
                if (this.TargetName != null)
                    hashCode = hashCode * 59 + this.TargetName.GetHashCode();
                if (this.TargetType != null)
                    hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.TargetVersions != null)
                    hashCode = hashCode * 59 + this.TargetVersions.GetHashCode();
                hashCode = hashCode * 59 + this.WithCustomerFragment.GetHashCode();
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
