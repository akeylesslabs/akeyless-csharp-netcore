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
    /// ItemSraStatus
    /// </summary>
    [DataContract(Name = "ItemSraStatus")]
    public partial class ItemSraStatus : IEquatable<ItemSraStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSraStatus" /> class.
        /// </summary>
        /// <param name="countByHostInfo">countByHostInfo.</param>
        /// <param name="countInfo">countInfo.</param>
        /// <param name="hostsInUse">hostsInUse.</param>
        /// <param name="isInUse">isInUse.</param>
        /// <param name="lastUsedItem">lastUsedItem.</param>
        public ItemSraStatus(Dictionary<string, long> countByHostInfo = default(Dictionary<string, long>), Dictionary<string, Dictionary<string, long>> countInfo = default(Dictionary<string, Dictionary<string, long>>), List<string> hostsInUse = default(List<string>), bool isInUse = default(bool), DateTime lastUsedItem = default(DateTime))
        {
            this.CountByHostInfo = countByHostInfo;
            this.CountInfo = countInfo;
            this.HostsInUse = hostsInUse;
            this.IsInUse = isInUse;
            this.LastUsedItem = lastUsedItem;
        }

        /// <summary>
        /// Gets or Sets CountByHostInfo
        /// </summary>
        [DataMember(Name = "count_by_host_info", EmitDefaultValue = false)]
        public Dictionary<string, long> CountByHostInfo { get; set; }

        /// <summary>
        /// Gets or Sets CountInfo
        /// </summary>
        [DataMember(Name = "count_info", EmitDefaultValue = false)]
        public Dictionary<string, Dictionary<string, long>> CountInfo { get; set; }

        /// <summary>
        /// Gets or Sets HostsInUse
        /// </summary>
        [DataMember(Name = "hosts_in_use", EmitDefaultValue = false)]
        public List<string> HostsInUse { get; set; }

        /// <summary>
        /// Gets or Sets IsInUse
        /// </summary>
        [DataMember(Name = "is_in_use", EmitDefaultValue = true)]
        public bool IsInUse { get; set; }

        /// <summary>
        /// Gets or Sets LastUsedItem
        /// </summary>
        [DataMember(Name = "last_used_item", EmitDefaultValue = false)]
        public DateTime LastUsedItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemSraStatus {\n");
            sb.Append("  CountByHostInfo: ").Append(CountByHostInfo).Append("\n");
            sb.Append("  CountInfo: ").Append(CountInfo).Append("\n");
            sb.Append("  HostsInUse: ").Append(HostsInUse).Append("\n");
            sb.Append("  IsInUse: ").Append(IsInUse).Append("\n");
            sb.Append("  LastUsedItem: ").Append(LastUsedItem).Append("\n");
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
            return this.Equals(input as ItemSraStatus);
        }

        /// <summary>
        /// Returns true if ItemSraStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemSraStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemSraStatus input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CountByHostInfo == input.CountByHostInfo ||
                    this.CountByHostInfo != null &&
                    input.CountByHostInfo != null &&
                    this.CountByHostInfo.SequenceEqual(input.CountByHostInfo)
                ) && 
                (
                    this.CountInfo == input.CountInfo ||
                    this.CountInfo != null &&
                    input.CountInfo != null &&
                    this.CountInfo.SequenceEqual(input.CountInfo)
                ) && 
                (
                    this.HostsInUse == input.HostsInUse ||
                    this.HostsInUse != null &&
                    input.HostsInUse != null &&
                    this.HostsInUse.SequenceEqual(input.HostsInUse)
                ) && 
                (
                    this.IsInUse == input.IsInUse ||
                    this.IsInUse.Equals(input.IsInUse)
                ) && 
                (
                    this.LastUsedItem == input.LastUsedItem ||
                    (this.LastUsedItem != null &&
                    this.LastUsedItem.Equals(input.LastUsedItem))
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
                if (this.CountByHostInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CountByHostInfo.GetHashCode();
                }
                if (this.CountInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CountInfo.GetHashCode();
                }
                if (this.HostsInUse != null)
                {
                    hashCode = (hashCode * 59) + this.HostsInUse.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsInUse.GetHashCode();
                if (this.LastUsedItem != null)
                {
                    hashCode = (hashCode * 59) + this.LastUsedItem.GetHashCode();
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
