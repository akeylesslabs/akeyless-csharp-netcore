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
    /// DynamicSecretDeleteOutput
    /// </summary>
    [DataContract(Name = "dynamicSecretDeleteOutput")]
    public partial class DynamicSecretDeleteOutput : IEquatable<DynamicSecretDeleteOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicSecretDeleteOutput" /> class.
        /// </summary>
        /// <param name="dynamicSecretName">dynamicSecretName.</param>
        public DynamicSecretDeleteOutput(string dynamicSecretName = default(string))
        {
            this.DynamicSecretName = dynamicSecretName;
        }

        /// <summary>
        /// Gets or Sets DynamicSecretName
        /// </summary>
        [DataMember(Name = "dynamic_secret_name", EmitDefaultValue = false)]
        public string DynamicSecretName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DynamicSecretDeleteOutput {\n");
            sb.Append("  DynamicSecretName: ").Append(DynamicSecretName).Append("\n");
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
            return this.Equals(input as DynamicSecretDeleteOutput);
        }

        /// <summary>
        /// Returns true if DynamicSecretDeleteOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of DynamicSecretDeleteOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DynamicSecretDeleteOutput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DynamicSecretName == input.DynamicSecretName ||
                    (this.DynamicSecretName != null &&
                    this.DynamicSecretName.Equals(input.DynamicSecretName))
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
                if (this.DynamicSecretName != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicSecretName.GetHashCode();
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