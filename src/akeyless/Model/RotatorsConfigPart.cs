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
    /// RotatorsConfigPart
    /// </summary>
    [DataContract(Name = "RotatorsConfigPart")]
    public partial class RotatorsConfigPart : IEquatable<RotatorsConfigPart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RotatorsConfigPart" /> class.
        /// </summary>
        /// <param name="rotators">rotators.</param>
        public RotatorsConfigPart(List<Rotator> rotators = default(List<Rotator>))
        {
            this.Rotators = rotators;
        }

        /// <summary>
        /// Gets or Sets Rotators
        /// </summary>
        [DataMember(Name = "rotators", EmitDefaultValue = false)]
        public List<Rotator> Rotators { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RotatorsConfigPart {\n");
            sb.Append("  Rotators: ").Append(Rotators).Append("\n");
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
            return this.Equals(input as RotatorsConfigPart);
        }

        /// <summary>
        /// Returns true if RotatorsConfigPart instances are equal
        /// </summary>
        /// <param name="input">Instance of RotatorsConfigPart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RotatorsConfigPart input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Rotators == input.Rotators ||
                    this.Rotators != null &&
                    input.Rotators != null &&
                    this.Rotators.SequenceEqual(input.Rotators)
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
                if (this.Rotators != null)
                {
                    hashCode = (hashCode * 59) + this.Rotators.GetHashCode();
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
