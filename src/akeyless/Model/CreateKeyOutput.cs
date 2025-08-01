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
    /// CreateKeyOutput
    /// </summary>
    [DataContract(Name = "createKeyOutput")]
    public partial class CreateKeyOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeyOutput" /> class.
        /// </summary>
        /// <param name="displayId">displayId.</param>
        /// <param name="fragmentResults">fragmentResults.</param>
        /// <param name="itemId">itemId.</param>
        public CreateKeyOutput(string displayId = default(string), List<long> fragmentResults = default(List<long>), long itemId = default(long))
        {
            this.DisplayId = displayId;
            this.FragmentResults = fragmentResults;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Gets or Sets DisplayId
        /// </summary>
        [DataMember(Name = "display_id", EmitDefaultValue = false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// Gets or Sets FragmentResults
        /// </summary>
        [DataMember(Name = "fragment_results", EmitDefaultValue = false)]
        public List<long> FragmentResults { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public long ItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateKeyOutput {\n");
            sb.Append("  DisplayId: ").Append(DisplayId).Append("\n");
            sb.Append("  FragmentResults: ").Append(FragmentResults).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
