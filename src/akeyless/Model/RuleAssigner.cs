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
    /// RuleAssigner
    /// </summary>
    [DataContract(Name = "RuleAssigner")]
    public partial class RuleAssigner : IEquatable<RuleAssigner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleAssigner" /> class.
        /// </summary>
        /// <param name="accessId">accessId.</param>
        /// <param name="uniqueId">uniqueId.</param>
        public RuleAssigner(string accessId = default(string), string uniqueId = default(string))
        {
            this.AccessId = accessId;
            this.UniqueId = uniqueId;
        }

        /// <summary>
        /// Gets or Sets AccessId
        /// </summary>
        [DataMember(Name = "access_id", EmitDefaultValue = false)]
        public string AccessId { get; set; }

        /// <summary>
        /// Gets or Sets UniqueId
        /// </summary>
        [DataMember(Name = "unique_id", EmitDefaultValue = false)]
        public string UniqueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleAssigner {\n");
            sb.Append("  AccessId: ").Append(AccessId).Append("\n");
            sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
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
            return this.Equals(input as RuleAssigner);
        }

        /// <summary>
        /// Returns true if RuleAssigner instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleAssigner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleAssigner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessId == input.AccessId ||
                    (this.AccessId != null &&
                    this.AccessId.Equals(input.AccessId))
                ) && 
                (
                    this.UniqueId == input.UniqueId ||
                    (this.UniqueId != null &&
                    this.UniqueId.Equals(input.UniqueId))
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
                if (this.AccessId != null)
                {
                    hashCode = (hashCode * 59) + this.AccessId.GetHashCode();
                }
                if (this.UniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueId.GetHashCode();
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