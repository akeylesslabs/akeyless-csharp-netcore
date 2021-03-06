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
    /// ReverseRBACOutput
    /// </summary>
    [DataContract]
    public partial class ReverseRBACOutput :  IEquatable<ReverseRBACOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseRBACOutput" /> class.
        /// </summary>
        /// <param name="clients">clients.</param>
        public ReverseRBACOutput(Dictionary<string, ReverseRBACClient> clients = default(Dictionary<string, ReverseRBACClient>))
        {
            this.Clients = clients;
        }
        
        /// <summary>
        /// Gets or Sets Clients
        /// </summary>
        [DataMember(Name="clients", EmitDefaultValue=false)]
        public Dictionary<string, ReverseRBACClient> Clients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReverseRBACOutput {\n");
            sb.Append("  Clients: ").Append(Clients).Append("\n");
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
            return this.Equals(input as ReverseRBACOutput);
        }

        /// <summary>
        /// Returns true if ReverseRBACOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseRBACOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseRBACOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Clients == input.Clients ||
                    this.Clients != null &&
                    input.Clients != null &&
                    this.Clients.SequenceEqual(input.Clients)
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
                if (this.Clients != null)
                    hashCode = hashCode * 59 + this.Clients.GetHashCode();
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
