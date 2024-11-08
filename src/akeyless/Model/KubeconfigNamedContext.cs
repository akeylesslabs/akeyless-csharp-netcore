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
    /// KubeconfigNamedContext
    /// </summary>
    [DataContract(Name = "KubeconfigNamedContext")]
    public partial class KubeconfigNamedContext : IEquatable<KubeconfigNamedContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KubeconfigNamedContext" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="name">name.</param>
        public KubeconfigNamedContext(KubeconfigContext context = default(KubeconfigContext), string name = default(string))
        {
            this.Context = context;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public KubeconfigContext Context { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KubeconfigNamedContext {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as KubeconfigNamedContext);
        }

        /// <summary>
        /// Returns true if KubeconfigNamedContext instances are equal
        /// </summary>
        /// <param name="input">Instance of KubeconfigNamedContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KubeconfigNamedContext input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Context == input.Context ||
                    (this.Context != null &&
                    this.Context.Equals(input.Context))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Context != null)
                {
                    hashCode = (hashCode * 59) + this.Context.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
