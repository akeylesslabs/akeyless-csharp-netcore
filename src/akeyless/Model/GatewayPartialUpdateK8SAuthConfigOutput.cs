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
    /// GatewayPartialUpdateK8SAuthConfigOutput
    /// </summary>
    [DataContract(Name = "gatewayPartialUpdateK8SAuthConfigOutput")]
    public partial class GatewayPartialUpdateK8SAuthConfigOutput : IEquatable<GatewayPartialUpdateK8SAuthConfigOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayPartialUpdateK8SAuthConfigOutput" /> class.
        /// </summary>
        /// <param name="clusterId">clusterId.</param>
        /// <param name="partsChange">partsChange.</param>
        /// <param name="totalHash">totalHash.</param>
        public GatewayPartialUpdateK8SAuthConfigOutput(string clusterId = default(string), ConfigChange partsChange = default(ConfigChange), string totalHash = default(string))
        {
            this.ClusterId = clusterId;
            this.PartsChange = partsChange;
            this.TotalHash = totalHash;
        }

        /// <summary>
        /// Gets or Sets ClusterId
        /// </summary>
        [DataMember(Name = "cluster_id", EmitDefaultValue = false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Gets or Sets PartsChange
        /// </summary>
        [DataMember(Name = "parts_change", EmitDefaultValue = false)]
        public ConfigChange PartsChange { get; set; }

        /// <summary>
        /// Gets or Sets TotalHash
        /// </summary>
        [DataMember(Name = "total_hash", EmitDefaultValue = false)]
        public string TotalHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayPartialUpdateK8SAuthConfigOutput {\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  PartsChange: ").Append(PartsChange).Append("\n");
            sb.Append("  TotalHash: ").Append(TotalHash).Append("\n");
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
            return this.Equals(input as GatewayPartialUpdateK8SAuthConfigOutput);
        }

        /// <summary>
        /// Returns true if GatewayPartialUpdateK8SAuthConfigOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayPartialUpdateK8SAuthConfigOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayPartialUpdateK8SAuthConfigOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.PartsChange == input.PartsChange ||
                    (this.PartsChange != null &&
                    this.PartsChange.Equals(input.PartsChange))
                ) && 
                (
                    this.TotalHash == input.TotalHash ||
                    (this.TotalHash != null &&
                    this.TotalHash.Equals(input.TotalHash))
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
                if (this.ClusterId != null)
                {
                    hashCode = (hashCode * 59) + this.ClusterId.GetHashCode();
                }
                if (this.PartsChange != null)
                {
                    hashCode = (hashCode * 59) + this.PartsChange.GetHashCode();
                }
                if (this.TotalHash != null)
                {
                    hashCode = (hashCode * 59) + this.TotalHash.GetHashCode();
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
