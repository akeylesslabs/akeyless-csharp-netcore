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
    /// CreateDFCKeyOutput
    /// </summary>
    [DataContract]
    public partial class CreateDFCKeyOutput :  IEquatable<CreateDFCKeyOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDFCKeyOutput" /> class.
        /// </summary>
        /// <param name="fragmentResults">fragmentResults.</param>
        public CreateDFCKeyOutput(List<long> fragmentResults = default(List<long>))
        {
            this.FragmentResults = fragmentResults;
        }
        
        /// <summary>
        /// Gets or Sets FragmentResults
        /// </summary>
        [DataMember(Name="fragment_results", EmitDefaultValue=false)]
        public List<long> FragmentResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDFCKeyOutput {\n");
            sb.Append("  FragmentResults: ").Append(FragmentResults).Append("\n");
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
            return this.Equals(input as CreateDFCKeyOutput);
        }

        /// <summary>
        /// Returns true if CreateDFCKeyOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDFCKeyOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDFCKeyOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FragmentResults == input.FragmentResults ||
                    this.FragmentResults != null &&
                    input.FragmentResults != null &&
                    this.FragmentResults.SequenceEqual(input.FragmentResults)
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
                if (this.FragmentResults != null)
                    hashCode = hashCode * 59 + this.FragmentResults.GetHashCode();
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