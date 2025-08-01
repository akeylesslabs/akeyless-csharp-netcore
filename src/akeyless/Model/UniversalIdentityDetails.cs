/*
 * Akeyless API
 *
 * The purpose of this application is to provide access to Akeyless API.
 *
 * The version of the OpenAPI document: 3.0
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
    /// UniversalIdentityDetails
    /// </summary>
    [DataContract(Name = "UniversalIdentityDetails")]
    public partial class UniversalIdentityDetails : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalIdentityDetails" /> class.
        /// </summary>
        /// <param name="maxDepth">maxDepth.</param>
        /// <param name="numberOfTokens">numberOfTokens.</param>
        /// <param name="root">root.</param>
        public UniversalIdentityDetails(int maxDepth = default(int), long numberOfTokens = default(long), UIDTokenDetails root = default(UIDTokenDetails))
        {
            this.MaxDepth = maxDepth;
            this.NumberOfTokens = numberOfTokens;
            this.Root = root;
        }

        /// <summary>
        /// Gets or Sets MaxDepth
        /// </summary>
        [DataMember(Name = "max_depth", EmitDefaultValue = false)]
        public int MaxDepth { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfTokens
        /// </summary>
        [DataMember(Name = "number_of_tokens", EmitDefaultValue = false)]
        public long NumberOfTokens { get; set; }

        /// <summary>
        /// Gets or Sets Root
        /// </summary>
        [DataMember(Name = "root", EmitDefaultValue = false)]
        public UIDTokenDetails Root { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UniversalIdentityDetails {\n");
            sb.Append("  MaxDepth: ").Append(MaxDepth).Append("\n");
            sb.Append("  NumberOfTokens: ").Append(NumberOfTokens).Append("\n");
            sb.Append("  Root: ").Append(Root).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
